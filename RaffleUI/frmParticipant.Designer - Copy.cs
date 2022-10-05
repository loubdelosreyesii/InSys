namespace RaffleUI
{
    partial class frmWinnerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWinnerView));
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblBetterLuck = new Guna.UI.WinForms.GunaLabel();
            this.lblWinner = new Guna.UI.WinForms.GunaLabel();
            this.gifBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tblRaffleNo = new System.Windows.Forms.TableLayoutPanel();
            this.lblRaffleReferenceNumber = new Guna.UI.WinForms.GunaLabel();
            this.tblPanelPart = new System.Windows.Forms.TableLayoutPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gifBox2)).BeginInit();
            this.tblRaffleNo.SuspendLayout();
            this.tblPanelPart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = null;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(743, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // lblBetterLuck
            // 
            this.lblBetterLuck.AutoSize = true;
            this.lblBetterLuck.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetterLuck.ForeColor = System.Drawing.Color.White;
            this.lblBetterLuck.Location = new System.Drawing.Point(102, 118);
            this.lblBetterLuck.Name = "lblBetterLuck";
            this.lblBetterLuck.Size = new System.Drawing.Size(533, 65);
            this.lblBetterLuck.TabIndex = 0;
            this.lblBetterLuck.Text = "Better Luck Next Time";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.Transparent;
            this.tblPanelPart.SetColumnSpan(this.lblWinner, 3);
            this.lblWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWinner.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(3, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(782, 69);
            this.lblWinner.TabIndex = 50;
            this.lblWinner.Text = "Participant Name Here";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gifBox2
            // 
            this.gifBox2.Image = ((System.Drawing.Image)(resources.GetObject("gifBox2.Image")));
            this.gifBox2.Location = new System.Drawing.Point(133, -67);
            this.gifBox2.Name = "gifBox2";
            this.gifBox2.ShadowDecoration.Parent = this.gifBox2;
            this.gifBox2.Size = new System.Drawing.Size(474, 197);
            this.gifBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gifBox2.TabIndex = 54;
            this.gifBox2.TabStop = false;
            // 
            // tblRaffleNo
            // 
            this.tblRaffleNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblRaffleNo.ColumnCount = 3;
            this.tblRaffleNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34334F));
            this.tblRaffleNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34334F));
            this.tblRaffleNo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.31332F));
            this.tblRaffleNo.Controls.Add(this.lblRaffleReferenceNumber, 1, 0);
            this.tblRaffleNo.Location = new System.Drawing.Point(0, 201);
            this.tblRaffleNo.Name = "tblRaffleNo";
            this.tblRaffleNo.RowCount = 1;
            this.tblRaffleNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRaffleNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tblRaffleNo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tblRaffleNo.Size = new System.Drawing.Size(788, 52);
            this.tblRaffleNo.TabIndex = 55;
            // 
            // lblRaffleReferenceNumber
            // 
            this.lblRaffleReferenceNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRaffleReferenceNumber.AutoSize = true;
            this.tblRaffleNo.SetColumnSpan(this.lblRaffleReferenceNumber, 3);
            this.lblRaffleReferenceNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaffleReferenceNumber.ForeColor = System.Drawing.Color.White;
            this.lblRaffleReferenceNumber.Location = new System.Drawing.Point(3, 0);
            this.lblRaffleReferenceNumber.Name = "lblRaffleReferenceNumber";
            this.lblRaffleReferenceNumber.Size = new System.Drawing.Size(782, 52);
            this.lblRaffleReferenceNumber.TabIndex = 53;
            this.lblRaffleReferenceNumber.Text = "Raffle Reference Name Here";
            this.lblRaffleReferenceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblPanelPart
            // 
            this.tblPanelPart.ColumnCount = 3;
            this.tblPanelPart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanelPart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanelPart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPanelPart.Controls.Add(this.lblWinner, 0, 0);
            this.tblPanelPart.Location = new System.Drawing.Point(0, 118);
            this.tblPanelPart.Name = "tblPanelPart";
            this.tblPanelPart.RowCount = 1;
            this.tblPanelPart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelPart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblPanelPart.Size = new System.Drawing.Size(788, 69);
            this.tblPanelPart.TabIndex = 56;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(653, 176);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(123, 149);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 57;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmWinnerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(788, 337);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.tblPanelPart);
            this.Controls.Add(this.tblRaffleNo);
            this.Controls.Add(this.lblBetterLuck);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.gifBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWinnerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmParticipant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gifBox2)).EndInit();
            this.tblRaffleNo.ResumeLayout(false);
            this.tblRaffleNo.PerformLayout();
            this.tblPanelPart.ResumeLayout(false);
            this.tblPanelPart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI.WinForms.GunaLabel lblBetterLuck;
        private Guna.UI.WinForms.GunaLabel lblWinner;
        private Guna.UI2.WinForms.Guna2PictureBox gifBox2;
        private System.Windows.Forms.TableLayoutPanel tblPanelPart;
        private System.Windows.Forms.TableLayoutPanel tblRaffleNo;
        private Guna.UI.WinForms.GunaLabel lblRaffleReferenceNumber;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}