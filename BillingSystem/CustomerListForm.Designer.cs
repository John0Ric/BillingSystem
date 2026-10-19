namespace BillingSystem
{
    partial class CustomerListForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSearch = new Label();
            dgvCustomers = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnLogout = new Button();
            btnAnalytics = new Button();
            btnExportExcel = new Button();
            btnExportPdf = new Button();
            btnAuditLog = new Button();
            btnManagePermissions = new Button();
            statusStrip1 = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            lblStatusSep = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            statusTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("SimSun", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(271, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer List";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(43, 98);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(48, 14);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search:";
            // 
            // dgvCustomers
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.FromArgb(255, 245, 245);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(247, 214, 208);
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Address, ContactNumber, Email, Balance });
            dgvCustomers.Location = new Point(33, 140);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(717, 248);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            dgvCustomers.CellFormatting += dgvCustomers_CellFormatting;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "ID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ContactNumber
            // 
            ContactNumber.DataPropertyName = "ContactNumber";
            ContactNumber.HeaderText = "Contact No.";
            ContactNumber.MinimumWidth = 6;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.DataPropertyName = "Balance";
            Balance.HeaderText = "Balance";
            Balance.MinimumWidth = 6;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(226, 180, 189);
            btnAdd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(43, 403);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(247, 214, 208);
            btnDelete.Font = new Font("Tahoma", 9F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(200, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(74, 74, 74);
            btnSearch.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(675, 94);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(247, 214, 208);
            txtSearch.ForeColor = Color.Black;
            txtSearch.Location = new Point(107, 94);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "  Search customer...";
            txtSearch.Size = new Size(546, 23);
            txtSearch.TabIndex = 6;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(226, 180, 189);
            btnLogout.Font = new Font("Tahoma", 9F);
            btnLogout.Location = new Point(630, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 23);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAnalytics
            // 
            btnAnalytics.BackColor = Color.FromArgb(226, 180, 189);
            btnAnalytics.Font = new Font("Tahoma", 9F);
            btnAnalytics.Location = new Point(325, 403);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(129, 23);
            btnAnalytics.TabIndex = 8;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.UseVisualStyleBackColor = false;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.BackColor = Color.FromArgb(226, 180, 189);
            btnExportExcel.Font = new Font("Tahoma", 9F);
            btnExportExcel.Location = new Point(12, 45);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(107, 23);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Export to Excel";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.BackColor = Color.FromArgb(226, 180, 189);
            btnExportPdf.Font = new Font("Tahoma", 9F);
            btnExportPdf.Location = new Point(12, 12);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(107, 23);
            btnExportPdf.TabIndex = 10;
            btnExportPdf.Text = "Export to PDF";
            btnExportPdf.UseVisualStyleBackColor = false;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnAuditLog
            // 
            btnAuditLog.BackColor = Color.FromArgb(226, 180, 189);
            btnAuditLog.Font = new Font("Tahoma", 9F);
            btnAuditLog.Location = new Point(474, 403);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(107, 23);
            btnAuditLog.TabIndex = 11;
            btnAuditLog.Text = "Audit Log";
            btnAuditLog.UseVisualStyleBackColor = false;
            btnAuditLog.Click += btnAuditLog_Click;
            // 
            // btnManagePermissions
            // 
            btnManagePermissions.BackColor = Color.FromArgb(226, 180, 189);
            btnManagePermissions.Font = new Font("Tahoma", 9F);
            btnManagePermissions.Location = new Point(596, 403);
            btnManagePermissions.Name = "btnManagePermissions";
            btnManagePermissions.Size = new Size(142, 23);
            btnManagePermissions.TabIndex = 12;
            btnManagePermissions.Text = "Manage Permissions";
            btnManagePermissions.UseVisualStyleBackColor = false;
            btnManagePermissions.Click += btnManagePermissions_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusUser, lblStatusSep, lblStatusTime });
            statusStrip1.Location = new Point(0, 439);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 13;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(62, 17);
            lblStatusUser.Text = "User: Role:";
            // 
            // lblStatusSep
            // 
            lblStatusSep.Name = "lblStatusSep";
            lblStatusSep.Size = new Size(589, 17);
            lblStatusSep.Spring = true;
            lblStatusSep.Text = "toolStripStatusLabel2";
            // 
            // lblStatusTime
            // 
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(118, 17);
            lblStatusTime.Text = "toolStripStatusLabel3";
            // 
            // statusTimer
            // 
            statusTimer.Enabled = true;
            statusTimer.Interval = 1000;
            statusTimer.Tick += statusTimer_Tick;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 245, 245);
            ClientSize = new Size(784, 461);
            Controls.Add(statusStrip1);
            Controls.Add(btnManagePermissions);
            Controls.Add(btnAuditLog);
            Controls.Add(btnExportPdf);
            Controls.Add(btnExportExcel);
            Controls.Add(btnAnalytics);
            Controls.Add(btnLogout);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomers);
            Controls.Add(lblSearch);
            Controls.Add(lblTitle);
            Name = "CustomerListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Billing System v1.0 – Customer List (C.D.)";
            Load += CustomerListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSearch;
        private DataGridView dgvCustomers;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private Button btnLogout;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Balance;
        private Button btnAnalytics;
        private Button btnExportExcel;
        private Button btnExportPdf;
        private Button btnAuditLog;
        private Button btnManagePermissions;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusSep;
        private ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer statusTimer;
    }
}