namespace CGS_Windows_Form
{
    partial class ArtPieceSql
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
            this.bn_addArtPiece = new System.Windows.Forms.Button();
            this.gb_status = new System.Windows.Forms.GroupBox();
            this.rb_inStorage = new System.Windows.Forms.RadioButton();
            this.rb_onDisplay = new System.Windows.Forms.RadioButton();
            this.txb_artPiece_curatorID = new System.Windows.Forms.TextBox();
            this.txb_artPiece_artistID = new System.Windows.Forms.TextBox();
            this.txb_artPiece_value = new System.Windows.Forms.TextBox();
            this.lb_curator_id = new System.Windows.Forms.Label();
            this.lb_artist_ID = new System.Windows.Forms.Label();
            this.lb_artPiece_value = new System.Windows.Forms.Label();
            this.txb_artPiece_year = new System.Windows.Forms.TextBox();
            this.txb_artPiece_title = new System.Windows.Forms.TextBox();
            this.lb_artPiece_year = new System.Windows.Forms.Label();
            this.lb_artPiece_title = new System.Windows.Forms.Label();
            this.lb_artPieceID = new System.Windows.Forms.Label();
            this.lb_artPiece = new System.Windows.Forms.Label();
            this.dgv_artPiece = new System.Windows.Forms.DataGridView();
            this.ArtpieceIDtextBox = new System.Windows.Forms.TextBox();
            this.gb_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_artPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_addArtPiece
            // 
            this.bn_addArtPiece.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_addArtPiece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_addArtPiece.Location = new System.Drawing.Point(413, 174);
            this.bn_addArtPiece.Name = "bn_addArtPiece";
            this.bn_addArtPiece.Size = new System.Drawing.Size(145, 39);
            this.bn_addArtPiece.TabIndex = 57;
            this.bn_addArtPiece.Text = "Add Art Piece";
            this.bn_addArtPiece.UseVisualStyleBackColor = false;
            this.bn_addArtPiece.Click += new System.EventHandler(this.bn_addArtPiece_Click);
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rb_inStorage);
            this.gb_status.Controls.Add(this.rb_onDisplay);
            this.gb_status.Location = new System.Drawing.Point(384, 54);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(200, 100);
            this.gb_status.TabIndex = 54;
            this.gb_status.TabStop = false;
            this.gb_status.Text = "Status";
            // 
            // rb_inStorage
            // 
            this.rb_inStorage.AutoSize = true;
            this.rb_inStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inStorage.Location = new System.Drawing.Point(29, 66);
            this.rb_inStorage.Name = "rb_inStorage";
            this.rb_inStorage.Size = new System.Drawing.Size(119, 24);
            this.rb_inStorage.TabIndex = 1;
            this.rb_inStorage.TabStop = true;
            this.rb_inStorage.Text = "In Storage";
            this.rb_inStorage.UseVisualStyleBackColor = true;
            // 
            // rb_onDisplay
            // 
            this.rb_onDisplay.AutoSize = true;
            this.rb_onDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_onDisplay.Location = new System.Drawing.Point(29, 26);
            this.rb_onDisplay.Name = "rb_onDisplay";
            this.rb_onDisplay.Size = new System.Drawing.Size(120, 24);
            this.rb_onDisplay.TabIndex = 0;
            this.rb_onDisplay.TabStop = true;
            this.rb_onDisplay.Text = "On Display";
            this.rb_onDisplay.UseVisualStyleBackColor = true;
            // 
            // txb_artPiece_curatorID
            // 
            this.txb_artPiece_curatorID.Location = new System.Drawing.Point(158, 222);
            this.txb_artPiece_curatorID.Name = "txb_artPiece_curatorID";
            this.txb_artPiece_curatorID.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_curatorID.TabIndex = 53;
            // 
            // txb_artPiece_artistID
            // 
            this.txb_artPiece_artistID.Location = new System.Drawing.Point(158, 190);
            this.txb_artPiece_artistID.Name = "txb_artPiece_artistID";
            this.txb_artPiece_artistID.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_artistID.TabIndex = 52;
            // 
            // txb_artPiece_value
            // 
            this.txb_artPiece_value.Location = new System.Drawing.Point(158, 156);
            this.txb_artPiece_value.Name = "txb_artPiece_value";
            this.txb_artPiece_value.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_value.TabIndex = 51;
            // 
            // lb_curator_id
            // 
            this.lb_curator_id.AutoSize = true;
            this.lb_curator_id.Location = new System.Drawing.Point(31, 228);
            this.lb_curator_id.Name = "lb_curator_id";
            this.lb_curator_id.Size = new System.Drawing.Size(87, 20);
            this.lb_curator_id.TabIndex = 50;
            this.lb_curator_id.Text = "Curator ID:";
            // 
            // lb_artist_ID
            // 
            this.lb_artist_ID.AutoSize = true;
            this.lb_artist_ID.Location = new System.Drawing.Point(31, 193);
            this.lb_artist_ID.Name = "lb_artist_ID";
            this.lb_artist_ID.Size = new System.Drawing.Size(71, 20);
            this.lb_artist_ID.TabIndex = 49;
            this.lb_artist_ID.Text = "Artist ID:";
            // 
            // lb_artPiece_value
            // 
            this.lb_artPiece_value.AutoSize = true;
            this.lb_artPiece_value.Location = new System.Drawing.Point(31, 156);
            this.lb_artPiece_value.Name = "lb_artPiece_value";
            this.lb_artPiece_value.Size = new System.Drawing.Size(54, 20);
            this.lb_artPiece_value.TabIndex = 48;
            this.lb_artPiece_value.Text = "Value:";
            // 
            // txb_artPiece_year
            // 
            this.txb_artPiece_year.Location = new System.Drawing.Point(158, 119);
            this.txb_artPiece_year.Name = "txb_artPiece_year";
            this.txb_artPiece_year.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_year.TabIndex = 47;
            // 
            // txb_artPiece_title
            // 
            this.txb_artPiece_title.Location = new System.Drawing.Point(158, 87);
            this.txb_artPiece_title.Name = "txb_artPiece_title";
            this.txb_artPiece_title.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_title.TabIndex = 46;
            // 
            // lb_artPiece_year
            // 
            this.lb_artPiece_year.AutoSize = true;
            this.lb_artPiece_year.Location = new System.Drawing.Point(31, 125);
            this.lb_artPiece_year.Name = "lb_artPiece_year";
            this.lb_artPiece_year.Size = new System.Drawing.Size(47, 20);
            this.lb_artPiece_year.TabIndex = 44;
            this.lb_artPiece_year.Text = "Year:";
            // 
            // lb_artPiece_title
            // 
            this.lb_artPiece_title.AutoSize = true;
            this.lb_artPiece_title.Location = new System.Drawing.Point(31, 90);
            this.lb_artPiece_title.Name = "lb_artPiece_title";
            this.lb_artPiece_title.Size = new System.Drawing.Size(42, 20);
            this.lb_artPiece_title.TabIndex = 43;
            this.lb_artPiece_title.Text = "Title:";
            // 
            // lb_artPieceID
            // 
            this.lb_artPieceID.AutoSize = true;
            this.lb_artPieceID.Location = new System.Drawing.Point(31, 53);
            this.lb_artPieceID.Name = "lb_artPieceID";
            this.lb_artPieceID.Size = new System.Drawing.Size(30, 20);
            this.lb_artPieceID.TabIndex = 42;
            this.lb_artPieceID.Text = "ID:";
            // 
            // lb_artPiece
            // 
            this.lb_artPiece.AutoSize = true;
            this.lb_artPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_artPiece.Location = new System.Drawing.Point(30, 9);
            this.lb_artPiece.Name = "lb_artPiece";
            this.lb_artPiece.Size = new System.Drawing.Size(256, 29);
            this.lb_artPiece.TabIndex = 41;
            this.lb_artPiece.Text = "Art Piece Information";
            // 
            // dgv_artPiece
            // 
            this.dgv_artPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_artPiece.Location = new System.Drawing.Point(35, 292);
            this.dgv_artPiece.Name = "dgv_artPiece";
            this.dgv_artPiece.RowHeadersWidth = 62;
            this.dgv_artPiece.RowTemplate.Height = 28;
            this.dgv_artPiece.Size = new System.Drawing.Size(724, 342);
            this.dgv_artPiece.TabIndex = 58;
            // 
            // ArtpieceIDtextBox
            // 
            this.ArtpieceIDtextBox.Location = new System.Drawing.Point(158, 47);
            this.ArtpieceIDtextBox.Name = "ArtpieceIDtextBox";
            this.ArtpieceIDtextBox.Size = new System.Drawing.Size(171, 26);
            this.ArtpieceIDtextBox.TabIndex = 59;
            // 
            // ArtPieceSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.ArtpieceIDtextBox);
            this.Controls.Add(this.dgv_artPiece);
            this.Controls.Add(this.bn_addArtPiece);
            this.Controls.Add(this.gb_status);
            this.Controls.Add(this.txb_artPiece_curatorID);
            this.Controls.Add(this.txb_artPiece_artistID);
            this.Controls.Add(this.txb_artPiece_value);
            this.Controls.Add(this.lb_curator_id);
            this.Controls.Add(this.lb_artist_ID);
            this.Controls.Add(this.lb_artPiece_value);
            this.Controls.Add(this.txb_artPiece_year);
            this.Controls.Add(this.txb_artPiece_title);
            this.Controls.Add(this.lb_artPiece_year);
            this.Controls.Add(this.lb_artPiece_title);
            this.Controls.Add(this.lb_artPieceID);
            this.Controls.Add(this.lb_artPiece);
            this.Name = "ArtPieceSql";
            this.Text = "ArtPieceSql";
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_artPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bn_addArtPiece;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.RadioButton rb_inStorage;
        private System.Windows.Forms.RadioButton rb_onDisplay;
        private System.Windows.Forms.TextBox txb_artPiece_curatorID;
        private System.Windows.Forms.TextBox txb_artPiece_artistID;
        private System.Windows.Forms.TextBox txb_artPiece_value;
        private System.Windows.Forms.Label lb_curator_id;
        private System.Windows.Forms.Label lb_artist_ID;
        private System.Windows.Forms.Label lb_artPiece_value;
        private System.Windows.Forms.TextBox txb_artPiece_year;
        private System.Windows.Forms.TextBox txb_artPiece_title;
        private System.Windows.Forms.Label lb_artPiece_year;
        private System.Windows.Forms.Label lb_artPiece_title;
        private System.Windows.Forms.Label lb_artPieceID;
        private System.Windows.Forms.Label lb_artPiece;
        private System.Windows.Forms.DataGridView dgv_artPiece;
        private System.Windows.Forms.TextBox ArtpieceIDtextBox;
    }
}