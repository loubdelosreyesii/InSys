namespace InSys
{
    partial class frmParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticipant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboxRaffleEvents = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNoOfParticipants = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtNoOfParticipants = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.pnlHeader.Size = new System.Drawing.Size(1139, 45);
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
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(12, 112);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(70, 36);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(88, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(70, 36);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(164, 112);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(70, 36);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
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
            this.txtSearchCustomer.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchCustomer.IconRight")));
            this.txtSearchCustomer.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearchCustomer.Location = new System.Drawing.Point(811, 70);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PlaceholderText = "Search Participants Here...";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.ShadowDecoration.Parent = this.txtSearchCustomer;
            this.txtSearchCustomer.Size = new System.Drawing.Size(315, 36);
            this.txtSearchCustomer.TabIndex = 30;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
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
            this.dgvwRecords.Location = new System.Drawing.Point(12, 154);
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
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvwRecords.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvwRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwRecords.Size = new System.Drawing.Size(1115, 336);
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
            this.dcolTransactionDate.Width = 160;
            // 
            // dcolRaffleReferenceNumber
            // 
            this.dcolRaffleReferenceNumber.DataPropertyName = "RaffleReferenceNumber";
            this.dcolRaffleReferenceNumber.HeaderText = "Raffle Reference No.";
            this.dcolRaffleReferenceNumber.Name = "dcolRaffleReferenceNumber";
            this.dcolRaffleReferenceNumber.ReadOnly = true;
            this.dcolRaffleReferenceNumber.Width = 175;
            // 
            // dcolPaymentReferenceNumber
            // 
            this.dcolPaymentReferenceNumber.DataPropertyName = "PaymentReceipt";
            this.dcolPaymentReferenceNumber.HeaderText = "Payment Reference No.";
            this.dcolPaymentReferenceNumber.Name = "dcolPaymentReferenceNumber";
            this.dcolPaymentReferenceNumber.ReadOnly = true;
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
            this.dcolFirstName.Width = 350;
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
            this.dcolContactNumber.Width = 150;
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
            this.dcolEmailAddress.Width = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Raffle Event";
            // 
            // cboxRaffleEvents
            // 
            this.cboxRaffleEvents.Animated = true;
            this.cboxRaffleEvents.BackColor = System.Drawing.Color.Transparent;
            this.cboxRaffleEvents.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxRaffleEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRaffleEvents.FocusedColor = System.Drawing.Color.Empty;
            this.cboxRaffleEvents.FocusedState.Parent = this.cboxRaffleEvents;
            this.cboxRaffleEvents.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRaffleEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboxRaffleEvents.FormattingEnabled = true;
            this.cboxRaffleEvents.HoverState.Parent = this.cboxRaffleEvents;
            this.cboxRaffleEvents.ItemHeight = 30;
            this.cboxRaffleEvents.ItemsAppearance.Parent = this.cboxRaffleEvents;
            this.cboxRaffleEvents.Location = new System.Drawing.Point(12, 70);
            this.cboxRaffleEvents.Name = "cboxRaffleEvents";
            this.cboxRaffleEvents.ShadowDecoration.Parent = this.cboxRaffleEvents;
            this.cboxRaffleEvents.Size = new System.Drawing.Size(380, 36);
            this.cboxRaffleEvents.TabIndex = 32;
            this.cboxRaffleEvents.SelectedIndexChanged += new System.EventHandler(this.cboxRaffleEvents_SelectedIndexChanged);
            this.cboxRaffleEvents.SelectionChangeCommitted += new System.EventHandler(this.cboxRaffleEvents_SelectionChangeCommitted);
            // 
            // lblNoOfParticipants
            // 
            this.lblNoOfParticipants.AutoSize = true;
            this.lblNoOfParticipants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfParticipants.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNoOfParticipants.Location = new System.Drawing.Point(395, 51);
            this.lblNoOfParticipants.Name = "lblNoOfParticipants";
            this.lblNoOfParticipants.Size = new System.Drawing.Size(115, 16);
            this.lblNoOfParticipants.TabIndex = 36;
            this.lblNoOfParticipants.Text = "No. of Participants";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.Parent = this.txtQuantity;
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedState.Parent = this.txtQuantity;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.HoverState.Parent = this.txtQuantity;
            this.txtQuantity.Location = new System.Drawing.Point(575, 70);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.ShadowDecoration.Parent = this.txtQuantity;
            this.txtQuantity.Size = new System.Drawing.Size(229, 36);
            this.txtQuantity.TabIndex = 41;
            this.txtQuantity.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(572, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "Total Amount Collected";
            this.label7.Visible = false;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pnlHeader;
            // 
            // txtNoOfParticipants
            // 
            this.txtNoOfParticipants.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoOfParticipants.DefaultText = "";
            this.txtNoOfParticipants.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoOfParticipants.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoOfParticipants.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoOfParticipants.DisabledState.Parent = this.txtNoOfParticipants;
            this.txtNoOfParticipants.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoOfParticipants.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoOfParticipants.FocusedState.Parent = this.txtNoOfParticipants;
            this.txtNoOfParticipants.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNoOfParticipants.HoverState.Parent = this.txtNoOfParticipants;
            this.txtNoOfParticipants.Location = new System.Drawing.Point(398, 70);
            this.txtNoOfParticipants.Name = "txtNoOfParticipants";
            this.txtNoOfParticipants.PasswordChar = '\0';
            this.txtNoOfParticipants.PlaceholderText = "";
            this.txtNoOfParticipants.SelectedText = "";
            this.txtNoOfParticipants.ShadowDecoration.Parent = this.txtNoOfParticipants;
            this.txtNoOfParticipants.Size = new System.Drawing.Size(171, 36);
            this.txtNoOfParticipants.TabIndex = 42;
            // 
            // frmParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 502);
            this.Controls.Add(this.txtNoOfParticipants);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNoOfParticipants);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxRaffleEvents);
            this.Controls.Add(this.dgvwRecords);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmParticipant_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomer;
        private System.Windows.Forms.DataGridView dgvwRecords;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboxRaffleEvents;
        private System.Windows.Forms.Label lblNoOfParticipants;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2TextBox txtNoOfParticipants;
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