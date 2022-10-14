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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.guna2Panel1.Size = new System.Drawing.Size(1188, 45);
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
            this.guna2Chip1.Text = "Product Inventory Management";
            this.guna2Chip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(173, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(70, 36);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderThickness = 1;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(97, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(70, 36);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(21, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(70, 36);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.dgvwRecords.EnableHeadersVisualStyles = false;
            this.dgvwRecords.Location = new System.Drawing.Point(21, 93);
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
            this.dgvwRecords.Size = new System.Drawing.Size(1150, 321);
            this.dgvwRecords.TabIndex = 24;
            // 
            // dcolProductPhoto
            // 
            this.dcolProductPhoto.DataPropertyName = "ProductPhoto";
            this.dcolProductPhoto.HeaderText = "";
            this.dcolProductPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
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
            this.dcolTypeName.HeaderText = "Type";
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
            this.dcolBrandName.DataPropertyName = "BrandName";
            this.dcolBrandName.HeaderText = "Brand";
            this.dcolBrandName.Name = "dcolBrandName";
            this.dcolBrandName.ReadOnly = true;
            this.dcolBrandName.Width = 170;
            // 
            // dcolModel
            // 
            this.dcolModel.DataPropertyName = "Model";
            this.dcolModel.HeaderText = "Model";
            this.dcolModel.Name = "dcolModel";
            this.dcolModel.ReadOnly = true;
            this.dcolModel.Width = 200;
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
            this.dcolDealerName.Width = 200;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 434);
            this.Controls.Add(this.dgvwRecords);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInventory_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private DataGridView dgvwRecords;
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