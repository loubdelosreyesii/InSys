namespace InSys.CapitalForm
{
    partial class frmCapital
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.txtCurrentBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnAddFund = new System.Windows.Forms.Button();
            this.dgvwPOSTransactions = new System.Windows.Forms.DataGridView();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.pnlAddFund = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblAmountToAdd = new System.Windows.Forms.Label();
            this.txtFundAmountAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnGenReport = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwPOSTransactions)).BeginInit();
            this.pnlAddFund.SuspendLayout();
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
            this.guna2Panel1.Size = new System.Drawing.Size(931, 45);
            this.guna2Panel1.TabIndex = 13;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(0, 12);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(247, 23);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "Capital and Running Balance";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentBalance.DefaultText = "";
            this.txtCurrentBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentBalance.DisabledState.Parent = this.txtCurrentBalance;
            this.txtCurrentBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentBalance.FocusedState.Parent = this.txtCurrentBalance;
            this.txtCurrentBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCurrentBalance.HoverState.Parent = this.txtCurrentBalance;
            this.txtCurrentBalance.Location = new System.Drawing.Point(15, 64);
            this.txtCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.PasswordChar = '\0';
            this.txtCurrentBalance.PlaceholderText = "";
            this.txtCurrentBalance.SelectedText = "";
            this.txtCurrentBalance.ShadowDecoration.Parent = this.txtCurrentBalance;
            this.txtCurrentBalance.Size = new System.Drawing.Size(195, 28);
            this.txtCurrentBalance.TabIndex = 47;
            this.txtCurrentBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCurrentBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentBalance_KeyPress);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.BackColor = System.Drawing.SystemColors.Control;
            this.lblBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBalance.Location = new System.Drawing.Point(12, 48);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(96, 15);
            this.lblBalance.TabIndex = 120;
            this.lblBalance.Text = "Current Balance";
            // 
            // btnAddFund
            // 
            this.btnAddFund.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddFund.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddFund.FlatAppearance.BorderSize = 0;
            this.btnAddFund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFund.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddFund.ForeColor = System.Drawing.Color.White;
            this.btnAddFund.Location = new System.Drawing.Point(214, 67);
            this.btnAddFund.Name = "btnAddFund";
            this.btnAddFund.Size = new System.Drawing.Size(84, 24);
            this.btnAddFund.TabIndex = 121;
            this.btnAddFund.Text = "&Add Fund";
            this.btnAddFund.UseVisualStyleBackColor = false;
            this.btnAddFund.Click += new System.EventHandler(this.btnAddFund_Click);
            // 
            // dgvwPOSTransactions
            // 
            this.dgvwPOSTransactions.AllowUserToAddRows = false;
            this.dgvwPOSTransactions.AllowUserToDeleteRows = false;
            this.dgvwPOSTransactions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvwPOSTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvwPOSTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwPOSTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvwPOSTransactions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvwPOSTransactions.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwPOSTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvwPOSTransactions.ColumnHeadersHeight = 30;
            this.dgvwPOSTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvwPOSTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvwPOSTransactions.EnableHeadersVisualStyles = false;
            this.dgvwPOSTransactions.Location = new System.Drawing.Point(0, 97);
            this.dgvwPOSTransactions.Name = "dgvwPOSTransactions";
            this.dgvwPOSTransactions.ReadOnly = true;
            this.dgvwPOSTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwPOSTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvwPOSTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvwPOSTransactions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvwPOSTransactions.RowTemplate.Height = 23;
            this.dgvwPOSTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwPOSTransactions.Size = new System.Drawing.Size(931, 352);
            this.dgvwPOSTransactions.TabIndex = 123;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(599, 66);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(118, 24);
            this.btnGenerateReport.TabIndex = 124;
            this.btnGenerateReport.Text = "Search Transactions";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // pnlAddFund
            // 
            this.pnlAddFund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddFund.Controls.Add(this.button2);
            this.pnlAddFund.Controls.Add(this.lblAmountToAdd);
            this.pnlAddFund.Controls.Add(this.txtFundAmountAdd);
            this.pnlAddFund.Controls.Add(this.btnProceed);
            this.pnlAddFund.Location = new System.Drawing.Point(15, 94);
            this.pnlAddFund.Name = "pnlAddFund";
            this.pnlAddFund.Size = new System.Drawing.Size(240, 97);
            this.pnlAddFund.TabIndex = 125;
            this.pnlAddFund.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(151, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 24);
            this.button2.TabIndex = 125;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblAmountToAdd
            // 
            this.lblAmountToAdd.AutoSize = true;
            this.lblAmountToAdd.BackColor = System.Drawing.SystemColors.Control;
            this.lblAmountToAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAmountToAdd.Location = new System.Drawing.Point(23, 9);
            this.lblAmountToAdd.Name = "lblAmountToAdd";
            this.lblAmountToAdd.Size = new System.Drawing.Size(123, 15);
            this.lblAmountToAdd.TabIndex = 124;
            this.lblAmountToAdd.Text = "Fund Amount To Add";
            // 
            // txtFundAmountAdd
            // 
            this.txtFundAmountAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFundAmountAdd.DefaultText = "";
            this.txtFundAmountAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFundAmountAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFundAmountAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFundAmountAdd.DisabledState.Parent = this.txtFundAmountAdd;
            this.txtFundAmountAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFundAmountAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFundAmountAdd.FocusedState.Parent = this.txtFundAmountAdd;
            this.txtFundAmountAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFundAmountAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFundAmountAdd.HoverState.Parent = this.txtFundAmountAdd;
            this.txtFundAmountAdd.Location = new System.Drawing.Point(26, 27);
            this.txtFundAmountAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFundAmountAdd.Name = "txtFundAmountAdd";
            this.txtFundAmountAdd.PasswordChar = '\0';
            this.txtFundAmountAdd.PlaceholderText = "";
            this.txtFundAmountAdd.SelectedText = "";
            this.txtFundAmountAdd.ShadowDecoration.Parent = this.txtFundAmountAdd;
            this.txtFundAmountAdd.Size = new System.Drawing.Size(195, 28);
            this.txtFundAmountAdd.TabIndex = 123;
            this.txtFundAmountAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.ForestGreen;
            this.btnProceed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProceed.FlatAppearance.BorderSize = 0;
            this.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(75, 61);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(70, 24);
            this.btnProceed.TabIndex = 122;
            this.btnProceed.Text = "&Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(311, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 130;
            this.label3.Text = "Transaction Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(460, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 129;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(311, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 128;
            this.label1.Text = "From";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(486, 66);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(108, 20);
            this.dtpTo.TabIndex = 127;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(346, 66);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(108, 20);
            this.dtpFrom.TabIndex = 126;
            // 
            // btnGenReport
            // 
            this.btnGenReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGenReport.FlatAppearance.BorderSize = 0;
            this.btnGenReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenReport.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnGenReport.ForeColor = System.Drawing.Color.White;
            this.btnGenReport.Location = new System.Drawing.Point(723, 66);
            this.btnGenReport.Name = "btnGenReport";
            this.btnGenReport.Size = new System.Drawing.Size(113, 24);
            this.btnGenReport.TabIndex = 131;
            this.btnGenReport.Text = "Generate Report";
            this.btnGenReport.UseVisualStyleBackColor = false;
            this.btnGenReport.Click += new System.EventHandler(this.btnGenReport_Click);
            // 
            // frmCapital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.btnGenReport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.pnlAddFund);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvwPOSTransactions);
            this.Controls.Add(this.btnAddFund);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtCurrentBalance);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmCapital";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCapital_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwPOSTransactions)).EndInit();
            this.pnlAddFund.ResumeLayout(false);
            this.pnlAddFund.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentBalance;
        internal System.Windows.Forms.Label lblBalance;
        internal System.Windows.Forms.Button btnAddFund;
        private System.Windows.Forms.DataGridView dgvwPOSTransactions;
        internal System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Panel pnlAddFund;
        internal System.Windows.Forms.Label lblAmountToAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtFundAmountAdd;
        internal System.Windows.Forms.Button btnProceed;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        internal System.Windows.Forms.Button btnGenReport;
    }
}