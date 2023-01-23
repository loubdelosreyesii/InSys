namespace InSys
{
    partial class frmRaffle
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.dgvwRecords = new System.Windows.Forms.DataGridView();
            this.dcolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolDrawDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolEntryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolMaxEntries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnManagePrizes = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnManageParticipant = new Guna.UI2.WinForms.Guna2Button();
            this.txtTotalPrizeAlloted = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txTotalEntryAmountCollected = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1022, 45);
            this.guna2Panel1.TabIndex = 25;
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
            this.guna2Chip1.Text = "Raffle Management";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            this.dcolName,
            this.dcolDescription,
            this.dcolDrawDate,
            this.dcolEntryPrice,
            this.dcolMaxEntries});
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(0, 112);
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
            this.dgvwRecords.Size = new System.Drawing.Size(1022, 604);
            this.dgvwRecords.TabIndex = 29;
            this.dgvwRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwRecords_CellClick);
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
            // dcolName
            // 
            this.dcolName.DataPropertyName = "Name";
            this.dcolName.HeaderText = "Name";
            this.dcolName.Name = "dcolName";
            this.dcolName.ReadOnly = true;
            this.dcolName.Width = 200;
            // 
            // dcolDescription
            // 
            this.dcolDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolDescription.DataPropertyName = "Description";
            this.dcolDescription.HeaderText = "Description";
            this.dcolDescription.Name = "dcolDescription";
            this.dcolDescription.ReadOnly = true;
            // 
            // dcolDrawDate
            // 
            this.dcolDrawDate.DataPropertyName = "DrawDate";
            this.dcolDrawDate.HeaderText = "Draw Date";
            this.dcolDrawDate.Name = "dcolDrawDate";
            this.dcolDrawDate.ReadOnly = true;
            this.dcolDrawDate.Width = 170;
            // 
            // dcolEntryPrice
            // 
            this.dcolEntryPrice.DataPropertyName = "EntryPrice";
            this.dcolEntryPrice.HeaderText = "Entry Price";
            this.dcolEntryPrice.Name = "dcolEntryPrice";
            this.dcolEntryPrice.ReadOnly = true;
            this.dcolEntryPrice.Width = 167;
            // 
            // dcolMaxEntries
            // 
            this.dcolMaxEntries.DataPropertyName = "MaxEntries";
            this.dcolMaxEntries.HeaderText = "Max Entries";
            this.dcolMaxEntries.Name = "dcolMaxEntries";
            this.dcolMaxEntries.ReadOnly = true;
            this.dcolMaxEntries.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(12, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(70, 26);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(84, 80);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(70, 26);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(156, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(70, 26);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnManagePrizes
            // 
            this.btnManagePrizes.BackColor = System.Drawing.Color.Transparent;
            this.btnManagePrizes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnManagePrizes.BorderRadius = 5;
            this.btnManagePrizes.BorderThickness = 1;
            this.btnManagePrizes.CheckedState.Parent = this.btnManagePrizes;
            this.btnManagePrizes.CustomImages.Parent = this.btnManagePrizes;
            this.btnManagePrizes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnManagePrizes.Font = new System.Drawing.Font("Mada", 9.75F);
            this.btnManagePrizes.ForeColor = System.Drawing.Color.White;
            this.btnManagePrizes.HoverState.Parent = this.btnManagePrizes;
            this.btnManagePrizes.Location = new System.Drawing.Point(228, 80);
            this.btnManagePrizes.Name = "btnManagePrizes";
            this.btnManagePrizes.ShadowDecoration.Parent = this.btnManagePrizes;
            this.btnManagePrizes.Size = new System.Drawing.Size(169, 26);
            this.btnManagePrizes.TabIndex = 35;
            this.btnManagePrizes.Text = "Manage Prizes";
            this.btnManagePrizes.Click += new System.EventHandler(this.btnManagePrizes_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // btnManageParticipant
            // 
            this.btnManageParticipant.BackColor = System.Drawing.Color.Transparent;
            this.btnManageParticipant.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnManageParticipant.BorderRadius = 5;
            this.btnManageParticipant.BorderThickness = 1;
            this.btnManageParticipant.CheckedState.Parent = this.btnManageParticipant;
            this.btnManageParticipant.CustomImages.Parent = this.btnManageParticipant;
            this.btnManageParticipant.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnManageParticipant.Font = new System.Drawing.Font("Mada", 9.75F);
            this.btnManageParticipant.ForeColor = System.Drawing.Color.White;
            this.btnManageParticipant.HoverState.Parent = this.btnManageParticipant;
            this.btnManageParticipant.Location = new System.Drawing.Point(399, 80);
            this.btnManageParticipant.Name = "btnManageParticipant";
            this.btnManageParticipant.ShadowDecoration.Parent = this.btnManageParticipant;
            this.btnManageParticipant.Size = new System.Drawing.Size(169, 26);
            this.btnManageParticipant.TabIndex = 36;
            this.btnManageParticipant.Text = "Manage Participants";
            this.btnManageParticipant.Click += new System.EventHandler(this.btnManageParticipant_Click);
            // 
            // txtTotalPrizeAlloted
            // 
            this.txtTotalPrizeAlloted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrizeAlloted.DefaultText = "";
            this.txtTotalPrizeAlloted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrizeAlloted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrizeAlloted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrizeAlloted.DisabledState.Parent = this.txtTotalPrizeAlloted;
            this.txtTotalPrizeAlloted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrizeAlloted.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrizeAlloted.FocusedState.Parent = this.txtTotalPrizeAlloted;
            this.txtTotalPrizeAlloted.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrizeAlloted.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrizeAlloted.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotalPrizeAlloted.HoverState.Parent = this.txtTotalPrizeAlloted;
            this.txtTotalPrizeAlloted.Location = new System.Drawing.Point(760, 73);
            this.txtTotalPrizeAlloted.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalPrizeAlloted.Name = "txtTotalPrizeAlloted";
            this.txtTotalPrizeAlloted.PasswordChar = '\0';
            this.txtTotalPrizeAlloted.PlaceholderText = "";
            this.txtTotalPrizeAlloted.SelectedText = "";
            this.txtTotalPrizeAlloted.ShadowDecoration.Parent = this.txtTotalPrizeAlloted;
            this.txtTotalPrizeAlloted.Size = new System.Drawing.Size(176, 36);
            this.txtTotalPrizeAlloted.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(758, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Total Prize Alloted";
            // 
            // txTotalEntryAmountCollected
            // 
            this.txTotalEntryAmountCollected.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txTotalEntryAmountCollected.DefaultText = "";
            this.txTotalEntryAmountCollected.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txTotalEntryAmountCollected.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txTotalEntryAmountCollected.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txTotalEntryAmountCollected.DisabledState.Parent = this.txTotalEntryAmountCollected;
            this.txTotalEntryAmountCollected.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txTotalEntryAmountCollected.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTotalEntryAmountCollected.FocusedState.Parent = this.txTotalEntryAmountCollected;
            this.txTotalEntryAmountCollected.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotalEntryAmountCollected.ForeColor = System.Drawing.Color.Black;
            this.txTotalEntryAmountCollected.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txTotalEntryAmountCollected.HoverState.Parent = this.txTotalEntryAmountCollected;
            this.txTotalEntryAmountCollected.Location = new System.Drawing.Point(575, 73);
            this.txTotalEntryAmountCollected.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txTotalEntryAmountCollected.Name = "txTotalEntryAmountCollected";
            this.txTotalEntryAmountCollected.PasswordChar = '\0';
            this.txTotalEntryAmountCollected.PlaceholderText = "";
            this.txTotalEntryAmountCollected.SelectedText = "";
            this.txTotalEntryAmountCollected.ShadowDecoration.Parent = this.txTotalEntryAmountCollected;
            this.txTotalEntryAmountCollected.Size = new System.Drawing.Size(176, 36);
            this.txTotalEntryAmountCollected.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(572, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Total Entry Amount Collected";
            // 
            // frmRaffle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 717);
            this.Controls.Add(this.txTotalEntryAmountCollected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPrizeAlloted);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnManageParticipant);
            this.Controls.Add(this.btnManagePrizes);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvwRecords);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRaffle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRaffle_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private System.Windows.Forms.DataGridView dgvwRecords;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnManagePrizes;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnManageParticipant;
        private Guna.UI2.WinForms.Guna2TextBox txTotalEntryAmountCollected;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrizeAlloted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolDrawDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolEntryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolMaxEntries;
    }
}