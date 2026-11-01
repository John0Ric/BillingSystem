namespace BillingSystem
{
    partial class frmChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnSavePassword = new Button();
            txtNewPassword = new TextBox();
            txtCurrentPassword = new TextBox();
            lblCurrentPass = new Label();
            lblNewPassword = new Label();
            lblTitle = new Label();
            lblRetypePassword = new Label();
            txtRetypePassword = new TextBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(246, 273);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSavePassword
            // 
            btnSavePassword.Location = new Point(87, 273);
            btnSavePassword.Margin = new Padding(3, 4, 3, 4);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(141, 31);
            btnSavePassword.TabIndex = 12;
            btnSavePassword.Text = "Save Password";
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(173, 157);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(236, 27);
            txtNewPassword.TabIndex = 11;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Location = new Point(173, 114);
            txtCurrentPassword.Margin = new Padding(3, 4, 3, 4);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.PasswordChar = '*';
            txtCurrentPassword.Size = new Size(236, 27);
            txtCurrentPassword.TabIndex = 10;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // lblCurrentPass
            // 
            lblCurrentPass.AutoSize = true;
            lblCurrentPass.Location = new Point(42, 117);
            lblCurrentPass.Name = "lblCurrentPass";
            lblCurrentPass.Size = new Size(125, 20);
            lblCurrentPass.TabIndex = 9;
            lblCurrentPass.Text = "Current Password:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(42, 160);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(107, 20);
            lblNewPassword.TabIndex = 8;
            lblNewPassword.Text = "New Password:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkRed;
            lblTitle.Location = new Point(87, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 38);
            lblTitle.TabIndex = 7;
            lblTitle.Text = "CHANGE PASSWORD";
            // 
            // lblRetypePassword
            // 
            lblRetypePassword.AutoSize = true;
            lblRetypePassword.Location = new Point(42, 205);
            lblRetypePassword.Name = "lblRetypePassword";
            lblRetypePassword.Size = new Size(123, 20);
            lblRetypePassword.TabIndex = 14;
            lblRetypePassword.Text = "Retype Password:";
            // 
            // txtRetypePassword
            // 
            txtRetypePassword.Location = new Point(173, 198);
            txtRetypePassword.Margin = new Padding(3, 4, 3, 4);
            txtRetypePassword.Name = "txtRetypePassword";
            txtRetypePassword.PasswordChar = '*';
            txtRetypePassword.Size = new Size(236, 27);
            txtRetypePassword.TabIndex = 15;
            txtRetypePassword.UseSystemPasswordChar = true;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 348);
            Controls.Add(txtRetypePassword);
            Controls.Add(lblRetypePassword);
            Controls.Add(btnCancel);
            Controls.Add(btnSavePassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtCurrentPassword);
            Controls.Add(lblCurrentPass);
            Controls.Add(lblNewPassword);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmChangePassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSavePassword;
        private TextBox txtNewPassword;
        private TextBox txtCurrentPassword;
        private Label lblCurrentPass;
        private Label lblNewPassword;
        private Label lblTitle;
        private Label lblRetypePassword;
        private TextBox txtRetypePassword;
    }
}