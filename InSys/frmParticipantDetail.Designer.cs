namespace InSys
{
    partial class frmParticipantDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticipantDetail));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMiddleName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFacebookLink = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpListOfPrizes = new System.Windows.Forms.TabPage();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvwRecords = new System.Windows.Forms.DataGridView();
            this.dcolRaffleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolPaymentReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolRaffleReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolTransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolModeOfPaymentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolModeOfPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolRaffleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmailAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlSaveCancel = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpListOfPrizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).BeginInit();
            this.pnlSaveCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.guna2Chip1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(1148, 45);
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
            this.btnCancel.Location = new System.Drawing.Point(82, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(70, 36);
            this.btnCancel.TabIndex = 6;
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
            this.btnSave.Location = new System.Drawing.Point(6, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(70, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(27, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Participant Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(503, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Last Name";
            this.label6.Visible = false;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.Parent = this.txtFirstName;
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedState.Parent = this.txtFirstName;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.HoverState.Parent = this.txtFirstName;
            this.txtFirstName.Location = new System.Drawing.Point(30, 76);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "Enter Participant Name Here...";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(367, 36);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.Parent = this.txtLastName;
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedState.Parent = this.txtLastName;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.HoverState.Parent = this.txtLastName;
            this.txtLastName.Location = new System.Drawing.Point(508, 168);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Enter Last Name Here...";
            this.txtLastName.SelectedText = "";
            this.txtLastName.ShadowDecoration.Parent = this.txtLastName;
            this.txtLastName.Size = new System.Drawing.Size(178, 36);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Visible = false;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMiddleName.DefaultText = "";
            this.txtMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.DisabledState.Parent = this.txtMiddleName;
            this.txtMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiddleName.FocusedState.Parent = this.txtMiddleName;
            this.txtMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMiddleName.HoverState.Parent = this.txtMiddleName;
            this.txtMiddleName.Location = new System.Drawing.Point(330, 168);
            this.txtMiddleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.PasswordChar = '\0';
            this.txtMiddleName.PlaceholderText = "Enter Middle Name Here...";
            this.txtMiddleName.SelectedText = "";
            this.txtMiddleName.ShadowDecoration.Parent = this.txtMiddleName;
            this.txtMiddleName.Size = new System.Drawing.Size(170, 36);
            this.txtMiddleName.TabIndex = 3;
            this.txtMiddleName.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(327, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Middle Name";
            this.label7.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(619, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Facebook Link";
            // 
            // txtFacebookLink
            // 
            this.txtFacebookLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFacebookLink.DefaultText = "";
            this.txtFacebookLink.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFacebookLink.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFacebookLink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFacebookLink.DisabledState.Parent = this.txtFacebookLink;
            this.txtFacebookLink.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFacebookLink.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFacebookLink.FocusedState.Parent = this.txtFacebookLink;
            this.txtFacebookLink.ForeColor = System.Drawing.Color.Black;
            this.txtFacebookLink.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFacebookLink.HoverState.Parent = this.txtFacebookLink;
            this.txtFacebookLink.Location = new System.Drawing.Point(622, 76);
            this.txtFacebookLink.Margin = new System.Windows.Forms.Padding(4);
            this.txtFacebookLink.Name = "txtFacebookLink";
            this.txtFacebookLink.PasswordChar = '\0';
            this.txtFacebookLink.PlaceholderText = "Enter Facebook Link Here...";
            this.txtFacebookLink.SelectedText = "";
            this.txtFacebookLink.ShadowDecoration.Parent = this.txtFacebookLink;
            this.txtFacebookLink.Size = new System.Drawing.Size(210, 36);
            this.txtFacebookLink.TabIndex = 3;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContactNumber.DefaultText = "";
            this.txtContactNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContactNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContactNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNumber.DisabledState.Parent = this.txtContactNumber;
            this.txtContactNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContactNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNumber.FocusedState.Parent = this.txtContactNumber;
            this.txtContactNumber.ForeColor = System.Drawing.Color.Black;
            this.txtContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNumber.HoverState.Parent = this.txtContactNumber;
            this.txtContactNumber.Location = new System.Drawing.Point(405, 76);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.PlaceholderText = "Enter Contact Number Here...";
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.ShadowDecoration.Parent = this.txtContactNumber;
            this.txtContactNumber.Size = new System.Drawing.Size(209, 36);
            this.txtContactNumber.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(402, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Contact Number";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpListOfPrizes);
            this.tabControl1.Font = new System.Drawing.Font("Mada", 11.25F);
            this.tabControl1.Location = new System.Drawing.Point(20, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1118, 394);
            this.tabControl1.TabIndex = 49;
            // 
            // tpListOfPrizes
            // 
            this.tpListOfPrizes.Controls.Add(this.btnDelete);
            this.tpListOfPrizes.Controls.Add(this.btnAdd);
            this.tpListOfPrizes.Controls.Add(this.dgvwRecords);
            this.tpListOfPrizes.Font = new System.Drawing.Font("Mada", 9.75F);
            this.tpListOfPrizes.Location = new System.Drawing.Point(4, 26);
            this.tpListOfPrizes.Name = "tpListOfPrizes";
            this.tpListOfPrizes.Padding = new System.Windows.Forms.Padding(3);
            this.tpListOfPrizes.Size = new System.Drawing.Size(1110, 364);
            this.tpListOfPrizes.TabIndex = 0;
            this.tpListOfPrizes.Text = "Entries For Raffle";
            this.tpListOfPrizes.UseVisualStyleBackColor = true;
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
            this.btnDelete.Location = new System.Drawing.Point(83, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(70, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(70, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvwRecords
            // 
            this.dgvwRecords.AllowUserToAddRows = false;
            this.dgvwRecords.AllowUserToDeleteRows = false;
            this.dgvwRecords.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvwRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvwRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvwRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvwRecords.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvwRecords.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvwRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mada", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvwRecords.ColumnHeadersHeight = 50;
            this.dgvwRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvwRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcolRaffleName,
            this.dcolPaymentReferenceNumber,
            this.dcolRaffleReferenceNumber,
            this.dcolPaidAmount,
            this.dcolTransactionDate,
            this.dcolModeOfPaymentId,
            this.dcolModeOfPayment,
            this.dcolRaffleId,
            this.dcolID});
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(6, 48);
            this.dgvwRecords.Name = "dgvwRecords";
            this.dgvwRecords.ReadOnly = true;
            this.dgvwRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Mada", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvwRecords.RowHeadersVisible = false;
            this.dgvwRecords.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvwRecords.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvwRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwRecords.Size = new System.Drawing.Size(1100, 310);
            this.dgvwRecords.TabIndex = 10;
            this.dgvwRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwRecords_CellContentClick);
            // 
            // dcolRaffleName
            // 
            this.dcolRaffleName.DataPropertyName = "RaffleName";
            this.dcolRaffleName.HeaderText = "Raffle Entered";
            this.dcolRaffleName.MinimumWidth = 6;
            this.dcolRaffleName.Name = "dcolRaffleName";
            this.dcolRaffleName.ReadOnly = true;
            this.dcolRaffleName.Width = 250;
            // 
            // dcolPaymentReferenceNumber
            // 
            this.dcolPaymentReferenceNumber.DataPropertyName = "PaymentReceipt";
            this.dcolPaymentReferenceNumber.HeaderText = "Payment Reference No.";
            this.dcolPaymentReferenceNumber.MinimumWidth = 6;
            this.dcolPaymentReferenceNumber.Name = "dcolPaymentReferenceNumber";
            this.dcolPaymentReferenceNumber.ReadOnly = true;
            this.dcolPaymentReferenceNumber.Width = 250;
            // 
            // dcolRaffleReferenceNumber
            // 
            this.dcolRaffleReferenceNumber.DataPropertyName = "RaffleReferenceNumber";
            this.dcolRaffleReferenceNumber.HeaderText = "Raffle Reference No.";
            this.dcolRaffleReferenceNumber.MinimumWidth = 6;
            this.dcolRaffleReferenceNumber.Name = "dcolRaffleReferenceNumber";
            this.dcolRaffleReferenceNumber.ReadOnly = true;
            this.dcolRaffleReferenceNumber.Width = 200;
            // 
            // dcolPaidAmount
            // 
            this.dcolPaidAmount.DataPropertyName = "PaidAmount";
            this.dcolPaidAmount.HeaderText = "Paid Amount";
            this.dcolPaidAmount.MinimumWidth = 6;
            this.dcolPaidAmount.Name = "dcolPaidAmount";
            this.dcolPaidAmount.ReadOnly = true;
            this.dcolPaidAmount.Width = 125;
            // 
            // dcolTransactionDate
            // 
            this.dcolTransactionDate.DataPropertyName = "TransactionDateTime";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dcolTransactionDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.dcolTransactionDate.HeaderText = "Transaction Date";
            this.dcolTransactionDate.MinimumWidth = 6;
            this.dcolTransactionDate.Name = "dcolTransactionDate";
            this.dcolTransactionDate.ReadOnly = true;
            this.dcolTransactionDate.Width = 150;
            // 
            // dcolModeOfPaymentId
            // 
            this.dcolModeOfPaymentId.DataPropertyName = "PaymentMethod";
            this.dcolModeOfPaymentId.HeaderText = "Mode Of Payment Id";
            this.dcolModeOfPaymentId.MinimumWidth = 6;
            this.dcolModeOfPaymentId.Name = "dcolModeOfPaymentId";
            this.dcolModeOfPaymentId.ReadOnly = true;
            this.dcolModeOfPaymentId.Visible = false;
            this.dcolModeOfPaymentId.Width = 125;
            // 
            // dcolModeOfPayment
            // 
            this.dcolModeOfPayment.DataPropertyName = "PaymentMethodName";
            this.dcolModeOfPayment.HeaderText = "Payment Method";
            this.dcolModeOfPayment.MinimumWidth = 6;
            this.dcolModeOfPayment.Name = "dcolModeOfPayment";
            this.dcolModeOfPayment.ReadOnly = true;
            this.dcolModeOfPayment.Width = 125;
            // 
            // dcolRaffleId
            // 
            this.dcolRaffleId.DataPropertyName = "RaffleId";
            this.dcolRaffleId.HeaderText = "Raffle Id";
            this.dcolRaffleId.MinimumWidth = 6;
            this.dcolRaffleId.Name = "dcolRaffleId";
            this.dcolRaffleId.ReadOnly = true;
            this.dcolRaffleId.Visible = false;
            this.dcolRaffleId.Width = 160;
            // 
            // dcolID
            // 
            this.dcolID.DataPropertyName = "Id";
            this.dcolID.HeaderText = "ID";
            this.dcolID.MinimumWidth = 6;
            this.dcolID.Name = "dcolID";
            this.dcolID.ReadOnly = true;
            this.dcolID.Visible = false;
            this.dcolID.Width = 46;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.DefaultText = "";
            this.txtEmailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAddress.DisabledState.Parent = this.txtEmailAddress;
            this.txtEmailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAddress.FocusedState.Parent = this.txtEmailAddress;
            this.txtEmailAddress.ForeColor = System.Drawing.Color.Black;
            this.txtEmailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAddress.HoverState.Parent = this.txtEmailAddress;
            this.txtEmailAddress.Location = new System.Drawing.Point(840, 75);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.PasswordChar = '\0';
            this.txtEmailAddress.PlaceholderText = "Enter Email Address Here...";
            this.txtEmailAddress.SelectedText = "";
            this.txtEmailAddress.ShadowDecoration.Parent = this.txtEmailAddress;
            this.txtEmailAddress.Size = new System.Drawing.Size(230, 36);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(837, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Email Address";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pnlHeader;
            // 
            // pnlSaveCancel
            // 
            this.pnlSaveCancel.Controls.Add(this.btnCancel);
            this.pnlSaveCancel.Controls.Add(this.btnSave);
            this.pnlSaveCancel.Location = new System.Drawing.Point(918, 118);
            this.pnlSaveCancel.Name = "pnlSaveCancel";
            this.pnlSaveCancel.Size = new System.Drawing.Size(157, 38);
            this.pnlSaveCancel.TabIndex = 52;
            // 
            // frmParticipantDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 542);
            this.Controls.Add(this.pnlSaveCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFacebookLink);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMiddleName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmParticipantDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmParticipantDetail_Load);
            this.pnlHeader.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpListOfPrizes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.pnlSaveCancel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtMiddleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtFacebookLink;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpListOfPrizes;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.DataGridView dgvwRecords;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailAddress;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolRaffleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolPaymentReferenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolRaffleReferenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolPaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolTransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolModeOfPaymentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolModeOfPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolRaffleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolID;
        private System.Windows.Forms.Panel pnlSaveCancel;
    }
}