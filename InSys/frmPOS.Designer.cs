namespace InSys
{
    partial class frmPOS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalPrice = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Chip2 = new Guna.UI2.WinForms.Guna2Chip();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.guna2Chip3 = new Guna.UI2.WinForms.Guna2Chip();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.dgvwRecords = new System.Windows.Forms.DataGridView();
            this.dcolProductPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.dcolOriginalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtSearchProducts = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).BeginInit();
            this.gunaElipsePanel3.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaElipsePanel1.AutoScroll = true;
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.label5);
            this.gunaElipsePanel1.Controls.Add(this.btnCheckOut);
            this.gunaElipsePanel1.Controls.Add(this.label3);
            this.gunaElipsePanel1.Controls.Add(this.flowLayoutPanel1);
            this.gunaElipsePanel1.Controls.Add(this.lblTotalPrice);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(8, 51);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(323, 577);
            this.gunaElipsePanel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mada", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(13, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total Order Amount:";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCheckOut.BorderRadius = 5;
            this.btnCheckOut.BorderThickness = 1;
            this.btnCheckOut.CheckedState.Parent = this.btnCheckOut;
            this.btnCheckOut.CustomImages.Parent = this.btnCheckOut;
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Mada", 9.75F);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.HoverState.Parent = this.btnCheckOut;
            this.btnCheckOut.Location = new System.Drawing.Point(210, 119);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.ShadowDecoration.Parent = this.btnCheckOut;
            this.btnCheckOut.Size = new System.Drawing.Size(98, 36);
            this.btnCheckOut.TabIndex = 33;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mada", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(9, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "Item(s) in the Cart:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 158);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 416);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BorderRadius = 5;
            this.lblTotalPrice.CheckedState.Parent = this.lblTotalPrice;
            this.lblTotalPrice.CustomImages.Parent = this.lblTotalPrice;
            this.lblTotalPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("Mada Medium", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPrice.HoverState.Parent = this.lblTotalPrice;
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 36);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.ShadowDecoration.Parent = this.lblTotalPrice;
            this.lblTotalPrice.Size = new System.Drawing.Size(296, 74);
            this.lblTotalPrice.TabIndex = 34;
            this.lblTotalPrice.Text = "0.00";
            this.lblTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lblTotalPrice.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2Chip2
            // 
            this.guna2Chip2.FillColor = System.Drawing.Color.White;
            this.guna2Chip2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2Chip2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Chip2.Location = new System.Drawing.Point(12, 7);
            this.guna2Chip2.Name = "guna2Chip2";
            this.guna2Chip2.ShadowDecoration.Parent = this.guna2Chip2;
            this.guna2Chip2.Size = new System.Drawing.Size(247, 23);
            this.guna2Chip2.TabIndex = 13;
            this.guna2Chip2.Text = "Shopping Chart";
            this.guna2Chip2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.guna2Chip3);
            this.gunaElipsePanel2.Controls.Add(this.btnAddToCart);
            this.gunaElipsePanel2.Controls.Add(this.dgvwRecords);
            this.gunaElipsePanel2.Controls.Add(this.txtSearchProducts);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(337, 131);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(1095, 497);
            this.gunaElipsePanel2.TabIndex = 15;
            // 
            // guna2Chip3
            // 
            this.guna2Chip3.FillColor = System.Drawing.Color.White;
            this.guna2Chip3.Font = new System.Drawing.Font("Mada", 11.25F);
            this.guna2Chip3.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Chip3.Location = new System.Drawing.Point(9, 11);
            this.guna2Chip3.Name = "guna2Chip3";
            this.guna2Chip3.ShadowDecoration.Parent = this.guna2Chip3;
            this.guna2Chip3.Size = new System.Drawing.Size(197, 23);
            this.guna2Chip3.TabIndex = 13;
            this.guna2Chip3.Text = "List of Products";
            this.guna2Chip3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddToCart.BorderRadius = 5;
            this.btnAddToCart.BorderThickness = 1;
            this.btnAddToCart.CheckedState.Parent = this.btnAddToCart;
            this.btnAddToCart.CustomImages.Parent = this.btnAddToCart;
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(73)))), ((int)(((byte)(148)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Mada", 9.75F);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.Parent = this.btnAddToCart;
            this.btnAddToCart.Location = new System.Drawing.Point(999, 3);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.ShadowDecoration.Parent = this.btnAddToCart;
            this.btnAddToCart.Size = new System.Drawing.Size(83, 36);
            this.btnAddToCart.TabIndex = 26;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAdd_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mada", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvwRecords.ColumnHeadersHeight = 50;
            this.dgvwRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvwRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcolProductPhoto,
            this.dcolOriginalQuantity,
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
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(9, 45);
            this.dgvwRecords.Name = "dgvwRecords";
            this.dgvwRecords.ReadOnly = true;
            this.dgvwRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvwRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvwRecords.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvwRecords.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvwRecords.RowTemplate.Height = 60;
            this.dgvwRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwRecords.Size = new System.Drawing.Size(1083, 449);
            this.dgvwRecords.TabIndex = 25;
            // 
            // dcolProductPhoto
            // 
            this.dcolProductPhoto.DataPropertyName = "ProductPhoto";
            this.dcolProductPhoto.HeaderText = "";
            this.dcolProductPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dcolProductPhoto.Name = "dcolProductPhoto";
            this.dcolProductPhoto.ReadOnly = true;
            this.dcolProductPhoto.Width = 75;
            // 
            // dcolOriginalQuantity
            // 
            this.dcolOriginalQuantity.DataPropertyName = "OriginalQuantity";
            this.dcolOriginalQuantity.HeaderText = "";
            this.dcolOriginalQuantity.Name = "dcolOriginalQuantity";
            this.dcolOriginalQuantity.ReadOnly = true;
            this.dcolOriginalQuantity.Visible = false;
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
            this.dcolTypeName.HeaderText = "Type";
            this.dcolTypeName.Name = "dcolTypeName";
            this.dcolTypeName.ReadOnly = true;
            this.dcolTypeName.Visible = false;
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
            this.dcolBrandName.DataPropertyName = "BrandName";
            this.dcolBrandName.HeaderText = "Brand";
            this.dcolBrandName.Name = "dcolBrandName";
            this.dcolBrandName.ReadOnly = true;
            this.dcolBrandName.Width = 180;
            // 
            // dcolModel
            // 
            this.dcolModel.DataPropertyName = "Model";
            this.dcolModel.HeaderText = "Model";
            this.dcolModel.Name = "dcolModel";
            this.dcolModel.ReadOnly = true;
            this.dcolModel.Width = 220;
            // 
            // dcolDistributorPrice
            // 
            this.dcolDistributorPrice.DataPropertyName = "DistributorPrice";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dcolDistributorPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dcolDistributorPrice.HeaderText = "Distributor Price";
            this.dcolDistributorPrice.Name = "dcolDistributorPrice";
            this.dcolDistributorPrice.ReadOnly = true;
            this.dcolDistributorPrice.Visible = false;
            // 
            // dcolSuggestedRetailPrice
            // 
            this.dcolSuggestedRetailPrice.DataPropertyName = "SuggestedRetailPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dcolSuggestedRetailPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dcolSuggestedRetailPrice.HeaderText = "Suggested Retail Price";
            this.dcolSuggestedRetailPrice.Name = "dcolSuggestedRetailPrice";
            this.dcolSuggestedRetailPrice.ReadOnly = true;
            this.dcolSuggestedRetailPrice.Width = 110;
            // 
            // dcolQuantity
            // 
            this.dcolQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.dcolQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.dcolQuantity.HeaderText = "Quantity";
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
            this.dcolDealerName.DataPropertyName = "DealerName";
            this.dcolDealerName.HeaderText = "Dealer Name";
            this.dcolDealerName.Name = "dcolDealerName";
            this.dcolDealerName.ReadOnly = true;
            this.dcolDealerName.Visible = false;
            this.dcolDealerName.Width = 200;
            // 
            // txtSearchProducts
            // 
            this.txtSearchProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProducts.AutoRoundedCorners = true;
            this.txtSearchProducts.BorderRadius = 17;
            this.txtSearchProducts.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchProducts.DefaultText = "";
            this.txtSearchProducts.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProducts.DisabledState.Parent = this.txtSearchProducts;
            this.txtSearchProducts.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchProducts.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchProducts.FocusedState.Parent = this.txtSearchProducts;
            this.txtSearchProducts.Font = new System.Drawing.Font("Mada", 9.75F);
            this.txtSearchProducts.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchProducts.HoverState.Parent = this.txtSearchProducts;
            this.txtSearchProducts.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.txtSearchProducts.IconLeftSize = new System.Drawing.Size(17, 17);
            this.txtSearchProducts.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchProducts.IconRight")));
            this.txtSearchProducts.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtSearchProducts.Location = new System.Drawing.Point(792, 3);
            this.txtSearchProducts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSearchProducts.Name = "txtSearchProducts";
            this.txtSearchProducts.PasswordChar = '\0';
            this.txtSearchProducts.PlaceholderText = "Search Product ...";
            this.txtSearchProducts.SelectedText = "";
            this.txtSearchProducts.ShadowDecoration.Parent = this.txtSearchProducts;
            this.txtSearchProducts.Size = new System.Drawing.Size(200, 36);
            this.txtSearchProducts.TabIndex = 1;
            this.txtSearchProducts.TextChanged += new System.EventHandler(this.txtSearchProducts_TextChanged);
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel3.Controls.Add(this.label4);
            this.gunaElipsePanel3.Controls.Add(this.txtContactNumber);
            this.gunaElipsePanel3.Controls.Add(this.label2);
            this.gunaElipsePanel3.Controls.Add(this.txtFirstName);
            this.gunaElipsePanel3.Location = new System.Drawing.Point(337, 49);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Size = new System.Drawing.Size(1095, 76);
            this.gunaElipsePanel3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mada", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(465, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "Contact Number";
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
            this.txtContactNumber.Font = new System.Drawing.Font("Mada", 9.75F);
            this.txtContactNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContactNumber.HoverState.Parent = this.txtContactNumber;
            this.txtContactNumber.Location = new System.Drawing.Point(468, 28);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.PlaceholderText = "Enter Contact Number Here...";
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.ShadowDecoration.Parent = this.txtContactNumber;
            this.txtContactNumber.Size = new System.Drawing.Size(215, 36);
            this.txtContactNumber.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mada", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Customer Name";
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
            this.txtFirstName.Font = new System.Drawing.Font("Mada", 9.75F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.HoverState.Parent = this.txtFirstName;
            this.txtFirstName.Location = new System.Drawing.Point(17, 28);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "Enter Customer Name Here...";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(437, 36);
            this.txtFirstName.TabIndex = 26;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
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
            this.pnlHeader.Size = new System.Drawing.Size(1444, 45);
            this.pnlHeader.TabIndex = 19;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Mada", 12F);
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(12, 12);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(197, 23);
            this.guna2Chip1.TabIndex = 12;
            this.guna2Chip1.Text = "Point of Sales";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.pnlHeader;
            // 
            // frmPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 640);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.gunaElipsePanel3);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.gunaElipsePanel3.ResumeLayout(false);
            this.gunaElipsePanel3.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchProducts;
        private System.Windows.Forms.DataGridView dgvwRecords;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtContactNumber;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip2;
        private CheckedItems checkedItems1;
        private CheckedItems checkedItems22;
        private CheckedItems checkedItems2;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal Guna.UI2.WinForms.Guna2TileButton lblTotalPrice;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip3;
        private System.Windows.Forms.DataGridViewImageColumn dcolProductPhoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolOriginalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolBrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolDistributorPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolSuggestedRetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolDealerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcolDealerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}