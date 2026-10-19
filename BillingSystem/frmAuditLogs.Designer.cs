namespace BillingSystem
{
    partial class frmAuditLogs
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
            lblTo = new Label();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            btnClose = new Button();
            btnSearch = new Button();
            dgvAuditLogs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(35, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Audit Log Report";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(399, 76);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(23, 15);
            lblTo.TabIndex = 1;
            lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(132, 76);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(38, 15);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Location = new Point(176, 70);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 23);
            dtpFrom.TabIndex = 3;
            // 
            // dtpTo
            // 
            dtpTo.Location = new Point(428, 70);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 23);
            dtpTo.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(680, 476);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 5;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(680, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvAuditLogs
            // 
            dgvAuditLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAuditLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditLogs.Location = new Point(132, 123);
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.Size = new Size(623, 331);
            dgvAuditLogs.TabIndex = 7;
            // 
            // frmAuditLogs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 511);
            Controls.Add(dgvAuditLogs);
            Controls.Add(btnSearch);
            Controls.Add(btnClose);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(lblTo);
            Controls.Add(lblTitle);
            Name = "frmAuditLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Log Report";
            Load += frmAuditLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblTo;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Button btnClose;
        private Button btnSearch;
        private DataGridView dgvAuditLogs;
    }
}