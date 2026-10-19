namespace BillingSystem
{
    partial class frmManagePermissions
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
            lblTitle = new Label();
            lblRole = new Label();
            cmbRole = new ComboBox();
            chkAddCustomer = new CheckBox();
            chkEditCustomer = new CheckBox();
            chkDeleteCustomer = new CheckBox();
            lblPermissions = new Label();
            chkAnalytics = new CheckBox();
            chkExportExcel = new CheckBox();
            chkExportPdf = new CheckBox();
            chkAuditLogs = new CheckBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(123, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Permissions";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(86, 62);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(75, 17);
            lblRole.TabIndex = 1;
            lblRole.Text = "Select Role:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(197, 61);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 2;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // chkAddCustomer
            // 
            chkAddCustomer.AutoSize = true;
            chkAddCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAddCustomer.Location = new Point(120, 131);
            chkAddCustomer.Name = "chkAddCustomer";
            chkAddCustomer.Size = new Size(111, 21);
            chkAddCustomer.TabIndex = 3;
            chkAddCustomer.Text = "Add Customer";
            chkAddCustomer.UseVisualStyleBackColor = true;
            // 
            // chkEditCustomer
            // 
            chkEditCustomer.AutoSize = true;
            chkEditCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEditCustomer.Location = new Point(120, 158);
            chkEditCustomer.Name = "chkEditCustomer";
            chkEditCustomer.Size = new Size(109, 21);
            chkEditCustomer.TabIndex = 4;
            chkEditCustomer.Text = "Edit Customer";
            chkEditCustomer.UseVisualStyleBackColor = true;
            // 
            // chkDeleteCustomer
            // 
            chkDeleteCustomer.AutoSize = true;
            chkDeleteCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDeleteCustomer.Location = new Point(120, 185);
            chkDeleteCustomer.Name = "chkDeleteCustomer";
            chkDeleteCustomer.Size = new Size(124, 21);
            chkDeleteCustomer.TabIndex = 5;
            chkDeleteCustomer.Text = "Delete Customer";
            chkDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // lblPermissions
            // 
            lblPermissions.AutoSize = true;
            lblPermissions.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPermissions.Location = new Point(86, 101);
            lblPermissions.Name = "lblPermissions";
            lblPermissions.Size = new Size(77, 17);
            lblPermissions.TabIndex = 6;
            lblPermissions.Text = "Permissions";
            // 
            // chkAnalytics
            // 
            chkAnalytics.AutoSize = true;
            chkAnalytics.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAnalytics.Location = new Point(120, 212);
            chkAnalytics.Name = "chkAnalytics";
            chkAnalytics.Size = new Size(77, 21);
            chkAnalytics.TabIndex = 7;
            chkAnalytics.Text = "Analytics";
            chkAnalytics.UseVisualStyleBackColor = true;
            // 
            // chkExportExcel
            // 
            chkExportExcel.AutoSize = true;
            chkExportExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkExportExcel.Location = new Point(120, 239);
            chkExportExcel.Name = "chkExportExcel";
            chkExportExcel.Size = new Size(114, 21);
            chkExportExcel.TabIndex = 8;
            chkExportExcel.Text = "Export to Excel";
            chkExportExcel.UseVisualStyleBackColor = true;
            // 
            // chkExportPdf
            // 
            chkExportPdf.AutoSize = true;
            chkExportPdf.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkExportPdf.Location = new Point(120, 266);
            chkExportPdf.Name = "chkExportPdf";
            chkExportPdf.Size = new Size(107, 21);
            chkExportPdf.TabIndex = 9;
            chkExportPdf.Text = "Export to PDF";
            chkExportPdf.UseVisualStyleBackColor = true;
            // 
            // chkAuditLogs
            // 
            chkAuditLogs.AutoSize = true;
            chkAuditLogs.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAuditLogs.Location = new Point(120, 293);
            chkAuditLogs.Name = "chkAuditLogs";
            chkAuditLogs.Size = new Size(89, 21);
            chkAuditLogs.TabIndex = 10;
            chkAuditLogs.Text = "Audit Logs";
            chkAuditLogs.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(86, 347);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save Permissions";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(243, 347);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmManagePermissions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 421);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(chkAuditLogs);
            Controls.Add(chkExportPdf);
            Controls.Add(chkExportExcel);
            Controls.Add(chkAnalytics);
            Controls.Add(lblPermissions);
            Controls.Add(chkDeleteCustomer);
            Controls.Add(chkEditCustomer);
            Controls.Add(chkAddCustomer);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmManagePermissions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Permissions";
            Load += frmManagePermissions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRole;
        private ComboBox cmbRole;
        private CheckBox chkAddCustomer;
        private CheckBox chkEditCustomer;
        private CheckBox chkDeleteCustomer;
        private Label lblPermissions;
        private CheckBox chkAnalytics;
        private CheckBox chkExportExcel;
        private CheckBox chkExportPdf;
        private CheckBox chkAuditLogs;
        private Button btnSave;
        private Button btnClose;
    }
}