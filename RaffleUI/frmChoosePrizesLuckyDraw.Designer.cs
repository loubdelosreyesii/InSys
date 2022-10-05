namespace RaffleUI
{
    partial class frmChoosePrizesLuckyDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoosePrizesLuckyDraw));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpListOfPrizes = new System.Windows.Forms.TabPage();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnChooseToRaffle = new Guna.UI2.WinForms.Guna2Button();
            this.dgvwRecords = new System.Windows.Forms.DataGridView();
            this.dcolProductPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.dcolID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolPrizeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolPrizeAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolPrizeProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.tabControl1.SuspendLayout();
            this.tpListOfPrizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpListOfPrizes);
            this.tabControl1.Font = new System.Drawing.Font("Mada", 11.25F);
            this.tabControl1.Location = new System.Drawing.Point(12, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 309);
            this.tabControl1.TabIndex = 49;
            // 
            // tpListOfPrizes
            // 
            this.tpListOfPrizes.Controls.Add(this.btnCancel);
            this.tpListOfPrizes.Controls.Add(this.btnChooseToRaffle);
            this.tpListOfPrizes.Controls.Add(this.dgvwRecords);
            this.tpListOfPrizes.Font = new System.Drawing.Font("Mada", 9.75F);
            this.tpListOfPrizes.Location = new System.Drawing.Point(4, 26);
            this.tpListOfPrizes.Name = "tpListOfPrizes";
            this.tpListOfPrizes.Padding = new System.Windows.Forms.Padding(3);
            this.tpListOfPrizes.Size = new System.Drawing.Size(662, 279);
            this.tpListOfPrizes.TabIndex = 0;
            this.tpListOfPrizes.Text = "List Of Prizes";
            this.tpListOfPrizes.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(533, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(70, 36);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChooseToRaffle
            // 
            this.btnChooseToRaffle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChooseToRaffle.BorderRadius = 5;
            this.btnChooseToRaffle.BorderThickness = 1;
            this.btnChooseToRaffle.CheckedState.Parent = this.btnChooseToRaffle;
            this.btnChooseToRaffle.CustomImages.Parent = this.btnChooseToRaffle;
            this.btnChooseToRaffle.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnChooseToRaffle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChooseToRaffle.ForeColor = System.Drawing.Color.White;
            this.btnChooseToRaffle.HoverState.Parent = this.btnChooseToRaffle;
            this.btnChooseToRaffle.Location = new System.Drawing.Point(373, 3);
            this.btnChooseToRaffle.Name = "btnChooseToRaffle";
            this.btnChooseToRaffle.ShadowDecoration.Parent = this.btnChooseToRaffle;
            this.btnChooseToRaffle.Size = new System.Drawing.Size(154, 36);
            this.btnChooseToRaffle.TabIndex = 50;
            this.btnChooseToRaffle.Text = "Choose Product for Raffle";
            this.btnChooseToRaffle.Click += new System.EventHandler(this.btnChooseToRaffle_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mada", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvwRecords.ColumnHeadersHeight = 50;
            this.dgvwRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvwRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcolProductPhoto,
            this.dcolID,
            this.dcolName,
            this.dcolDescription,
            this.dcolPrizeName,
            this.dcolProductId,
            this.dcolPrizeAmount,
            this.dcolPrizeProductQuantity});
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(6, 48);
            this.dgvwRecords.Name = "dgvwRecords";
            this.dgvwRecords.ReadOnly = true;
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
            this.dgvwRecords.RowTemplate.Height = 60;
            this.dgvwRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwRecords.Size = new System.Drawing.Size(650, 212);
            this.dgvwRecords.TabIndex = 30;
            this.dgvwRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwRecords_CellContentClick);
            // 
            // dcolProductPhoto
            // 
            this.dcolProductPhoto.DataPropertyName = "ProductPhoto";
            this.dcolProductPhoto.HeaderText = "";
            this.dcolProductPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dcolProductPhoto.Name = "dcolProductPhoto";
            this.dcolProductPhoto.ReadOnly = true;
            this.dcolProductPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dcolProductPhoto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dcolID
            // 
            this.dcolID.DataPropertyName = "Id";
            this.dcolID.HeaderText = "ID";
            this.dcolID.Name = "dcolID";
            this.dcolID.ReadOnly = true;
            this.dcolID.Visible = false;
            this.dcolID.Width = 46;
            // 
            // dcolName
            // 
            this.dcolName.DataPropertyName = "Name";
            this.dcolName.HeaderText = "Name";
            this.dcolName.Name = "dcolName";
            this.dcolName.ReadOnly = true;
            this.dcolName.Visible = false;
            this.dcolName.Width = 150;
            // 
            // dcolDescription
            // 
            this.dcolDescription.DataPropertyName = "Description";
            this.dcolDescription.HeaderText = "Description";
            this.dcolDescription.Name = "dcolDescription";
            this.dcolDescription.ReadOnly = true;
            this.dcolDescription.Visible = false;
            this.dcolDescription.Width = 200;
            // 
            // dcolPrizeName
            // 
            this.dcolPrizeName.DataPropertyName = "ProductName";
            this.dcolPrizeName.HeaderText = "Prize Name";
            this.dcolPrizeName.Name = "dcolPrizeName";
            this.dcolPrizeName.ReadOnly = true;
            this.dcolPrizeName.Width = 250;
            // 
            // dcolProductId
            // 
            this.dcolProductId.DataPropertyName = "ProductId";
            this.dcolProductId.HeaderText = "Product Id";
            this.dcolProductId.Name = "dcolProductId";
            this.dcolProductId.ReadOnly = true;
            this.dcolProductId.Visible = false;
            // 
            // dcolPrizeAmount
            // 
            this.dcolPrizeAmount.DataPropertyName = "SuggestedRetailPrice";
            this.dcolPrizeAmount.HeaderText = "Prize Amount";
            this.dcolPrizeAmount.Name = "dcolPrizeAmount";
            this.dcolPrizeAmount.ReadOnly = true;
            this.dcolPrizeAmount.Width = 150;
            // 
            // dcolPrizeProductQuantity
            // 
            this.dcolPrizeProductQuantity.DataPropertyName = "Quantity";
            this.dcolPrizeProductQuantity.HeaderText = "Product Quantity";
            this.dcolPrizeProductQuantity.Name = "dcolPrizeProductQuantity";
            this.dcolPrizeProductQuantity.ReadOnly = true;
            this.dcolPrizeProductQuantity.Width = 150;
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
            this.guna2Panel1.Size = new System.Drawing.Size(694, 31);
            this.guna2Panel1.TabIndex = 50;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(12, 3);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(216, 23);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "Choose a Prize to Lucky Draw";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // frmChoosePrizesLuckyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 358);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChoosePrizesLuckyDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tpListOfPrizes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpListOfPrizes;
        private System.Windows.Forms.DataGridView dgvwRecords;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnChooseToRaffle;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private System.Windows.Forms.DataGridViewImageColumn dcolProductPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolPrizeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolPrizeAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolPrizeProductQuantity;
    }
}