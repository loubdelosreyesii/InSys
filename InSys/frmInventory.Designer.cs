using System.Windows.Forms;

namespace InSys
{
    partial class frmInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventory));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dgvwRecords = new System.Windows.Forms.DataGridView();
            this.dcolProductPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.dcolProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolBrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolDistributorPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolSuggestedRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolDealerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcolDealerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeywordSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.pnlFrame = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.pnlFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.guna2Chip1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1079, 45);
            this.guna2Panel1.TabIndex = 12;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.FillColor = System.Drawing.Color.White;
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Chip1.Location = new System.Drawing.Point(12, 12);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(247, 23);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "Product Inventory Management";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(1003, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(70, 27);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(927, 142);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(70, 27);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(851, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(70, 27);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvwRecords
            // 
            this.dgvwRecords.AllowUserToAddRows = false;
            this.dgvwRecords.AllowUserToDeleteRows = false;
            this.dgvwRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvwRecords.ColumnHeadersHeight = 50;
            this.dgvwRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvwRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcolProductPhoto,
            this.dcolProductId,
            this.dcolTypeID,
            this.dcolTypeName,
            this.dcolBrandID,
            this.dcolBrandName,
            this.dcolModel,
            this.dcolDistributorPrice,
            this.dcolSuggestedRetailPrice,
            this.dcolQuantity,
            this.dcolDealerID,
            this.dcolDealerName});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvwRecords.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(0, 175);
            this.dgvwRecords.Name = "dgvwRecords";
            this.dgvwRecords.ReadOnly = true;
            this.dgvwRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvwRecords.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvwRecords.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvwRecords.RowTemplate.Height = 30;
            this.dgvwRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwRecords.Size = new System.Drawing.Size(1073, 513);
            this.dgvwRecords.TabIndex = 24;
            // 
            // dcolProductPhoto
            // 
            this.dcolProductPhoto.DataPropertyName = "ProductPhoto";
            this.dcolProductPhoto.HeaderText = "";
            this.dcolProductPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dcolProductPhoto.Name = "dcolProductPhoto";
            this.dcolProductPhoto.ReadOnly = true;
            // 
            // dcolProductId
            // 
            this.dcolProductId.DataPropertyName = "ID";
            this.dcolProductId.HeaderText = "ID";
            this.dcolProductId.Name = "dcolProductId";
            this.dcolProductId.ReadOnly = true;
            this.dcolProductId.Visible = false;
            this.dcolProductId.Width = 70;
            // 
            // dcolTypeID
            // 
            this.dcolTypeID.DataPropertyName = "TypeID";
            this.dcolTypeID.HeaderText = "Type ID";
            this.dcolTypeID.Name = "dcolTypeID";
            this.dcolTypeID.ReadOnly = true;
            this.dcolTypeID.Visible = false;
            // 
            // dcolTypeName
            // 
            this.dcolTypeName.DataPropertyName = "TypeName";
            this.dcolTypeName.HeaderText = "TYPE";
            this.dcolTypeName.Name = "dcolTypeName";
            this.dcolTypeName.ReadOnly = true;
            this.dcolTypeName.Width = 180;
            // 
            // dcolBrandID
            // 
            this.dcolBrandID.DataPropertyName = "BrandID";
            this.dcolBrandID.HeaderText = "Brand ID";
            this.dcolBrandID.Name = "dcolBrandID";
            this.dcolBrandID.ReadOnly = true;
            this.dcolBrandID.Visible = false;
            // 
            // dcolBrandName
            // 
            this.dcolBrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolBrandName.DataPropertyName = "BrandName";
            this.dcolBrandName.HeaderText = "BRAND";
            this.dcolBrandName.Name = "dcolBrandName";
            this.dcolBrandName.ReadOnly = true;
            // 
            // dcolModel
            // 
            this.dcolModel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolModel.DataPropertyName = "Model";
            this.dcolModel.HeaderText = "MODEL";
            this.dcolModel.Name = "dcolModel";
            this.dcolModel.ReadOnly = true;
            // 
            // dcolDistributorPrice
            // 
            this.dcolDistributorPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolDistributorPrice.DataPropertyName = "DistributorPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dcolDistributorPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dcolDistributorPrice.HeaderText = "SELLING PRICE";
            this.dcolDistributorPrice.Name = "dcolDistributorPrice";
            this.dcolDistributorPrice.ReadOnly = true;
            this.dcolDistributorPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dcolSuggestedRetailPrice
            // 
            this.dcolSuggestedRetailPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolSuggestedRetailPrice.DataPropertyName = "SuggestedRetailPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dcolSuggestedRetailPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.dcolSuggestedRetailPrice.HeaderText = "SRP";
            this.dcolSuggestedRetailPrice.Name = "dcolSuggestedRetailPrice";
            this.dcolSuggestedRetailPrice.ReadOnly = true;
            // 
            // dcolQuantity
            // 
            this.dcolQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dcolQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.dcolQuantity.HeaderText = "QUANTITY";
            this.dcolQuantity.Name = "dcolQuantity";
            this.dcolQuantity.ReadOnly = true;
            // 
            // dcolDealerID
            // 
            this.dcolDealerID.DataPropertyName = "DealerID";
            this.dcolDealerID.HeaderText = "Dealer ID";
            this.dcolDealerID.Name = "dcolDealerID";
            this.dcolDealerID.ReadOnly = true;
            this.dcolDealerID.Visible = false;
            // 
            // dcolDealerName
            // 
            this.dcolDealerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dcolDealerName.DataPropertyName = "DealerName";
            this.dcolDealerName.HeaderText = "SUPPLIER";
            this.dcolDealerName.Name = "dcolDealerName";
            this.dcolDealerName.ReadOnly = true;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(728, 81);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(82, 45);
            this.guna2Button1.TabIndex = 34;
            this.guna2Button1.Tag = "8";
            this.guna2Button1.Text = "Pips-Out";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(816, 81);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(82, 45);
            this.guna2Button2.TabIndex = 33;
            this.guna2Button2.Tag = "9";
            this.guna2Button2.Text = "Rubbers";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(464, 81);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(82, 45);
            this.guna2Button3.TabIndex = 32;
            this.guna2Button3.Tag = "5";
            this.guna2Button3.Text = "Blades";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(376, 81);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(82, 45);
            this.guna2Button4.TabIndex = 35;
            this.guna2Button4.Tag = "4";
            this.guna2Button4.Text = "Balls";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button5.BorderRadius = 5;
            this.guna2Button5.BorderThickness = 1;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.White;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(640, 81);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(82, 45);
            this.guna2Button5.TabIndex = 36;
            this.guna2Button5.Tag = "7";
            this.guna2Button5.Text = "Hobby Bat";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button6.BorderRadius = 5;
            this.guna2Button6.BorderThickness = 1;
            this.guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.FillColor = System.Drawing.Color.White;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Location = new System.Drawing.Point(552, 81);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(82, 45);
            this.guna2Button6.TabIndex = 37;
            this.guna2Button6.Tag = "6";
            this.guna2Button6.Text = "Glue";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button7
            // 
            this.guna2Button7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button7.BorderRadius = 5;
            this.guna2Button7.BorderThickness = 1;
            this.guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button7.CheckedState.Parent = this.guna2Button7;
            this.guna2Button7.CustomImages.Parent = this.guna2Button7;
            this.guna2Button7.FillColor = System.Drawing.Color.White;
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button7.HoverState.Parent = this.guna2Button7;
            this.guna2Button7.Location = new System.Drawing.Point(904, 81);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.ShadowDecoration.Parent = this.guna2Button7;
            this.guna2Button7.Size = new System.Drawing.Size(82, 45);
            this.guna2Button7.TabIndex = 38;
            this.guna2Button7.Tag = "10";
            this.guna2Button7.Text = "Shoes";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button8.BorderRadius = 5;
            this.guna2Button8.BorderThickness = 1;
            this.guna2Button8.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button8.CheckedState.Parent = this.guna2Button8;
            this.guna2Button8.CustomImages.Parent = this.guna2Button8;
            this.guna2Button8.FillColor = System.Drawing.Color.White;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button8.HoverState.Parent = this.guna2Button8;
            this.guna2Button8.Location = new System.Drawing.Point(288, 81);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.ShadowDecoration.Parent = this.guna2Button8;
            this.guna2Button8.Size = new System.Drawing.Size(82, 45);
            this.guna2Button8.TabIndex = 39;
            this.guna2Button8.Tag = "3";
            this.guna2Button8.Text = "Bags";
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // guna2Button9
            // 
            this.guna2Button9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button9.BorderRadius = 5;
            this.guna2Button9.BorderThickness = 1;
            this.guna2Button9.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button9.CheckedState.Parent = this.guna2Button9;
            this.guna2Button9.CustomImages.Parent = this.guna2Button9;
            this.guna2Button9.FillColor = System.Drawing.Color.White;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button9.HoverState.Parent = this.guna2Button9;
            this.guna2Button9.Location = new System.Drawing.Point(200, 81);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.ShadowDecoration.Parent = this.guna2Button9;
            this.guna2Button9.Size = new System.Drawing.Size(82, 45);
            this.guna2Button9.TabIndex = 40;
            this.guna2Button9.Tag = "2";
            this.guna2Button9.Text = "Apparel";
            this.guna2Button9.Click += new System.EventHandler(this.guna2Button9_Click);
            // 
            // guna2Button10
            // 
            this.guna2Button10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button10.BorderRadius = 5;
            this.guna2Button10.BorderThickness = 1;
            this.guna2Button10.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button10.CheckedState.Parent = this.guna2Button10;
            this.guna2Button10.CustomImages.Parent = this.guna2Button10;
            this.guna2Button10.FillColor = System.Drawing.Color.White;
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button10.HoverState.Parent = this.guna2Button10;
            this.guna2Button10.Location = new System.Drawing.Point(108, 82);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.ShadowDecoration.Parent = this.guna2Button10;
            this.guna2Button10.Size = new System.Drawing.Size(86, 45);
            this.guna2Button10.TabIndex = 41;
            this.guna2Button10.Tag = "1";
            this.guna2Button10.Text = "Accessories";
            this.guna2Button10.Click += new System.EventHandler(this.guna2Button10_Click);
            // 
            // guna2Button11
            // 
            this.guna2Button11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button11.BorderRadius = 5;
            this.guna2Button11.BorderThickness = 1;
            this.guna2Button11.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button11.CheckedState.Parent = this.guna2Button11;
            this.guna2Button11.CustomImages.Parent = this.guna2Button11;
            this.guna2Button11.FillColor = System.Drawing.Color.White;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button11.HoverState.Parent = this.guna2Button11;
            this.guna2Button11.Location = new System.Drawing.Point(991, 81);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.ShadowDecoration.Parent = this.guna2Button11;
            this.guna2Button11.Size = new System.Drawing.Size(82, 45);
            this.guna2Button11.TabIndex = 42;
            this.guna2Button11.Tag = "-1";
            this.guna2Button11.Text = "Others";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Location = new System.Drawing.Point(2, 45);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1077, 32);
            this.guna2Panel2.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Quick Filter By Product Types";
            // 
            // txtKeywordSearch
            // 
            this.txtKeywordSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKeywordSearch.DefaultText = "";
            this.txtKeywordSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKeywordSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKeywordSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKeywordSearch.DisabledState.Parent = this.txtKeywordSearch;
            this.txtKeywordSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKeywordSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeywordSearch.FocusedState.Parent = this.txtKeywordSearch;
            this.txtKeywordSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKeywordSearch.HoverState.Parent = this.txtKeywordSearch;
            this.txtKeywordSearch.Location = new System.Drawing.Point(19, 142);
            this.txtKeywordSearch.Name = "txtKeywordSearch";
            this.txtKeywordSearch.PasswordChar = '\0';
            this.txtKeywordSearch.PlaceholderText = "Type text to search...";
            this.txtKeywordSearch.SelectedText = "";
            this.txtKeywordSearch.ShadowDecoration.Parent = this.txtKeywordSearch;
            this.txtKeywordSearch.Size = new System.Drawing.Size(266, 27);
            this.txtKeywordSearch.TabIndex = 46;
            // 
            // guna2Button12
            // 
            this.guna2Button12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button12.BorderRadius = 5;
            this.guna2Button12.BorderThickness = 1;
            this.guna2Button12.CheckedState.Parent = this.guna2Button12;
            this.guna2Button12.CustomImages.Parent = this.guna2Button12;
            this.guna2Button12.FillColor = System.Drawing.Color.White;
            this.guna2Button12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button12.HoverState.Parent = this.guna2Button12;
            this.guna2Button12.Location = new System.Drawing.Point(291, 142);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.ShadowDecoration.Parent = this.guna2Button12;
            this.guna2Button12.Size = new System.Drawing.Size(70, 27);
            this.guna2Button12.TabIndex = 47;
            this.guna2Button12.Text = "Search";
            this.guna2Button12.Click += new System.EventHandler(this.guna2Button12_Click);
            // 
            // guna2Button13
            // 
            this.guna2Button13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button13.BorderRadius = 5;
            this.guna2Button13.BorderThickness = 1;
            this.guna2Button13.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button13.CheckedState.Parent = this.guna2Button13;
            this.guna2Button13.CustomImages.Parent = this.guna2Button13;
            this.guna2Button13.FillColor = System.Drawing.Color.White;
            this.guna2Button13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button13.HoverState.Parent = this.guna2Button13;
            this.guna2Button13.Location = new System.Drawing.Point(19, 82);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.ShadowDecoration.Parent = this.guna2Button13;
            this.guna2Button13.Size = new System.Drawing.Size(83, 45);
            this.guna2Button13.TabIndex = 48;
            this.guna2Button13.Tag = "0";
            this.guna2Button13.Text = "All";
            this.guna2Button13.Click += new System.EventHandler(this.guna2Button13_Click);
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLinePanel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gunaLinePanel1.LineBottom = 100;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Silver;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 100;
            this.gunaLinePanel1.Location = new System.Drawing.Point(2, 134);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(1077, 1);
            this.gunaLinePanel1.TabIndex = 49;
            // 
            // pnlFrame
            // 
            this.pnlFrame.Controls.Add(this.guna2Button13);
            this.pnlFrame.Controls.Add(this.dgvwRecords);
            this.pnlFrame.Controls.Add(this.guna2Button12);
            this.pnlFrame.Controls.Add(this.gunaLinePanel1);
            this.pnlFrame.Controls.Add(this.guna2Panel1);
            this.pnlFrame.Controls.Add(this.btnAdd);
            this.pnlFrame.Controls.Add(this.txtKeywordSearch);
            this.pnlFrame.Controls.Add(this.btnEdit);
            this.pnlFrame.Controls.Add(this.guna2Panel2);
            this.pnlFrame.Controls.Add(this.btnDelete);
            this.pnlFrame.Controls.Add(this.guna2Button11);
            this.pnlFrame.Controls.Add(this.guna2Button3);
            this.pnlFrame.Controls.Add(this.guna2Button10);
            this.pnlFrame.Controls.Add(this.guna2Button2);
            this.pnlFrame.Controls.Add(this.guna2Button9);
            this.pnlFrame.Controls.Add(this.guna2Button1);
            this.pnlFrame.Controls.Add(this.guna2Button8);
            this.pnlFrame.Controls.Add(this.guna2Button4);
            this.pnlFrame.Controls.Add(this.guna2Button7);
            this.pnlFrame.Controls.Add(this.guna2Button5);
            this.pnlFrame.Controls.Add(this.guna2Button6);
            this.pnlFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFrame.Location = new System.Drawing.Point(0, 0);
            this.pnlFrame.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFrame.Name = "pnlFrame";
            this.pnlFrame.Size = new System.Drawing.Size(1079, 691);
            this.pnlFrame.TabIndex = 50;
            this.pnlFrame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFrame_Paint);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 691);
            this.Controls.Add(this.pnlFrame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 508);
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.pnlFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private DataGridView dgvwRecords;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtKeywordSearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI2.WinForms.Guna2Button guna2Button13;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private Label label3;
        public Panel pnlFrame;
        private DataGridViewImageColumn dcolProductPhoto;
        private DataGridViewTextBoxColumn dcolProductId;
        private DataGridViewTextBoxColumn dcolTypeID;
        private DataGridViewTextBoxColumn dcolTypeName;
        private DataGridViewTextBoxColumn dcolBrandID;
        private DataGridViewTextBoxColumn dcolBrandName;
        private DataGridViewTextBoxColumn dcolModel;
        private DataGridViewTextBoxColumn dcolDistributorPrice;
        private DataGridViewTextBoxColumn dcolSuggestedRetailPrice;
        private DataGridViewTextBoxColumn dcolQuantity;
        private DataGridViewTextBoxColumn dcolDealerID;
        private DataGridViewTextBoxColumn dcolDealerName;
    }
}