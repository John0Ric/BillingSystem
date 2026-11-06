namespace BillingSystem
{
    partial class frmBillingHistory
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
            titleLbl = new Label();
            closeBtn = new Button();
            billRecordDGV = new DataGridView();
            billingMonth = new DataGridViewTextBoxColumn();
            previousReading = new DataGridViewTextBoxColumn();
            presentReading = new DataGridViewTextBoxColumn();
            consumption = new DataGridViewTextBoxColumn();
            rate = new DataGridViewTextBoxColumn();
            totalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)billRecordDGV).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.Red;
            titleLbl.Location = new Point(35, 31);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(178, 32);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Billing History";
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(768, 552);
            closeBtn.Margin = new Padding(3, 4, 3, 4);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(86, 31);
            closeBtn.TabIndex = 2;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // billRecordDGV
            // 
            billRecordDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            billRecordDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            billRecordDGV.BackgroundColor = Color.White;
            billRecordDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            billRecordDGV.Columns.AddRange(new DataGridViewColumn[] { billingMonth, previousReading, presentReading, consumption, rate, totalAmount, Status });
            billRecordDGV.Location = new Point(35, 89);
            billRecordDGV.Margin = new Padding(3, 4, 3, 4);
            billRecordDGV.Name = "billRecordDGV";
            billRecordDGV.RowHeadersWidth = 51;
            billRecordDGV.Size = new Size(818, 431);
            billRecordDGV.TabIndex = 3;
            // 
            // billingMonth
            // 
            billingMonth.DataPropertyName = "billingMonth";
            billingMonth.HeaderText = "Billing Month";
            billingMonth.MinimumWidth = 6;
            billingMonth.Name = "billingMonth";
            // 
            // previousReading
            // 
            previousReading.DataPropertyName = "previousReading";
            previousReading.HeaderText = "Previous Reading";
            previousReading.MinimumWidth = 6;
            previousReading.Name = "previousReading";
            // 
            // presentReading
            // 
            presentReading.DataPropertyName = "presentReading";
            presentReading.HeaderText = "Present Reading";
            presentReading.MinimumWidth = 6;
            presentReading.Name = "presentReading";
            // 
            // consumption
            // 
            consumption.DataPropertyName = "consumption";
            consumption.HeaderText = "Consumption";
            consumption.MinimumWidth = 6;
            consumption.Name = "consumption";
            // 
            // rate
            // 
            rate.DataPropertyName = "rate";
            rate.HeaderText = "Rate";
            rate.MinimumWidth = 6;
            rate.Name = "rate";
            // 
            // totalAmount
            // 
            totalAmount.DataPropertyName = "totalAmount";
            totalAmount.HeaderText = "Total Amount";
            totalAmount.MinimumWidth = 6;
            totalAmount.Name = "totalAmount";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 615);
            Controls.Add(billRecordDGV);
            Controls.Add(closeBtn);
            Controls.Add(titleLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBillingHistory";
            Text = "frmBillingHistory";
            ((System.ComponentModel.ISupportInitialize)billRecordDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Button closeBtn;
        private DataGridView billRecordDGV;
        private DataGridViewTextBoxColumn billingMonth;
        private DataGridViewTextBoxColumn previousReading;
        private DataGridViewTextBoxColumn presentReading;
        private DataGridViewTextBoxColumn consumption;
        private DataGridViewTextBoxColumn rate;
        private DataGridViewTextBoxColumn totalAmount;
        private DataGridViewTextBoxColumn Status;
    }
}