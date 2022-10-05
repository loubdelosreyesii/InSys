namespace RaffleUI
{
    partial class frmParticipantView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticipantView));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dgvwRecords = new System.Windows.Forms.DataGridView();
            this.dcolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolParticipantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolRaffleReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolPaymentReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolFacebookLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolEmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.guna2Chip1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(424, 45);
            this.pnlHeader.TabIndex = 25;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(12, 6);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(247, 23);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "Participants List";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
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
            this.dcolID,
            this.dcolParticipantId,
            this.dcolTransactionDate,
            this.dcolRaffleReferenceNumber,
            this.dcolPaymentReferenceNumber,
            this.dcolLastName,
            this.dcolFirstName,
            this.dcolMiddleName,
            this.dcolContactNumber,
            this.dcolFacebookLink,
            this.dcolEmailAddress});
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(12, 93);
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
            this.dgvwRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwRecords.Size = new System.Drawing.Size(400, 397);
            this.dgvwRecords.TabIndex = 31;
            // 
            // dcolID
            // 
            this.dcolID.DataPropertyName = "ID";
            this.dcolID.HeaderText = "ID";
            this.dcolID.Name = "dcolID";
            this.dcolID.ReadOnly = true;
            this.dcolID.Visible = false;
            this.dcolID.Width = 50;
            // 
            // dcolParticipantId
            // 
            this.dcolParticipantId.DataPropertyName = "ParticipantId";
            this.dcolParticipantId.HeaderText = "PartcipantId";
            this.dcolParticipantId.Name = "dcolParticipantId";
            this.dcolParticipantId.ReadOnly = true;
            this.dcolParticipantId.Visible = false;
            // 
            // dcolTransactionDate
            // 
            this.dcolTransactionDate.DataPropertyName = "TransactionDateTime";
            this.dcolTransactionDate.HeaderText = "Transaction Date";
            this.dcolTransactionDate.Name = "dcolTransactionDate";
            this.dcolTransactionDate.ReadOnly = true;
            this.dcolTransactionDate.Visible = false;
            this.dcolTransactionDate.Width = 160;
            // 
            // dcolRaffleReferenceNumber
            // 
            this.dcolRaffleReferenceNumber.DataPropertyName = "RaffleReferenceNumber";
            this.dcolRaffleReferenceNumber.HeaderText = "Raffle Reference No.";
            this.dcolRaffleReferenceNumber.Name = "dcolRaffleReferenceNumber";
            this.dcolRaffleReferenceNumber.ReadOnly = true;
            this.dcolRaffleReferenceNumber.Visible = false;
            this.dcolRaffleReferenceNumber.Width = 175;
            // 
            // dcolPaymentReferenceNumber
            // 
            this.dcolPaymentReferenceNumber.DataPropertyName = "PaymentReceipt";
            this.dcolPaymentReferenceNumber.HeaderText = "Payment Reference No.";
            this.dcolPaymentReferenceNumber.Name = "dcolPaymentReferenceNumber";
            this.dcolPaymentReferenceNumber.ReadOnly = true;
            this.dcolPaymentReferenceNumber.Visible = false;
            this.dcolPaymentReferenceNumber.Width = 175;
            // 
            // dcolLastName
            // 
            this.dcolLastName.DataPropertyName = "LastName";
            this.dcolLastName.HeaderText = "Last Name";
            this.dcolLastName.Name = "dcolLastName";
            this.dcolLastName.ReadOnly = true;
            this.dcolLastName.Visible = false;
            // 
            // dcolFirstName
            // 
            this.dcolFirstName.DataPropertyName = "FirstName";
            this.dcolFirstName.HeaderText = "Participant Name";
            this.dcolFirstName.Name = "dcolFirstName";
            this.dcolFirstName.ReadOnly = true;
            this.dcolFirstName.Width = 400;
            // 
            // dcolMiddleName
            // 
            this.dcolMiddleName.DataPropertyName = "MiddleName";
            this.dcolMiddleName.HeaderText = "Middle Name";
            this.dcolMiddleName.Name = "dcolMiddleName";
            this.dcolMiddleName.ReadOnly = true;
            this.dcolMiddleName.Visible = false;
            // 
            // dcolContactNumber
            // 
            this.dcolContactNumber.DataPropertyName = "ContactNumber";
            this.dcolContactNumber.HeaderText = "Contact Number";
            this.dcolContactNumber.Name = "dcolContactNumber";
            this.dcolContactNumber.ReadOnly = true;
            this.dcolContactNumber.Visible = false;
            this.dcolContactNumber.Width = 130;
            // 
            // dcolFacebookLink
            // 
            this.dcolFacebookLink.DataPropertyName = "FacebookLink";
            this.dcolFacebookLink.HeaderText = "Facebook Link";
            this.dcolFacebookLink.Name = "dcolFacebookLink";
            this.dcolFacebookLink.ReadOnly = true;
            this.dcolFacebookLink.Visible = false;
            this.dcolFacebookLink.Width = 140;
            // 
            // dcolEmailAddress
            // 
            this.dcolEmailAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dcolEmailAddress.DataPropertyName = "EmailAddress";
            this.dcolEmailAddress.HeaderText = "Email Address";
            this.dcolEmailAddress.Name = "dcolEmailAddress";
            this.dcolEmailAddress.ReadOnly = true;
            this.dcolEmailAddress.Visible = false;
            this.dcolEmailAddress.Width = 108;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pnlHeader;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.AutoRoundedCorners = true;
            this.txtSearchCustomer.BorderRadius = 17;
            this.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomer.DefaultText = "";
            this.txtSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.DisabledState.Parent = this.txtSearchCustomer;
            this.txtSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.FocusedState.Parent = this.txtSearchCustomer;
            this.txtSearchCustomer.Font = new System.Drawing.Font("Mada", 9.75F);
            this.txtSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.HoverState.Parent = this.txtSearchCustomer;
            this.txtSearchCustomer.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearchCustomer.IconLeftSize = new System.Drawing.Size(17, 17);
            this.txtSearchCustomer.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearchCustomer.Location = new System.Drawing.Point(13, 51);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PlaceholderText = "Search Participants Here...";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.ShadowDecoration.Parent = this.txtSearchCustomer;
            this.txtSearchCustomer.Size = new System.Drawing.Size(401, 36);
            this.txtSearchCustomer.TabIndex = 30;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // frmParticipantView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 502);
            this.Controls.Add(this.dgvwRecords);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmParticipantView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmParticipant_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.DataGridView dgvwRecords;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolParticipantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolRaffleReferenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolPaymentReferenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolFacebookLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolEmailAddress;
    }
}