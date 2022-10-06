namespace InSys
{
    partial class frmParticipantEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticipantEntry));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentReferenceNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPaidAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboxPaymentMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboxRaffleEntries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudRaffleEntriesCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dgvwRecords = new System.Windows.Forms.DataGridView();
            this.dcolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolParticipantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolPaymentReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolModeOfPaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolModeOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolRaffleReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolRaffleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolNumber1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolNumber2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolNumber3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtRafflePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRaffleDrawDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRaffleEntriesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.guna2Chip1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(843, 45);
            this.pnlHeader.TabIndex = 18;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(12, 12);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(197, 23);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "Participant Entries";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(758, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(70, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderThickness = 1;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(682, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(70, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(14, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Payment Reference Number";
            // 
            // txtPaymentReferenceNumber
            // 
            this.txtPaymentReferenceNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentReferenceNumber.DefaultText = "";
            this.txtPaymentReferenceNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaymentReferenceNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaymentReferenceNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentReferenceNumber.DisabledState.Parent = this.txtPaymentReferenceNumber;
            this.txtPaymentReferenceNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentReferenceNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentReferenceNumber.FocusedState.Parent = this.txtPaymentReferenceNumber;
            this.txtPaymentReferenceNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentReferenceNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentReferenceNumber.HoverState.Parent = this.txtPaymentReferenceNumber;
            this.txtPaymentReferenceNumber.Location = new System.Drawing.Point(17, 140);
            this.txtPaymentReferenceNumber.Name = "txtPaymentReferenceNumber";
            this.txtPaymentReferenceNumber.PasswordChar = '\0';
            this.txtPaymentReferenceNumber.PlaceholderText = "Enter Payment Reference Number Here...";
            this.txtPaymentReferenceNumber.SelectedText = "";
            this.txtPaymentReferenceNumber.ShadowDecoration.Parent = this.txtPaymentReferenceNumber;
            this.txtPaymentReferenceNumber.Size = new System.Drawing.Size(353, 36);
            this.txtPaymentReferenceNumber.TabIndex = 1;
            this.txtPaymentReferenceNumber.TextChanged += new System.EventHandler(this.txtPaymentReferenceNumber_TextChanged);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaidAmount.DefaultText = "";
            this.txtPaidAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaidAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaidAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaidAmount.DisabledState.Parent = this.txtPaidAmount;
            this.txtPaidAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaidAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaidAmount.FocusedState.Parent = this.txtPaidAmount;
            this.txtPaidAmount.ForeColor = System.Drawing.Color.Black;
            this.txtPaidAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaidAmount.HoverState.Parent = this.txtPaidAmount;
            this.txtPaidAmount.Location = new System.Drawing.Point(17, 207);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.PasswordChar = '\0';
            this.txtPaidAmount.PlaceholderText = "Enter Paid Amount Here...";
            this.txtPaidAmount.SelectedText = "";
            this.txtPaidAmount.ShadowDecoration.Parent = this.txtPaidAmount;
            this.txtPaidAmount.Size = new System.Drawing.Size(174, 36);
            this.txtPaidAmount.TabIndex = 2;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaidAmount_KeyPress);
            this.txtPaidAmount.Leave += new System.EventHandler(this.txtPaidAmount_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Paid Amount";
            // 
            // cboxPaymentMethod
            // 
            this.cboxPaymentMethod.Animated = true;
            this.cboxPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.cboxPaymentMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPaymentMethod.FocusedColor = System.Drawing.Color.Empty;
            this.cboxPaymentMethod.FocusedState.Parent = this.cboxPaymentMethod;
            this.cboxPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPaymentMethod.ForeColor = System.Drawing.Color.Black;
            this.cboxPaymentMethod.FormattingEnabled = true;
            this.cboxPaymentMethod.HoverState.Parent = this.cboxPaymentMethod;
            this.cboxPaymentMethod.ItemHeight = 30;
            this.cboxPaymentMethod.ItemsAppearance.Parent = this.cboxPaymentMethod;
            this.cboxPaymentMethod.Location = new System.Drawing.Point(197, 207);
            this.cboxPaymentMethod.Name = "cboxPaymentMethod";
            this.cboxPaymentMethod.ShadowDecoration.Parent = this.cboxPaymentMethod;
            this.cboxPaymentMethod.Size = new System.Drawing.Size(174, 36);
            this.cboxPaymentMethod.TabIndex = 3;
            this.cboxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cboxPaymentMethod_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(194, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Payment Method ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Raffle Entry to Join";
            // 
            // cboxRaffleEntries
            // 
            this.cboxRaffleEntries.Animated = true;
            this.cboxRaffleEntries.BackColor = System.Drawing.Color.Transparent;
            this.cboxRaffleEntries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxRaffleEntries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRaffleEntries.FocusedColor = System.Drawing.Color.Empty;
            this.cboxRaffleEntries.FocusedState.Parent = this.cboxRaffleEntries;
            this.cboxRaffleEntries.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRaffleEntries.ForeColor = System.Drawing.Color.Black;
            this.cboxRaffleEntries.FormattingEnabled = true;
            this.cboxRaffleEntries.HoverState.Parent = this.cboxRaffleEntries;
            this.cboxRaffleEntries.ItemHeight = 30;
            this.cboxRaffleEntries.ItemsAppearance.Parent = this.cboxRaffleEntries;
            this.cboxRaffleEntries.Location = new System.Drawing.Point(17, 78);
            this.cboxRaffleEntries.Name = "cboxRaffleEntries";
            this.cboxRaffleEntries.ShadowDecoration.Parent = this.cboxRaffleEntries;
            this.cboxRaffleEntries.Size = new System.Drawing.Size(353, 36);
            this.cboxRaffleEntries.TabIndex = 4;
            this.cboxRaffleEntries.SelectedIndexChanged += new System.EventHandler(this.cboxRaffleEntries_SelectedIndexChanged);
            // 
            // nudRaffleEntriesCount
            // 
            this.nudRaffleEntriesCount.BackColor = System.Drawing.Color.Transparent;
            this.nudRaffleEntriesCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudRaffleEntriesCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudRaffleEntriesCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudRaffleEntriesCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudRaffleEntriesCount.DisabledState.Parent = this.nudRaffleEntriesCount;
            this.nudRaffleEntriesCount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudRaffleEntriesCount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudRaffleEntriesCount.Enabled = false;
            this.nudRaffleEntriesCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudRaffleEntriesCount.FocusedState.Parent = this.nudRaffleEntriesCount;
            this.nudRaffleEntriesCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRaffleEntriesCount.ForeColor = System.Drawing.Color.Black;
            this.nudRaffleEntriesCount.Location = new System.Drawing.Point(17, 265);
            this.nudRaffleEntriesCount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudRaffleEntriesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRaffleEntriesCount.Name = "nudRaffleEntriesCount";
            this.nudRaffleEntriesCount.ShadowDecoration.Parent = this.nudRaffleEntriesCount;
            this.nudRaffleEntriesCount.Size = new System.Drawing.Size(139, 36);
            this.nudRaffleEntriesCount.TabIndex = 5;
            this.nudRaffleEntriesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRaffleEntriesCount.ValueChanged += new System.EventHandler(this.nudRaffleEntriesCount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(16, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "No. of Raffle Entries";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(16, 315);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(812, 10);
            this.guna2Separator1.TabIndex = 57;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pnlHeader;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(373, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "List of Raffle Reference No.";
            // 
            // dgvwRecords
            // 
            this.dgvwRecords.AllowUserToAddRows = false;
            this.dgvwRecords.AllowUserToDeleteRows = false;
            this.dgvwRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvwRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvwRecords.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvwRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mada", 9.75F);
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
            this.dcolPaymentReferenceNumber,
            this.dcolPaidAmount,
            this.dcolModeOfPaymentId,
            this.dcolModeOfPayment,
            this.dcolRaffleReferenceNumber,
            this.dcolTransactionDate,
            this.dcolRaffleId,
            this.dcolNumber1,
            this.dcolNumber2,
            this.dcolNumber3});
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(376, 140);
            this.dgvwRecords.Name = "dgvwRecords";
            this.dgvwRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mada", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvwRecords.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvwRecords.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvwRecords.RowTemplate.Height = 20;
            this.dgvwRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwRecords.Size = new System.Drawing.Size(453, 161);
            this.dgvwRecords.TabIndex = 61;
            this.dgvwRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwRecords_CellContentClick);
            this.dgvwRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwRecords_CellDoubleClick);
            this.dgvwRecords.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwRecords_RowLeave);
            // 
            // dcolID
            // 
            this.dcolID.DataPropertyName = "Id";
            this.dcolID.HeaderText = "#";
            this.dcolID.Name = "dcolID";
            this.dcolID.ReadOnly = true;
            this.dcolID.Visible = false;
            this.dcolID.Width = 40;
            // 
            // dcolParticipantId
            // 
            this.dcolParticipantId.DataPropertyName = "ParticipantId";
            this.dcolParticipantId.HeaderText = "ParticipantId";
            this.dcolParticipantId.Name = "dcolParticipantId";
            this.dcolParticipantId.ReadOnly = true;
            this.dcolParticipantId.Visible = false;
            // 
            // dcolPaymentReferenceNumber
            // 
            this.dcolPaymentReferenceNumber.DataPropertyName = "PaymentReceipt";
            this.dcolPaymentReferenceNumber.HeaderText = "Payment Reference No.";
            this.dcolPaymentReferenceNumber.Name = "dcolPaymentReferenceNumber";
            this.dcolPaymentReferenceNumber.ReadOnly = true;
            this.dcolPaymentReferenceNumber.Visible = false;
            this.dcolPaymentReferenceNumber.Width = 200;
            // 
            // dcolPaidAmount
            // 
            this.dcolPaidAmount.DataPropertyName = "PaidAmount";
            this.dcolPaidAmount.HeaderText = "Paid Amount";
            this.dcolPaidAmount.Name = "dcolPaidAmount";
            this.dcolPaidAmount.ReadOnly = true;
            this.dcolPaidAmount.Visible = false;
            // 
            // dcolModeOfPaymentId
            // 
            this.dcolModeOfPaymentId.DataPropertyName = "PaymentMethod";
            this.dcolModeOfPaymentId.HeaderText = "Mode Of Payment Id";
            this.dcolModeOfPaymentId.Name = "dcolModeOfPaymentId";
            this.dcolModeOfPaymentId.ReadOnly = true;
            this.dcolModeOfPaymentId.Visible = false;
            // 
            // dcolModeOfPayment
            // 
            this.dcolModeOfPayment.DataPropertyName = "PaymentMethod";
            this.dcolModeOfPayment.HeaderText = "Payment Method";
            this.dcolModeOfPayment.Name = "dcolModeOfPayment";
            this.dcolModeOfPayment.ReadOnly = true;
            this.dcolModeOfPayment.Visible = false;
            // 
            // dcolRaffleReferenceNumber
            // 
            this.dcolRaffleReferenceNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolRaffleReferenceNumber.DataPropertyName = "RaffleReferenceNumber";
            this.dcolRaffleReferenceNumber.HeaderText = "Raffle Reference No.";
            this.dcolRaffleReferenceNumber.Name = "dcolRaffleReferenceNumber";
            this.dcolRaffleReferenceNumber.ReadOnly = true;
            // 
            // dcolTransactionDate
            // 
            this.dcolTransactionDate.DataPropertyName = "TransactionDateTime";
            this.dcolTransactionDate.HeaderText = "Transaction Date";
            this.dcolTransactionDate.Name = "dcolTransactionDate";
            this.dcolTransactionDate.ReadOnly = true;
            this.dcolTransactionDate.Visible = false;
            // 
            // dcolRaffleId
            // 
            this.dcolRaffleId.DataPropertyName = "RaffleId";
            this.dcolRaffleId.HeaderText = "Raffle Entered";
            this.dcolRaffleId.Name = "dcolRaffleId";
            this.dcolRaffleId.ReadOnly = true;
            this.dcolRaffleId.Visible = false;
            this.dcolRaffleId.Width = 160;
            // 
            // dcolNumber1
            // 
            this.dcolNumber1.DataPropertyName = "LuckyNumber1";
            this.dcolNumber1.HeaderText = "Number 1";
            this.dcolNumber1.Name = "dcolNumber1";
            this.dcolNumber1.Width = 80;
            // 
            // dcolNumber2
            // 
            this.dcolNumber2.DataPropertyName = "LuckyNumber2";
            this.dcolNumber2.HeaderText = "Number 2";
            this.dcolNumber2.Name = "dcolNumber2";
            this.dcolNumber2.Width = 80;
            // 
            // dcolNumber3
            // 
            this.dcolNumber3.DataPropertyName = "LuckyNumber3";
            this.dcolNumber3.HeaderText = "Number 3";
            this.dcolNumber3.Name = "dcolNumber3";
            this.dcolNumber3.Width = 80;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(162, 265);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(208, 36);
            this.guna2Button1.TabIndex = 62;
            this.guna2Button1.Text = "Generate Raffle Reference Number";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtRafflePrice
            // 
            this.txtRafflePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRafflePrice.DefaultText = "";
            this.txtRafflePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRafflePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRafflePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRafflePrice.DisabledState.Parent = this.txtRafflePrice;
            this.txtRafflePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRafflePrice.Enabled = false;
            this.txtRafflePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRafflePrice.FocusedState.Parent = this.txtRafflePrice;
            this.txtRafflePrice.ForeColor = System.Drawing.Color.Black;
            this.txtRafflePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRafflePrice.HoverState.Parent = this.txtRafflePrice;
            this.txtRafflePrice.Location = new System.Drawing.Point(376, 78);
            this.txtRafflePrice.Name = "txtRafflePrice";
            this.txtRafflePrice.PasswordChar = '\0';
            this.txtRafflePrice.PlaceholderText = "";
            this.txtRafflePrice.SelectedText = "";
            this.txtRafflePrice.ShadowDecoration.Parent = this.txtRafflePrice;
            this.txtRafflePrice.Size = new System.Drawing.Size(174, 36);
            this.txtRafflePrice.TabIndex = 63;
            this.txtRafflePrice.TextChanged += new System.EventHandler(this.txtRafflePrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(373, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Entry Price";
            // 
            // txtRaffleDrawDate
            // 
            this.txtRaffleDrawDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRaffleDrawDate.DefaultText = "";
            this.txtRaffleDrawDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRaffleDrawDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRaffleDrawDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaffleDrawDate.DisabledState.Parent = this.txtRaffleDrawDate;
            this.txtRaffleDrawDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRaffleDrawDate.Enabled = false;
            this.txtRaffleDrawDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaffleDrawDate.FocusedState.Parent = this.txtRaffleDrawDate;
            this.txtRaffleDrawDate.ForeColor = System.Drawing.Color.Black;
            this.txtRaffleDrawDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRaffleDrawDate.HoverState.Parent = this.txtRaffleDrawDate;
            this.txtRaffleDrawDate.Location = new System.Drawing.Point(556, 78);
            this.txtRaffleDrawDate.Name = "txtRaffleDrawDate";
            this.txtRaffleDrawDate.PasswordChar = '\0';
            this.txtRaffleDrawDate.PlaceholderText = "";
            this.txtRaffleDrawDate.SelectedText = "";
            this.txtRaffleDrawDate.ShadowDecoration.Parent = this.txtRaffleDrawDate;
            this.txtRaffleDrawDate.Size = new System.Drawing.Size(174, 36);
            this.txtRaffleDrawDate.TabIndex = 65;
            this.txtRaffleDrawDate.TextChanged += new System.EventHandler(this.txtRaffleDrawDate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(553, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 66;
            this.label8.Text = "Raffle Draw Date";
            // 
            // frmParticipantEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 383);
            this.Controls.Add(this.txtRaffleDrawDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRafflePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.dgvwRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.nudRaffleEntriesCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxRaffleEntries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxPaymentMethod);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPaymentReferenceNumber);
            this.Controls.Add(this.pnlHeader);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmParticipantEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventoryDetail_Load);
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRaffleEntriesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtPaymentReferenceNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtPaidAmount;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cboxPaymentMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cboxRaffleEntries;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudRaffleEntriesCount;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvwRecords;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtRaffleDrawDate;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtRafflePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolParticipantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolPaymentReferenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolModeOfPaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolModeOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolRaffleReferenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolRaffleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolNumber1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolNumber2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolNumber3;
    }
}