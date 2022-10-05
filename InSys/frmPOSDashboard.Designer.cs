using System.Windows.Forms;

namespace InSys
{
    partial class frmPOSDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOSDashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.btnViewTransaction = new Guna.UI2.WinForms.Guna2Button();
            this.dgvwRecords = new System.Windows.Forms.DataGridView();
            this.dcolPOSId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolReceiptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolTransactionDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.guna2Chip1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(860, 45);
            this.guna2Panel1.TabIndex = 12;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(12, 12);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(247, 23);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "Point of Sales DashBoard";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewTransaction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnViewTransaction.BorderThickness = 1;
            this.btnViewTransaction.CheckedState.Parent = this.btnViewTransaction;
            this.btnViewTransaction.CustomImages.Parent = this.btnViewTransaction;
            this.btnViewTransaction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnViewTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewTransaction.ForeColor = System.Drawing.Color.White;
            this.btnViewTransaction.HoverState.Parent = this.btnViewTransaction;
            this.btnViewTransaction.Location = new System.Drawing.Point(720, 51);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.ShadowDecoration.Parent = this.btnViewTransaction;
            this.btnViewTransaction.Size = new System.Drawing.Size(122, 36);
            this.btnViewTransaction.TabIndex = 23;
            this.btnViewTransaction.Text = "View Transaction";
            // 
            // dgvwRecords
            // 
            this.dgvwRecords.AllowUserToAddRows = false;
            this.dgvwRecords.AllowUserToDeleteRows = false;
            this.dgvwRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvwRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvwRecords.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvwRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvwRecords.ColumnHeadersHeight = 50;
            this.dgvwRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvwRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcolPOSId,
            this.dcolCustomerId,
            this.dcolReceiptNumber,
            this.dcolCustomerName,
            this.dcolTransactionDateTime,
            this.dcolProductCount,
            this.dcolTotalPrice});
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(21, 93);
            this.dgvwRecords.Name = "dgvwRecords";
            this.dgvwRecords.ReadOnly = true;
            this.dgvwRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvwRecords.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvwRecords.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvwRecords.RowTemplate.Height = 60;
            this.dgvwRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwRecords.Size = new System.Drawing.Size(820, 329);
            this.dgvwRecords.TabIndex = 24;
            // 
            // dcolPOSId
            // 
            this.dcolPOSId.DataPropertyName = "Id";
            this.dcolPOSId.HeaderText = "ID";
            this.dcolPOSId.Name = "dcolPOSId";
            this.dcolPOSId.ReadOnly = true;
            this.dcolPOSId.Visible = false;
            this.dcolPOSId.Width = 110;
            // 
            // dcolCustomerId
            // 
            this.dcolCustomerId.DataPropertyName = "CustomerId";
            this.dcolCustomerId.HeaderText = "Customer Id";
            this.dcolCustomerId.Name = "dcolCustomerId";
            this.dcolCustomerId.ReadOnly = true;
            this.dcolCustomerId.Visible = false;
            // 
            // dcolReceiptNumber
            // 
            this.dcolReceiptNumber.DataPropertyName = "ReceiptNumber";
            this.dcolReceiptNumber.HeaderText = "Receipt Number";
            this.dcolReceiptNumber.Name = "dcolReceiptNumber";
            this.dcolReceiptNumber.ReadOnly = true;
            this.dcolReceiptNumber.Width = 120;
            // 
            // dcolCustomerName
            // 
            this.dcolCustomerName.DataPropertyName = "CustomerName";
            this.dcolCustomerName.HeaderText = "Customer Name";
            this.dcolCustomerName.Name = "dcolCustomerName";
            this.dcolCustomerName.ReadOnly = true;
            this.dcolCustomerName.Width = 200;
            // 
            // dcolTransactionDateTime
            // 
            this.dcolTransactionDateTime.DataPropertyName = "TransactionDateTime";
            this.dcolTransactionDateTime.HeaderText = "Transaction Date";
            this.dcolTransactionDateTime.Name = "dcolTransactionDateTime";
            this.dcolTransactionDateTime.ReadOnly = true;
            this.dcolTransactionDateTime.Width = 200;
            // 
            // dcolProductCount
            // 
            this.dcolProductCount.DataPropertyName = "TotalQuantity";
            this.dcolProductCount.HeaderText = "No. of Products";
            this.dcolProductCount.Name = "dcolProductCount";
            this.dcolProductCount.ReadOnly = true;
            this.dcolProductCount.Width = 150;
            // 
            // dcolTotalPrice
            // 
            this.dcolTotalPrice.DataPropertyName = "TotalPrice";
            this.dcolTotalPrice.HeaderText = "Total Price";
            this.dcolTotalPrice.Name = "dcolTotalPrice";
            this.dcolTotalPrice.ReadOnly = true;
            this.dcolTotalPrice.Width = 150;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(550, 51);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(164, 36);
            this.guna2Button1.TabIndex = 25;
            this.guna2Button1.Text = "Go to Point Of Sales Screen";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // frmPOSDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 434);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dgvwRecords);
            this.Controls.Add(this.btnViewTransaction);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPOSDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button btnViewTransaction;
        private DataGridView dgvwRecords;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridViewTextBoxColumn dcolPOSId;
        private DataGridViewTextBoxColumn dcolCustomerId;
        private DataGridViewTextBoxColumn dcolReceiptNumber;
        private DataGridViewTextBoxColumn dcolCustomerName;
        private DataGridViewTextBoxColumn dcolTransactionDateTime;
        private DataGridViewTextBoxColumn dcolProductCount;
        private DataGridViewTextBoxColumn dcolTotalPrice;
    }
}