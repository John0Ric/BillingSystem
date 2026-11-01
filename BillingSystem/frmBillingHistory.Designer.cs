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
            ((System.ComponentModel.ISupportInitialize)billRecordDGV).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.ForeColor = Color.Red;
            titleLbl.Location = new Point(31, 23);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(139, 25);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Billing History";
            // 
            // closeBtn
            // 
            closeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.Location = new Point(672, 414);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
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
            billRecordDGV.Columns.AddRange(new DataGridViewColumn[] { billingMonth, previousReading, presentReading, consumption, rate, totalAmount });
            billRecordDGV.Location = new Point(31, 67);
            billRecordDGV.Name = "billRecordDGV";
            billRecordDGV.Size = new Size(716, 323);
            billRecordDGV.TabIndex = 3;
            // 
            // billingMonth
            // 
            billingMonth.DataPropertyName = "billingMonth";
            billingMonth.HeaderText = "Billing Month";
            billingMonth.Name = "billingMonth";
            // 
            // previousReading
            // 
            previousReading.DataPropertyName = "previousReading";
            previousReading.HeaderText = "Previous Reading";
            previousReading.Name = "previousReading";
            // 
            // presentReading
            // 
            presentReading.DataPropertyName = "presentReading";
            presentReading.HeaderText = "Present Reading";
            presentReading.Name = "presentReading";
            // 
            // consumption
            // 
            consumption.DataPropertyName = "consumption";
            consumption.HeaderText = "Consumption";
            consumption.Name = "consumption";
            // 
            // rate
            // 
            rate.DataPropertyName = "rate";
            rate.HeaderText = "Rate";
            rate.Name = "rate";
            // 
            // totalAmount
            // 
            totalAmount.DataPropertyName = "totalAmount";
            totalAmount.HeaderText = "Total Amount";
            totalAmount.Name = "totalAmount";
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(billRecordDGV);
            Controls.Add(closeBtn);
            Controls.Add(titleLbl);
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
    }
}