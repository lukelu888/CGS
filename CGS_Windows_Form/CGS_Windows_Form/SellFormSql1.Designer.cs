namespace CGS_Windows_Form
{
    partial class SellFormSql
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
            this.dgv_sell_artPiece = new System.Windows.Forms.DataGridView();
            this.dgv_sell_curator = new System.Windows.Forms.DataGridView();
            this.bn_sellSql_cancel = new System.Windows.Forms.Button();
            this.bn_sellSql_sell = new System.Windows.Forms.Button();
            this.tb_sellSql_estimate = new System.Windows.Forms.TextBox();
            this.lb_sellForm_Estimate = new System.Windows.Forms.Label();
            this.tb_sellSql_artPieceId = new System.Windows.Forms.TextBox();
            this.lb_sellForm_pieceID = new System.Windows.Forms.Label();
            this.bn_sellSql_displayArtPiece = new System.Windows.Forms.Button();
            this.bn_sellSql_displayCurator = new System.Windows.Forms.Button();
            this.tb_sellSql_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sell_artPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sell_curator)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sell_artPiece
            // 
            this.dgv_sell_artPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sell_artPiece.Location = new System.Drawing.Point(12, 12);
            this.dgv_sell_artPiece.Name = "dgv_sell_artPiece";
            this.dgv_sell_artPiece.RowHeadersWidth = 62;
            this.dgv_sell_artPiece.RowTemplate.Height = 28;
            this.dgv_sell_artPiece.Size = new System.Drawing.Size(776, 135);
            this.dgv_sell_artPiece.TabIndex = 11;
            // 
            // dgv_sell_curator
            // 
            this.dgv_sell_curator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sell_curator.Location = new System.Drawing.Point(12, 158);
            this.dgv_sell_curator.Name = "dgv_sell_curator";
            this.dgv_sell_curator.RowHeadersWidth = 62;
            this.dgv_sell_curator.RowTemplate.Height = 28;
            this.dgv_sell_curator.Size = new System.Drawing.Size(776, 135);
            this.dgv_sell_curator.TabIndex = 12;
            // 
            // bn_sellSql_cancel
            // 
            this.bn_sellSql_cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellSql_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellSql_cancel.Location = new System.Drawing.Point(376, 543);
            this.bn_sellSql_cancel.Name = "bn_sellSql_cancel";
            this.bn_sellSql_cancel.Size = new System.Drawing.Size(188, 41);
            this.bn_sellSql_cancel.TabIndex = 18;
            this.bn_sellSql_cancel.Text = "Cancel";
            this.bn_sellSql_cancel.UseVisualStyleBackColor = false;
            this.bn_sellSql_cancel.Click += new System.EventHandler(this.bn_sellSql_cancel_Click);
            // 
            // bn_sellSql_sell
            // 
            this.bn_sellSql_sell.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellSql_sell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellSql_sell.Location = new System.Drawing.Point(85, 543);
            this.bn_sellSql_sell.Name = "bn_sellSql_sell";
            this.bn_sellSql_sell.Size = new System.Drawing.Size(188, 41);
            this.bn_sellSql_sell.TabIndex = 17;
            this.bn_sellSql_sell.Text = "Sell";
            this.bn_sellSql_sell.UseVisualStyleBackColor = false;
            this.bn_sellSql_sell.Click += new System.EventHandler(this.bn_sellSql_sell_Click);
            // 
            // tb_sellSql_estimate
            // 
            this.tb_sellSql_estimate.Location = new System.Drawing.Point(175, 407);
            this.tb_sellSql_estimate.Name = "tb_sellSql_estimate";
            this.tb_sellSql_estimate.Size = new System.Drawing.Size(258, 26);
            this.tb_sellSql_estimate.TabIndex = 16;
            // 
            // lb_sellForm_Estimate
            // 
            this.lb_sellForm_Estimate.AutoSize = true;
            this.lb_sellForm_Estimate.Location = new System.Drawing.Point(81, 407);
            this.lb_sellForm_Estimate.Name = "lb_sellForm_Estimate";
            this.lb_sellForm_Estimate.Size = new System.Drawing.Size(80, 20);
            this.lb_sellForm_Estimate.TabIndex = 15;
            this.lb_sellForm_Estimate.Text = "Estimate: ";
            // 
            // tb_sellSql_artPieceId
            // 
            this.tb_sellSql_artPieceId.Location = new System.Drawing.Point(175, 334);
            this.tb_sellSql_artPieceId.Name = "tb_sellSql_artPieceId";
            this.tb_sellSql_artPieceId.Size = new System.Drawing.Size(258, 26);
            this.tb_sellSql_artPieceId.TabIndex = 14;
            // 
            // lb_sellForm_pieceID
            // 
            this.lb_sellForm_pieceID.AutoSize = true;
            this.lb_sellForm_pieceID.Location = new System.Drawing.Point(81, 334);
            this.lb_sellForm_pieceID.Name = "lb_sellForm_pieceID";
            this.lb_sellForm_pieceID.Size = new System.Drawing.Size(73, 20);
            this.lb_sellForm_pieceID.TabIndex = 13;
            this.lb_sellForm_pieceID.Text = "PieceID: ";
            // 
            // bn_sellSql_displayArtPiece
            // 
            this.bn_sellSql_displayArtPiece.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellSql_displayArtPiece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellSql_displayArtPiece.Location = new System.Drawing.Point(536, 319);
            this.bn_sellSql_displayArtPiece.Name = "bn_sellSql_displayArtPiece";
            this.bn_sellSql_displayArtPiece.Size = new System.Drawing.Size(188, 41);
            this.bn_sellSql_displayArtPiece.TabIndex = 19;
            this.bn_sellSql_displayArtPiece.Text = "Display ArtPiece";
            this.bn_sellSql_displayArtPiece.UseVisualStyleBackColor = false;
            this.bn_sellSql_displayArtPiece.Click += new System.EventHandler(this.bn_sellSql_displayArtPiece_Click);
            // 
            // bn_sellSql_displayCurator
            // 
            this.bn_sellSql_displayCurator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellSql_displayCurator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellSql_displayCurator.Location = new System.Drawing.Point(536, 386);
            this.bn_sellSql_displayCurator.Name = "bn_sellSql_displayCurator";
            this.bn_sellSql_displayCurator.Size = new System.Drawing.Size(188, 41);
            this.bn_sellSql_displayCurator.TabIndex = 20;
            this.bn_sellSql_displayCurator.Text = "Display Curator";
            this.bn_sellSql_displayCurator.UseVisualStyleBackColor = false;
            this.bn_sellSql_displayCurator.Click += new System.EventHandler(this.bn_sellSql_displayCurator_Click);
            // 
            // tb_sellSql_value
            // 
            this.tb_sellSql_value.Location = new System.Drawing.Point(175, 478);
            this.tb_sellSql_value.Name = "tb_sellSql_value";
            this.tb_sellSql_value.Size = new System.Drawing.Size(258, 26);
            this.tb_sellSql_value.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Value: ";
            // 
            // SellFormSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.tb_sellSql_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bn_sellSql_displayCurator);
            this.Controls.Add(this.bn_sellSql_displayArtPiece);
            this.Controls.Add(this.bn_sellSql_cancel);
            this.Controls.Add(this.bn_sellSql_sell);
            this.Controls.Add(this.tb_sellSql_estimate);
            this.Controls.Add(this.lb_sellForm_Estimate);
            this.Controls.Add(this.tb_sellSql_artPieceId);
            this.Controls.Add(this.lb_sellForm_pieceID);
            this.Controls.Add(this.dgv_sell_curator);
            this.Controls.Add(this.dgv_sell_artPiece);
            this.Name = "SellFormSql";
            this.Text = "SellFormSql";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sell_artPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sell_curator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sell_artPiece;
        private System.Windows.Forms.DataGridView dgv_sell_curator;
        private System.Windows.Forms.Button bn_sellSql_cancel;
        private System.Windows.Forms.Button bn_sellSql_sell;
        private System.Windows.Forms.TextBox tb_sellSql_estimate;
        private System.Windows.Forms.Label lb_sellForm_Estimate;
        private System.Windows.Forms.TextBox tb_sellSql_artPieceId;
        private System.Windows.Forms.Label lb_sellForm_pieceID;
        private System.Windows.Forms.Button bn_sellSql_displayArtPiece;
        private System.Windows.Forms.Button bn_sellSql_displayCurator;
        private System.Windows.Forms.TextBox tb_sellSql_value;
        private System.Windows.Forms.Label label1;
    }
}