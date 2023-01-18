namespace CGS_Windows_Form
{
    partial class ArtistSql
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
            this.bn_viewArtists = new System.Windows.Forms.Button();
            this.bn_addArtist = new System.Windows.Forms.Button();
            this.tb_artist_artistId = new System.Windows.Forms.TextBox();
            this.tb_artist_lname = new System.Windows.Forms.TextBox();
            this.tb_artist_fname = new System.Windows.Forms.TextBox();
            this.lb_artist_artistId = new System.Windows.Forms.Label();
            this.lb_artist_lname = new System.Windows.Forms.Label();
            this.lb_artist_fname = new System.Windows.Forms.Label();
            this.lb_artists_title = new System.Windows.Forms.Label();
            this.tb_artist_curatorId = new System.Windows.Forms.TextBox();
            this.lb_artist_curatorId = new System.Windows.Forms.Label();
            this.dgv_artist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_artist)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_viewArtists
            // 
            this.bn_viewArtists.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_viewArtists.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_viewArtists.Location = new System.Drawing.Point(566, 299);
            this.bn_viewArtists.Name = "bn_viewArtists";
            this.bn_viewArtists.Size = new System.Drawing.Size(142, 35);
            this.bn_viewArtists.TabIndex = 34;
            this.bn_viewArtists.Text = "Cancel";
            this.bn_viewArtists.UseVisualStyleBackColor = false;
            this.bn_viewArtists.Click += new System.EventHandler(this.bn_viewArtists_Click);
            // 
            // bn_addArtist
            // 
            this.bn_addArtist.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_addArtist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_addArtist.Location = new System.Drawing.Point(566, 235);
            this.bn_addArtist.Name = "bn_addArtist";
            this.bn_addArtist.Size = new System.Drawing.Size(142, 38);
            this.bn_addArtist.TabIndex = 33;
            this.bn_addArtist.Text = "Add Artist";
            this.bn_addArtist.UseVisualStyleBackColor = false;
            this.bn_addArtist.Click += new System.EventHandler(this.bn_addArtist_Click);
            // 
            // tb_artist_artistId
            // 
            this.tb_artist_artistId.Location = new System.Drawing.Point(190, 84);
            this.tb_artist_artistId.Name = "tb_artist_artistId";
            this.tb_artist_artistId.Size = new System.Drawing.Size(282, 26);
            this.tb_artist_artistId.TabIndex = 32;
            // 
            // tb_artist_lname
            // 
            this.tb_artist_lname.Location = new System.Drawing.Point(190, 232);
            this.tb_artist_lname.Name = "tb_artist_lname";
            this.tb_artist_lname.Size = new System.Drawing.Size(282, 26);
            this.tb_artist_lname.TabIndex = 31;
            // 
            // tb_artist_fname
            // 
            this.tb_artist_fname.Location = new System.Drawing.Point(190, 190);
            this.tb_artist_fname.Name = "tb_artist_fname";
            this.tb_artist_fname.Size = new System.Drawing.Size(282, 26);
            this.tb_artist_fname.TabIndex = 30;
            // 
            // lb_artist_artistId
            // 
            this.lb_artist_artistId.AutoSize = true;
            this.lb_artist_artistId.Location = new System.Drawing.Point(63, 90);
            this.lb_artist_artistId.Name = "lb_artist_artistId";
            this.lb_artist_artistId.Size = new System.Drawing.Size(71, 20);
            this.lb_artist_artistId.TabIndex = 29;
            this.lb_artist_artistId.Text = "Artist ID:";
            // 
            // lb_artist_lname
            // 
            this.lb_artist_lname.AutoSize = true;
            this.lb_artist_lname.Location = new System.Drawing.Point(63, 235);
            this.lb_artist_lname.Name = "lb_artist_lname";
            this.lb_artist_lname.Size = new System.Drawing.Size(90, 20);
            this.lb_artist_lname.TabIndex = 28;
            this.lb_artist_lname.Text = "Last Name:";
            // 
            // lb_artist_fname
            // 
            this.lb_artist_fname.AutoSize = true;
            this.lb_artist_fname.Location = new System.Drawing.Point(63, 190);
            this.lb_artist_fname.Name = "lb_artist_fname";
            this.lb_artist_fname.Size = new System.Drawing.Size(90, 20);
            this.lb_artist_fname.TabIndex = 27;
            this.lb_artist_fname.Text = "First Name:";
            // 
            // lb_artists_title
            // 
            this.lb_artists_title.AutoSize = true;
            this.lb_artists_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_artists_title.Location = new System.Drawing.Point(57, 42);
            this.lb_artists_title.Name = "lb_artists_title";
            this.lb_artists_title.Size = new System.Drawing.Size(209, 29);
            this.lb_artists_title.TabIndex = 26;
            this.lb_artists_title.Text = "Artist Information";
            // 
            // tb_artist_curatorId
            // 
            this.tb_artist_curatorId.Location = new System.Drawing.Point(190, 134);
            this.tb_artist_curatorId.Name = "tb_artist_curatorId";
            this.tb_artist_curatorId.Size = new System.Drawing.Size(282, 26);
            this.tb_artist_curatorId.TabIndex = 37;
            // 
            // lb_artist_curatorId
            // 
            this.lb_artist_curatorId.AutoSize = true;
            this.lb_artist_curatorId.Location = new System.Drawing.Point(63, 140);
            this.lb_artist_curatorId.Name = "lb_artist_curatorId";
            this.lb_artist_curatorId.Size = new System.Drawing.Size(87, 20);
            this.lb_artist_curatorId.TabIndex = 36;
            this.lb_artist_curatorId.Text = "Curator ID:";
            // 
            // dgv_artist
            // 
            this.dgv_artist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_artist.Location = new System.Drawing.Point(62, 342);
            this.dgv_artist.Name = "dgv_artist";
            this.dgv_artist.RowHeadersWidth = 62;
            this.dgv_artist.RowTemplate.Height = 28;
            this.dgv_artist.Size = new System.Drawing.Size(682, 339);
            this.dgv_artist.TabIndex = 38;
            // 
            // ArtistSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.dgv_artist);
            this.Controls.Add(this.tb_artist_curatorId);
            this.Controls.Add(this.lb_artist_curatorId);
            this.Controls.Add(this.bn_viewArtists);
            this.Controls.Add(this.bn_addArtist);
            this.Controls.Add(this.tb_artist_artistId);
            this.Controls.Add(this.tb_artist_lname);
            this.Controls.Add(this.tb_artist_fname);
            this.Controls.Add(this.lb_artist_artistId);
            this.Controls.Add(this.lb_artist_lname);
            this.Controls.Add(this.lb_artist_fname);
            this.Controls.Add(this.lb_artists_title);
            this.Name = "ArtistSql";
            this.Text = "ArtistSql";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_artist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bn_viewArtists;
        private System.Windows.Forms.Button bn_addArtist;
        private System.Windows.Forms.TextBox tb_artist_artistId;
        private System.Windows.Forms.TextBox tb_artist_lname;
        private System.Windows.Forms.TextBox tb_artist_fname;
        private System.Windows.Forms.Label lb_artist_artistId;
        private System.Windows.Forms.Label lb_artist_lname;
        private System.Windows.Forms.Label lb_artist_fname;
        private System.Windows.Forms.Label lb_artists_title;
        private System.Windows.Forms.TextBox tb_artist_curatorId;
        private System.Windows.Forms.Label lb_artist_curatorId;
        private System.Windows.Forms.DataGridView dgv_artist;
    }
}