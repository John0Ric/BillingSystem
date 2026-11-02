using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;
using BillingSystem.Utils;

namespace BillingSystem
{
    public partial class frmChangePassword : Form
    {
        private int userID;

        public frmChangePassword()
        {
            InitializeComponent();
            userID = AppSession.CurrentUserID;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string retypePassword = txtRetypePassword.Text;

            // 1. Check required fields
            if (string.IsNullOrWhiteSpace(currentPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(retypePassword))
            {
                MessageBox.Show(
                    "Please fill in all password fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            AuditLogger.Log("CHANGE PASSWORD",
                $"{AppSession.CurrentUsername} changed their password from {currentPassword} to {newPassword}");

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // 2. Verify the current password
                    string checkSql = @"SELECT Password
                                FROM Users
                                WHERE UserID = @UserID;";

                    string storedPassword = "";

                    using (MySqlCommand cmd = new MySqlCommand(checkSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            storedPassword = result.ToString();
                        }
                        else
                        {
                            MessageBox.Show(
                                "User account could not be found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (currentPassword != storedPassword)
                    {
                        MessageBox.Show(
                            "Your current password is incorrect.",
                            "Incorrect Password",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        txtCurrentPassword.Clear();
                        txtCurrentPassword.Focus();
                        return;
                    }

                    // 3. Check if the new passwords match
                    if (newPassword != retypePassword)
                    {
                        MessageBox.Show(
                            "New Password and Retype Password do not match.",
                            "Password Mismatch",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtRetypePassword.Clear();
                        txtRetypePassword.Focus();
                        return;
                    }

                    // 4. Check all five password requirements
                    StringBuilder errors = new StringBuilder();

                    if (newPassword.Length < 8)
                    {
                        errors.AppendLine("- At least 8 characters long.");
                    }

                    if (!newPassword.Any(char.IsUpper))
                    {
                        errors.AppendLine("- At least one uppercase letter (A-Z).");
                    }

                    if (!newPassword.Any(char.IsLower))
                    {
                        errors.AppendLine("- At least one lowercase letter (a-z).");
                    }

                    if (!newPassword.Any(char.IsDigit))
                    {
                        errors.AppendLine("- At least one numeric digit (0-9).");
                    }

                    if (!newPassword.Any(c => char.IsPunctuation(c) || char.IsSymbol(c)))
                    {
                        errors.AppendLine("- At least one special character (e.g. !@#$%^&*).");
                    }

                    if (errors.Length > 0)
                    {
                        MessageBox.Show(
                            "Your new password does not meet the following requirements:\n\n"
                            + errors.ToString(),
                            "Password Requirements",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        txtNewPassword.Focus();
                        return;
                    }

                    // 5. Update the password in the database
                    string updateSql = @"UPDATE Users
                                 SET Password = @NewPassword
                                 WHERE UserID = @UserID
                                 AND Password = @CurrentPassword;";

                    using (MySqlCommand cmd = new MySqlCommand(updateSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 1)
                        {
                            MessageBox.Show(
                                "Your password has been changed successfully!",
                                "Password Changed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Password could not be changed. Please try again.",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An error occurred while changing your password:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

