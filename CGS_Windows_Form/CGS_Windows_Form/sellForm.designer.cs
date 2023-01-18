namespace CGS_Windows
{
    partial class sellForm
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
            this.rtb_sellFrom_displayArtPieceInfo = new System.Windows.Forms.RichTextBox();
            this.bn_sellForm_displayAllArtPieceInfo = new System.Windows.Forms.Button();
            this.lb_sellForm_pieceID = new System.Windows.Forms.Label();
            this.tb_sellForm_PieceID = new System.Windows.Forms.TextBox();
            this.tb_sellForm_estimate = new System.Windows.Forms.TextBox();
            this.lb_sellForm_Estimate = new System.Windows.Forms.Label();
            this.bn_sellForm_sell = new System.Windows.Forms.Button();
            this.bn_sellForm_cancel = new System.Windows.Forms.Button();
            this.bn_sellForm_save = new System.Windows.Forms.Button();
            this.dgv_sell_artPiece = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sell_artPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_sellFrom_displayArtPieceInfo
            // 
            this.rtb_sellFrom_displayArtPieceInfo.Location = new System.Drawing.Point(12, 12);
            this.rtb_sellFrom_displayArtPieceInfo.Name = "rtb_sellFrom_displayArtPieceInfo";
            this.rtb_sellFrom_displayArtPieceInfo.Size = new System.Drawing.Size(627, 159);
            this.rtb_sellFrom_displayArtPieceInfo.TabIndex = 0;
            this.rtb_sellFrom_displayArtPieceInfo.Text = "";
            // 
            // bn_sellForm_displayAllArtPieceInfo
            // 
            this.bn_sellForm_displayAllArtPieceInfo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellForm_displayAllArtPieceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellForm_displayAllArtPieceInfo.Location = new System.Drawing.Point(65, 207);
            this.bn_sellForm_displayAllArtPieceInfo.Name = "bn_sellForm_displayAllArtPieceInfo";
            this.bn_sellForm_displayAllArtPieceInfo.Size = new System.Drawing.Size(514, 57);
            this.bn_sellForm_displayAllArtPieceInfo.TabIndex = 1;
            this.bn_sellForm_displayAllArtPieceInfo.Text = "Display";
            this.bn_sellForm_displayAllArtPieceInfo.UseVisualStyleBackColor = false;
            this.bn_sellForm_displayAllArtPieceInfo.Click += new System.EventHandler(this.bn_sellForm_displayAllArtPieceInfo_Click);
            // 
            // lb_sellForm_pieceID
            // 
            this.lb_sellForm_pieceID.AutoSize = true;
            this.lb_sellForm_pieceID.Location = new System.Drawing.Point(144, 294);
            this.lb_sellForm_pieceID.Name = "lb_sellForm_pieceID";
            this.lb_sellForm_pieceID.Size = new System.Drawing.Size(73, 20);
            this.lb_sellForm_pieceID.TabIndex = 2;
            this.lb_sellForm_pieceID.Text = "PieceID: ";
            // 
            // tb_sellForm_PieceID
            // 
            this.tb_sellForm_PieceID.Location = new System.Drawing.Point(238, 294);
            this.tb_sellForm_PieceID.Name = "tb_sellForm_PieceID";
            this.tb_sellForm_PieceID.Size = new System.Drawing.Size(258, 26);
            this.tb_sellForm_PieceID.TabIndex = 3;
            // 
            // tb_sellForm_estimate
            // 
            this.tb_sellForm_estimate.Location = new System.Drawing.Point(238, 367);
            this.tb_sellForm_estimate.Name = "tb_sellForm_estimate";
            this.tb_sellForm_estimate.Size = new System.Drawing.Size(258, 26);
            this.tb_sellForm_estimate.TabIndex = 5;
            // 
            // lb_sellForm_Estimate
            // 
            this.lb_sellForm_Estimate.AutoSize = true;
            this.lb_sellForm_Estimate.Location = new System.Drawing.Point(144, 367);
            this.lb_sellForm_Estimate.Name = "lb_sellForm_Estimate";
            this.lb_sellForm_Estimate.Size = new System.Drawing.Size(80, 20);
            this.lb_sellForm_Estimate.TabIndex = 4;
            this.lb_sellForm_Estimate.Text = "Estimate: ";
            // 
            // bn_sellForm_sell
            // 
            this.bn_sellForm_sell.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellForm_sell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellForm_sell.Location = new System.Drawing.Point(128, 430);
            this.bn_sellForm_sell.Name = "bn_sellForm_sell";
            this.bn_sellForm_sell.Size = new System.Drawing.Size(188, 41);
            this.bn_sellForm_sell.TabIndex = 6;
            this.bn_sellForm_sell.Text = "Sell";
            this.bn_sellForm_sell.UseVisualStyleBackColor = false;
            this.bn_sellForm_sell.Click += new System.EventHandler(this.bn_sellForm_sell_Click);
            // 
            // bn_sellForm_cancel
            // 
            this.bn_sellForm_cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellForm_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellForm_cancel.Location = new System.Drawing.Point(419, 430);
            this.bn_sellForm_cancel.Name = "bn_sellForm_cancel";
            this.bn_sellForm_cancel.Size = new System.Drawing.Size(188, 41);
            this.bn_sellForm_cancel.TabIndex = 7;
            this.bn_sellForm_cancel.Text = "Cancel";
            this.bn_sellForm_cancel.UseVisualStyleBackColor = false;
            this.bn_sellForm_cancel.Click += new System.EventHandler(this.bn_sellForm_cancel_Click);
            // 
            // bn_sellForm_save
            // 
            this.bn_sellForm_save.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellForm_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellForm_save.Location = new System.Drawing.Point(128, 492);
            this.bn_sellForm_save.Name = "bn_sellForm_save";
            this.bn_sellForm_save.Size = new System.Drawing.Size(188, 41);
            this.bn_sellForm_save.TabIndex = 8;
            this.bn_sellForm_save.Text = "Update";
            this.bn_sellForm_save.UseVisualStyleBackColor = false;
            this.bn_sellForm_save.Click += new System.EventHandler(this.bn_sellForm_save_Click);
            // 
            // dgv_sell_artPiece
            // 
            this.dgv_sell_artPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sell_artPiece.Location = new System.Drawing.Point(704, 36);
            this.dgv_sell_artPiece.Name = "dgv_sell_artPiece";
            this.dgv_sell_artPiece.RowHeadersWidth = 62;
            this.dgv_sell_artPiece.RowTemplate.Height = 28;
            this.dgv_sell_artPiece.Size = new System.Drawing.Size(614, 251);
            this.dgv_sell_artPiece.TabIndex = 10;
            // 
            // sellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 545);
            this.Controls.Add(this.dgv_sell_artPiece);
            this.Controls.Add(this.bn_sellForm_save);
            this.Controls.Add(this.bn_sellForm_cancel);
            this.Controls.Add(this.bn_sellForm_sell);
            this.Controls.Add(this.tb_sellForm_estimate);
            this.Controls.Add(this.lb_sellForm_Estimate);
            this.Controls.Add(this.tb_sellForm_PieceID);
            this.Controls.Add(this.lb_sellForm_pieceID);
            this.Controls.Add(this.bn_sellForm_displayAllArtPieceInfo);
            this.Controls.Add(this.rtb_sellFrom_displayArtPieceInfo);
            this.Name = "sellForm";
            this.Text = "sellForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sell_artPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_sellFrom_displayArtPieceInfo;
        private System.Windows.Forms.Button bn_sellForm_displayAllArtPieceInfo;
        private System.Windows.Forms.Label lb_sellForm_pieceID;
        private System.Windows.Forms.TextBox tb_sellForm_PieceID;
        private System.Windows.Forms.TextBox tb_sellForm_estimate;
        private System.Windows.Forms.Label lb_sellForm_Estimate;
        private System.Windows.Forms.Button bn_sellForm_sell;
        private System.Windows.Forms.Button bn_sellForm_cancel;
        private System.Windows.Forms.Button bn_sellForm_save;
        private System.Windows.Forms.DataGridView dgv_sell_artPiece;
    }
}