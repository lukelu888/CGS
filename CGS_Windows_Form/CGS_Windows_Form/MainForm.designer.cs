namespace CGS_Windows
{
    partial class MainForm
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
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tabCurators = new System.Windows.Forms.TabPage();
            this.bn_curators_updateCuratorInFileV2 = new System.Windows.Forms.Button();
            this.bn_curators_updateCuratorInFile = new System.Windows.Forms.Button();
            this.bn_curators_appendCuratorInFile = new System.Windows.Forms.Button();
            this.bn_viewCurator = new System.Windows.Forms.Button();
            this.bn_curators_saveCuratorInFile = new System.Windows.Forms.Button();
            this.bn_addCurator = new System.Windows.Forms.Button();
            this.txb_curatorID = new System.Windows.Forms.TextBox();
            this.txb_curator_lname = new System.Windows.Forms.TextBox();
            this.txb_curator_fname = new System.Windows.Forms.TextBox();
            this.lb_curatorID = new System.Windows.Forms.Label();
            this.lb_curator_lname = new System.Windows.Forms.Label();
            this.lb_curator_fname = new System.Windows.Forms.Label();
            this.lb_curators_title = new System.Windows.Forms.Label();
            this.tabArtists = new System.Windows.Forms.TabPage();
            this.bn_artists_saveArtists = new System.Windows.Forms.Button();
            this.bn_viewArtists = new System.Windows.Forms.Button();
            this.bn_addArtist = new System.Windows.Forms.Button();
            this.txb_artistID = new System.Windows.Forms.TextBox();
            this.txb_artist_lname = new System.Windows.Forms.TextBox();
            this.txb_artist_fname = new System.Windows.Forms.TextBox();
            this.lb_artistID = new System.Windows.Forms.Label();
            this.lb_artist_lname = new System.Windows.Forms.Label();
            this.lb_artist_fname = new System.Windows.Forms.Label();
            this.lb_artists_title = new System.Windows.Forms.Label();
            this.tabArtPieces = new System.Windows.Forms.TabPage();
            this.bn_artPiece_saveArtPiece = new System.Windows.Forms.Button();
            this.bn_artPiece_saveArtPieces = new System.Windows.Forms.Button();
            this.bn_addArtPiece = new System.Windows.Forms.Button();
            this.bn_listArtPieces = new System.Windows.Forms.Button();
            this.bn_sellArtpiece = new System.Windows.Forms.Button();
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
            this.txb_artPiece_pieceID = new System.Windows.Forms.TextBox();
            this.lb_artPiece_year = new System.Windows.Forms.Label();
            this.lb_artPiece_title = new System.Windows.Forms.Label();
            this.lb_artPieceID = new System.Windows.Forms.Label();
            this.lb_artPiece = new System.Windows.Forms.Label();
            this.bn_close = new System.Windows.Forms.Button();
            this.statusStrip_mainForm = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_MainForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rtb_main = new System.Windows.Forms.RichTextBox();
            this.tab_main.SuspendLayout();
            this.tabCurators.SuspendLayout();
            this.tabArtists.SuspendLayout();
            this.tabArtPieces.SuspendLayout();
            this.gb_status.SuspendLayout();
            this.statusStrip_mainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tabCurators);
            this.tab_main.Controls.Add(this.tabArtists);
            this.tab_main.Controls.Add(this.tabArtPieces);
            this.tab_main.Location = new System.Drawing.Point(12, 12);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(638, 419);
            this.tab_main.TabIndex = 0;
            this.tab_main.SelectedIndexChanged += new System.EventHandler(this.tabArtists_MouseHover);
            // 
            // tabCurators
            // 
            this.tabCurators.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabCurators.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCurators.Controls.Add(this.bn_curators_updateCuratorInFileV2);
            this.tabCurators.Controls.Add(this.bn_curators_updateCuratorInFile);
            this.tabCurators.Controls.Add(this.bn_curators_appendCuratorInFile);
            this.tabCurators.Controls.Add(this.bn_viewCurator);
            this.tabCurators.Controls.Add(this.bn_curators_saveCuratorInFile);
            this.tabCurators.Controls.Add(this.bn_addCurator);
            this.tabCurators.Controls.Add(this.txb_curatorID);
            this.tabCurators.Controls.Add(this.txb_curator_lname);
            this.tabCurators.Controls.Add(this.txb_curator_fname);
            this.tabCurators.Controls.Add(this.lb_curatorID);
            this.tabCurators.Controls.Add(this.lb_curator_lname);
            this.tabCurators.Controls.Add(this.lb_curator_fname);
            this.tabCurators.Controls.Add(this.lb_curators_title);
            this.tabCurators.Location = new System.Drawing.Point(4, 29);
            this.tabCurators.Name = "tabCurators";
            this.tabCurators.Padding = new System.Windows.Forms.Padding(3);
            this.tabCurators.Size = new System.Drawing.Size(630, 386);
            this.tabCurators.TabIndex = 0;
            this.tabCurators.Text = "Curators";
            this.tabCurators.MouseHover += new System.EventHandler(this.tabCurators_MouseHover);
            // 
            // bn_curators_updateCuratorInFileV2
            // 
            this.bn_curators_updateCuratorInFileV2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_curators_updateCuratorInFileV2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_curators_updateCuratorInFileV2.Location = new System.Drawing.Point(365, 285);
            this.bn_curators_updateCuratorInFileV2.Name = "bn_curators_updateCuratorInFileV2";
            this.bn_curators_updateCuratorInFileV2.Size = new System.Drawing.Size(236, 36);
            this.bn_curators_updateCuratorInFileV2.TabIndex = 17;
            this.bn_curators_updateCuratorInFileV2.Text = "Update Curator In File V2";
            this.bn_curators_updateCuratorInFileV2.UseVisualStyleBackColor = false;
            this.bn_curators_updateCuratorInFileV2.Click += new System.EventHandler(this.bn_curators_updateCuratorInFileV2_Click);
            // 
            // bn_curators_updateCuratorInFile
            // 
            this.bn_curators_updateCuratorInFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_curators_updateCuratorInFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_curators_updateCuratorInFile.Location = new System.Drawing.Point(81, 285);
            this.bn_curators_updateCuratorInFile.Name = "bn_curators_updateCuratorInFile";
            this.bn_curators_updateCuratorInFile.Size = new System.Drawing.Size(236, 36);
            this.bn_curators_updateCuratorInFile.TabIndex = 16;
            this.bn_curators_updateCuratorInFile.Text = "Update Curator In File";
            this.bn_curators_updateCuratorInFile.UseVisualStyleBackColor = false;
            this.bn_curators_updateCuratorInFile.Click += new System.EventHandler(this.bn_curators_updateCuratorInFile_Click);
            // 
            // bn_curators_appendCuratorInFile
            // 
            this.bn_curators_appendCuratorInFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_curators_appendCuratorInFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_curators_appendCuratorInFile.Location = new System.Drawing.Point(81, 206);
            this.bn_curators_appendCuratorInFile.Name = "bn_curators_appendCuratorInFile";
            this.bn_curators_appendCuratorInFile.Size = new System.Drawing.Size(236, 36);
            this.bn_curators_appendCuratorInFile.TabIndex = 15;
            this.bn_curators_appendCuratorInFile.Text = "Append Curator In File";
            this.bn_curators_appendCuratorInFile.UseVisualStyleBackColor = false;
            this.bn_curators_appendCuratorInFile.Click += new System.EventHandler(this.bn_curators_appendCuratorInFile_Click);
            // 
            // bn_viewCurator
            // 
            this.bn_viewCurator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_viewCurator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_viewCurator.Location = new System.Drawing.Point(459, 235);
            this.bn_viewCurator.Name = "bn_viewCurator";
            this.bn_viewCurator.Size = new System.Drawing.Size(142, 35);
            this.bn_viewCurator.TabIndex = 14;
            this.bn_viewCurator.Text = "View Curators";
            this.bn_viewCurator.UseVisualStyleBackColor = false;
            this.bn_viewCurator.Click += new System.EventHandler(this.bn_viewCurator_Click);
            // 
            // bn_curators_saveCuratorInFile
            // 
            this.bn_curators_saveCuratorInFile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_curators_saveCuratorInFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_curators_saveCuratorInFile.Location = new System.Drawing.Point(81, 340);
            this.bn_curators_saveCuratorInFile.Name = "bn_curators_saveCuratorInFile";
            this.bn_curators_saveCuratorInFile.Size = new System.Drawing.Size(236, 36);
            this.bn_curators_saveCuratorInFile.TabIndex = 13;
            this.bn_curators_saveCuratorInFile.Text = "Save Curators In File";
            this.bn_curators_saveCuratorInFile.UseVisualStyleBackColor = false;
            this.bn_curators_saveCuratorInFile.Click += new System.EventHandler(this.bn_saveCurator_Click);
            // 
            // bn_addCurator
            // 
            this.bn_addCurator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_addCurator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_addCurator.Location = new System.Drawing.Point(459, 179);
            this.bn_addCurator.Name = "bn_addCurator";
            this.bn_addCurator.Size = new System.Drawing.Size(142, 38);
            this.bn_addCurator.TabIndex = 12;
            this.bn_addCurator.Text = "Add Curator";
            this.bn_addCurator.UseVisualStyleBackColor = false;
            this.bn_addCurator.Click += new System.EventHandler(this.bn_addCurator_Click);
            // 
            // txb_curatorID
            // 
            this.txb_curatorID.Location = new System.Drawing.Point(162, 146);
            this.txb_curatorID.Name = "txb_curatorID";
            this.txb_curatorID.Size = new System.Drawing.Size(282, 26);
            this.txb_curatorID.TabIndex = 11;
            // 
            // txb_curator_lname
            // 
            this.txb_curator_lname.Location = new System.Drawing.Point(162, 104);
            this.txb_curator_lname.Name = "txb_curator_lname";
            this.txb_curator_lname.Size = new System.Drawing.Size(282, 26);
            this.txb_curator_lname.TabIndex = 10;
            // 
            // txb_curator_fname
            // 
            this.txb_curator_fname.Location = new System.Drawing.Point(162, 62);
            this.txb_curator_fname.Name = "txb_curator_fname";
            this.txb_curator_fname.Size = new System.Drawing.Size(282, 26);
            this.txb_curator_fname.TabIndex = 9;
            // 
            // lb_curatorID
            // 
            this.lb_curatorID.AutoSize = true;
            this.lb_curatorID.Location = new System.Drawing.Point(35, 152);
            this.lb_curatorID.Name = "lb_curatorID";
            this.lb_curatorID.Size = new System.Drawing.Size(30, 20);
            this.lb_curatorID.TabIndex = 8;
            this.lb_curatorID.Text = "ID:";
            // 
            // lb_curator_lname
            // 
            this.lb_curator_lname.AutoSize = true;
            this.lb_curator_lname.Location = new System.Drawing.Point(35, 107);
            this.lb_curator_lname.Name = "lb_curator_lname";
            this.lb_curator_lname.Size = new System.Drawing.Size(90, 20);
            this.lb_curator_lname.TabIndex = 7;
            this.lb_curator_lname.Text = "Last Name:";
            // 
            // lb_curator_fname
            // 
            this.lb_curator_fname.AutoSize = true;
            this.lb_curator_fname.Location = new System.Drawing.Point(35, 62);
            this.lb_curator_fname.Name = "lb_curator_fname";
            this.lb_curator_fname.Size = new System.Drawing.Size(90, 20);
            this.lb_curator_fname.TabIndex = 6;
            this.lb_curator_fname.Text = "First Name:";
            // 
            // lb_curators_title
            // 
            this.lb_curators_title.AutoSize = true;
            this.lb_curators_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_curators_title.Location = new System.Drawing.Point(30, 20);
            this.lb_curators_title.Name = "lb_curators_title";
            this.lb_curators_title.Size = new System.Drawing.Size(236, 29);
            this.lb_curators_title.TabIndex = 5;
            this.lb_curators_title.Text = "Curator Information";
            // 
            // tabArtists
            // 
            this.tabArtists.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabArtists.Controls.Add(this.bn_artists_saveArtists);
            this.tabArtists.Controls.Add(this.bn_viewArtists);
            this.tabArtists.Controls.Add(this.bn_addArtist);
            this.tabArtists.Controls.Add(this.txb_artistID);
            this.tabArtists.Controls.Add(this.txb_artist_lname);
            this.tabArtists.Controls.Add(this.txb_artist_fname);
            this.tabArtists.Controls.Add(this.lb_artistID);
            this.tabArtists.Controls.Add(this.lb_artist_lname);
            this.tabArtists.Controls.Add(this.lb_artist_fname);
            this.tabArtists.Controls.Add(this.lb_artists_title);
            this.tabArtists.Location = new System.Drawing.Point(4, 29);
            this.tabArtists.Name = "tabArtists";
            this.tabArtists.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtists.Size = new System.Drawing.Size(630, 386);
            this.tabArtists.TabIndex = 1;
            this.tabArtists.Text = "Artists";
            this.tabArtists.Click += new System.EventHandler(this.tabArtists_Click);
            this.tabArtists.MouseHover += new System.EventHandler(this.tabArtists_MouseHover_1);
            // 
            // bn_artists_saveArtists
            // 
            this.bn_artists_saveArtists.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_artists_saveArtists.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_artists_saveArtists.Location = new System.Drawing.Point(459, 309);
            this.bn_artists_saveArtists.Name = "bn_artists_saveArtists";
            this.bn_artists_saveArtists.Size = new System.Drawing.Size(142, 35);
            this.bn_artists_saveArtists.TabIndex = 25;
            this.bn_artists_saveArtists.Text = "Save Artists";
            this.bn_artists_saveArtists.UseVisualStyleBackColor = false;
            this.bn_artists_saveArtists.Click += new System.EventHandler(this.bn_artists_saveArtists_Click);
            // 
            // bn_viewArtists
            // 
            this.bn_viewArtists.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_viewArtists.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_viewArtists.Location = new System.Drawing.Point(459, 247);
            this.bn_viewArtists.Name = "bn_viewArtists";
            this.bn_viewArtists.Size = new System.Drawing.Size(142, 35);
            this.bn_viewArtists.TabIndex = 24;
            this.bn_viewArtists.Text = "View Artists";
            this.bn_viewArtists.UseVisualStyleBackColor = false;
            this.bn_viewArtists.Click += new System.EventHandler(this.bn_viewArtists_Click);
            // 
            // bn_addArtist
            // 
            this.bn_addArtist.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_addArtist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_addArtist.Location = new System.Drawing.Point(459, 185);
            this.bn_addArtist.Name = "bn_addArtist";
            this.bn_addArtist.Size = new System.Drawing.Size(142, 38);
            this.bn_addArtist.TabIndex = 22;
            this.bn_addArtist.Text = "Add Artist";
            this.bn_addArtist.UseVisualStyleBackColor = false;
            this.bn_addArtist.Click += new System.EventHandler(this.bn_addArtist_Click);
            // 
            // txb_artistID
            // 
            this.txb_artistID.Location = new System.Drawing.Point(162, 146);
            this.txb_artistID.Name = "txb_artistID";
            this.txb_artistID.Size = new System.Drawing.Size(282, 26);
            this.txb_artistID.TabIndex = 21;
            // 
            // txb_artist_lname
            // 
            this.txb_artist_lname.Location = new System.Drawing.Point(162, 104);
            this.txb_artist_lname.Name = "txb_artist_lname";
            this.txb_artist_lname.Size = new System.Drawing.Size(282, 26);
            this.txb_artist_lname.TabIndex = 20;
            // 
            // txb_artist_fname
            // 
            this.txb_artist_fname.Location = new System.Drawing.Point(162, 62);
            this.txb_artist_fname.Name = "txb_artist_fname";
            this.txb_artist_fname.Size = new System.Drawing.Size(282, 26);
            this.txb_artist_fname.TabIndex = 19;
            // 
            // lb_artistID
            // 
            this.lb_artistID.AutoSize = true;
            this.lb_artistID.Location = new System.Drawing.Point(35, 152);
            this.lb_artistID.Name = "lb_artistID";
            this.lb_artistID.Size = new System.Drawing.Size(30, 20);
            this.lb_artistID.TabIndex = 18;
            this.lb_artistID.Text = "ID:";
            // 
            // lb_artist_lname
            // 
            this.lb_artist_lname.AutoSize = true;
            this.lb_artist_lname.Location = new System.Drawing.Point(35, 107);
            this.lb_artist_lname.Name = "lb_artist_lname";
            this.lb_artist_lname.Size = new System.Drawing.Size(90, 20);
            this.lb_artist_lname.TabIndex = 17;
            this.lb_artist_lname.Text = "Last Name:";
            // 
            // lb_artist_fname
            // 
            this.lb_artist_fname.AutoSize = true;
            this.lb_artist_fname.Location = new System.Drawing.Point(35, 62);
            this.lb_artist_fname.Name = "lb_artist_fname";
            this.lb_artist_fname.Size = new System.Drawing.Size(90, 20);
            this.lb_artist_fname.TabIndex = 16;
            this.lb_artist_fname.Text = "First Name:";
            // 
            // lb_artists_title
            // 
            this.lb_artists_title.AutoSize = true;
            this.lb_artists_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_artists_title.Location = new System.Drawing.Point(30, 23);
            this.lb_artists_title.Name = "lb_artists_title";
            this.lb_artists_title.Size = new System.Drawing.Size(209, 29);
            this.lb_artists_title.TabIndex = 15;
            this.lb_artists_title.Text = "Artist Information";
            // 
            // tabArtPieces
            // 
            this.tabArtPieces.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabArtPieces.Controls.Add(this.bn_artPiece_saveArtPiece);
            this.tabArtPieces.Controls.Add(this.bn_artPiece_saveArtPieces);
            this.tabArtPieces.Controls.Add(this.bn_addArtPiece);
            this.tabArtPieces.Controls.Add(this.bn_listArtPieces);
            this.tabArtPieces.Controls.Add(this.bn_sellArtpiece);
            this.tabArtPieces.Controls.Add(this.gb_status);
            this.tabArtPieces.Controls.Add(this.txb_artPiece_curatorID);
            this.tabArtPieces.Controls.Add(this.txb_artPiece_artistID);
            this.tabArtPieces.Controls.Add(this.txb_artPiece_value);
            this.tabArtPieces.Controls.Add(this.lb_curator_id);
            this.tabArtPieces.Controls.Add(this.lb_artist_ID);
            this.tabArtPieces.Controls.Add(this.lb_artPiece_value);
            this.tabArtPieces.Controls.Add(this.txb_artPiece_year);
            this.tabArtPieces.Controls.Add(this.txb_artPiece_title);
            this.tabArtPieces.Controls.Add(this.txb_artPiece_pieceID);
            this.tabArtPieces.Controls.Add(this.lb_artPiece_year);
            this.tabArtPieces.Controls.Add(this.lb_artPiece_title);
            this.tabArtPieces.Controls.Add(this.lb_artPieceID);
            this.tabArtPieces.Controls.Add(this.lb_artPiece);
            this.tabArtPieces.Location = new System.Drawing.Point(4, 29);
            this.tabArtPieces.Name = "tabArtPieces";
            this.tabArtPieces.Padding = new System.Windows.Forms.Padding(3);
            this.tabArtPieces.Size = new System.Drawing.Size(630, 386);
            this.tabArtPieces.TabIndex = 2;
            this.tabArtPieces.Text = "Art Pieces";
            this.tabArtPieces.MouseHover += new System.EventHandler(this.tabArtPieces_MouseHover_1);
            // 
            // bn_artPiece_saveArtPiece
            // 
            this.bn_artPiece_saveArtPiece.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_artPiece_saveArtPiece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_artPiece_saveArtPiece.Location = new System.Drawing.Point(23, 322);
            this.bn_artPiece_saveArtPiece.Name = "bn_artPiece_saveArtPiece";
            this.bn_artPiece_saveArtPiece.Size = new System.Drawing.Size(170, 37);
            this.bn_artPiece_saveArtPiece.TabIndex = 40;
            this.bn_artPiece_saveArtPiece.Text = "Save Art Piece";
            this.bn_artPiece_saveArtPiece.UseVisualStyleBackColor = false;
            this.bn_artPiece_saveArtPiece.Click += new System.EventHandler(this.bn_artPiece_saveArtPiece_Click);
            // 
            // bn_artPiece_saveArtPieces
            // 
            this.bn_artPiece_saveArtPieces.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_artPiece_saveArtPieces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_artPiece_saveArtPieces.Location = new System.Drawing.Point(414, 334);
            this.bn_artPiece_saveArtPieces.Name = "bn_artPiece_saveArtPieces";
            this.bn_artPiece_saveArtPieces.Size = new System.Drawing.Size(170, 37);
            this.bn_artPiece_saveArtPieces.TabIndex = 39;
            this.bn_artPiece_saveArtPieces.Text = "Save All Art Pieces";
            this.bn_artPiece_saveArtPieces.UseVisualStyleBackColor = false;
            this.bn_artPiece_saveArtPieces.Click += new System.EventHandler(this.bn_artPiece_saveArtPieces_Click);
            // 
            // bn_addArtPiece
            // 
            this.bn_addArtPiece.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_addArtPiece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_addArtPiece.Location = new System.Drawing.Point(439, 190);
            this.bn_addArtPiece.Name = "bn_addArtPiece";
            this.bn_addArtPiece.Size = new System.Drawing.Size(145, 39);
            this.bn_addArtPiece.TabIndex = 38;
            this.bn_addArtPiece.Text = "Add Art Piece";
            this.bn_addArtPiece.UseVisualStyleBackColor = false;
            this.bn_addArtPiece.Click += new System.EventHandler(this.bn_addArtPiece_Click);
            // 
            // bn_listArtPieces
            // 
            this.bn_listArtPieces.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_listArtPieces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_listArtPieces.Location = new System.Drawing.Point(439, 289);
            this.bn_listArtPieces.Name = "bn_listArtPieces";
            this.bn_listArtPieces.Size = new System.Drawing.Size(145, 39);
            this.bn_listArtPieces.TabIndex = 37;
            this.bn_listArtPieces.Text = "List Art Pieces";
            this.bn_listArtPieces.UseVisualStyleBackColor = false;
            this.bn_listArtPieces.Click += new System.EventHandler(this.bn_listArtPieces_Click);
            // 
            // bn_sellArtpiece
            // 
            this.bn_sellArtpiece.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_sellArtpiece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_sellArtpiece.Location = new System.Drawing.Point(439, 241);
            this.bn_sellArtpiece.Name = "bn_sellArtpiece";
            this.bn_sellArtpiece.Size = new System.Drawing.Size(145, 39);
            this.bn_sellArtpiece.TabIndex = 36;
            this.bn_sellArtpiece.Text = "Sell Art piece";
            this.bn_sellArtpiece.UseVisualStyleBackColor = false;
            this.bn_sellArtpiece.Click += new System.EventHandler(this.bn_sellArtpiece_Click);
            // 
            // gb_status
            // 
            this.gb_status.Controls.Add(this.rb_inStorage);
            this.gb_status.Controls.Add(this.rb_onDisplay);
            this.gb_status.Location = new System.Drawing.Point(384, 67);
            this.gb_status.Name = "gb_status";
            this.gb_status.Size = new System.Drawing.Size(200, 100);
            this.gb_status.TabIndex = 34;
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
            this.rb_onDisplay.CheckedChanged += new System.EventHandler(this.rb_onDisplay_CheckedChanged);
            // 
            // txb_artPiece_curatorID
            // 
            this.txb_artPiece_curatorID.Location = new System.Drawing.Point(158, 235);
            this.txb_artPiece_curatorID.Name = "txb_artPiece_curatorID";
            this.txb_artPiece_curatorID.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_curatorID.TabIndex = 33;
            // 
            // txb_artPiece_artistID
            // 
            this.txb_artPiece_artistID.Location = new System.Drawing.Point(158, 203);
            this.txb_artPiece_artistID.Name = "txb_artPiece_artistID";
            this.txb_artPiece_artistID.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_artistID.TabIndex = 32;
            // 
            // txb_artPiece_value
            // 
            this.txb_artPiece_value.Location = new System.Drawing.Point(158, 169);
            this.txb_artPiece_value.Name = "txb_artPiece_value";
            this.txb_artPiece_value.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_value.TabIndex = 31;
            // 
            // lb_curator_id
            // 
            this.lb_curator_id.AutoSize = true;
            this.lb_curator_id.Location = new System.Drawing.Point(31, 241);
            this.lb_curator_id.Name = "lb_curator_id";
            this.lb_curator_id.Size = new System.Drawing.Size(87, 20);
            this.lb_curator_id.TabIndex = 30;
            this.lb_curator_id.Text = "Curator ID:";
            // 
            // lb_artist_ID
            // 
            this.lb_artist_ID.AutoSize = true;
            this.lb_artist_ID.Location = new System.Drawing.Point(31, 206);
            this.lb_artist_ID.Name = "lb_artist_ID";
            this.lb_artist_ID.Size = new System.Drawing.Size(71, 20);
            this.lb_artist_ID.TabIndex = 29;
            this.lb_artist_ID.Text = "Artist ID:";
            // 
            // lb_artPiece_value
            // 
            this.lb_artPiece_value.AutoSize = true;
            this.lb_artPiece_value.Location = new System.Drawing.Point(31, 169);
            this.lb_artPiece_value.Name = "lb_artPiece_value";
            this.lb_artPiece_value.Size = new System.Drawing.Size(54, 20);
            this.lb_artPiece_value.TabIndex = 28;
            this.lb_artPiece_value.Text = "Value:";
            // 
            // txb_artPiece_year
            // 
            this.txb_artPiece_year.Location = new System.Drawing.Point(158, 132);
            this.txb_artPiece_year.Name = "txb_artPiece_year";
            this.txb_artPiece_year.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_year.TabIndex = 27;
            // 
            // txb_artPiece_title
            // 
            this.txb_artPiece_title.Location = new System.Drawing.Point(158, 100);
            this.txb_artPiece_title.Name = "txb_artPiece_title";
            this.txb_artPiece_title.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_title.TabIndex = 26;
            // 
            // txb_artPiece_pieceID
            // 
            this.txb_artPiece_pieceID.Location = new System.Drawing.Point(158, 66);
            this.txb_artPiece_pieceID.Name = "txb_artPiece_pieceID";
            this.txb_artPiece_pieceID.Size = new System.Drawing.Size(171, 26);
            this.txb_artPiece_pieceID.TabIndex = 25;
            // 
            // lb_artPiece_year
            // 
            this.lb_artPiece_year.AutoSize = true;
            this.lb_artPiece_year.Location = new System.Drawing.Point(31, 138);
            this.lb_artPiece_year.Name = "lb_artPiece_year";
            this.lb_artPiece_year.Size = new System.Drawing.Size(47, 20);
            this.lb_artPiece_year.TabIndex = 24;
            this.lb_artPiece_year.Text = "Year:";
            // 
            // lb_artPiece_title
            // 
            this.lb_artPiece_title.AutoSize = true;
            this.lb_artPiece_title.Location = new System.Drawing.Point(31, 103);
            this.lb_artPiece_title.Name = "lb_artPiece_title";
            this.lb_artPiece_title.Size = new System.Drawing.Size(42, 20);
            this.lb_artPiece_title.TabIndex = 23;
            this.lb_artPiece_title.Text = "Title:";
            // 
            // lb_artPieceID
            // 
            this.lb_artPieceID.AutoSize = true;
            this.lb_artPieceID.Location = new System.Drawing.Point(31, 66);
            this.lb_artPieceID.Name = "lb_artPieceID";
            this.lb_artPieceID.Size = new System.Drawing.Size(30, 20);
            this.lb_artPieceID.TabIndex = 22;
            this.lb_artPieceID.Text = "ID:";
            // 
            // lb_artPiece
            // 
            this.lb_artPiece.AutoSize = true;
            this.lb_artPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_artPiece.Location = new System.Drawing.Point(30, 22);
            this.lb_artPiece.Name = "lb_artPiece";
            this.lb_artPiece.Size = new System.Drawing.Size(256, 29);
            this.lb_artPiece.TabIndex = 16;
            this.lb_artPiece.Text = "Art Piece Information";
            // 
            // bn_close
            // 
            this.bn_close.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_close.Location = new System.Drawing.Point(660, 386);
            this.bn_close.Name = "bn_close";
            this.bn_close.Size = new System.Drawing.Size(120, 41);
            this.bn_close.TabIndex = 15;
            this.bn_close.Text = "close";
            this.bn_close.UseVisualStyleBackColor = false;
            this.bn_close.Click += new System.EventHandler(this.bn_close_Click);
            // 
            // statusStrip_mainForm
            // 
            this.statusStrip_mainForm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip_mainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar,
            this.statusBarLabel,
            this.statusBar_MainForm,
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip_mainForm.Location = new System.Drawing.Point(0, 611);
            this.statusStrip_mainForm.Name = "statusStrip_mainForm";
            this.statusStrip_mainForm.Size = new System.Drawing.Size(792, 22);
            this.statusStrip_mainForm.TabIndex = 17;
            this.statusStrip_mainForm.Text = "statusStrip1";
            this.statusStrip_mainForm.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_mainForm_ItemClicked);
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 15);
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // statusBar_MainForm
            // 
            this.statusBar_MainForm.Name = "statusBar_MainForm";
            this.statusBar_MainForm.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 15);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 15);
            // 
            // rtb_main
            // 
            this.rtb_main.AutoSize = global::CGS_Windows_Form.Properties.Settings.Default.autoSize;
            this.rtb_main.DataBindings.Add(new System.Windows.Forms.Binding("AutoSize", global::CGS_Windows_Form.Properties.Settings.Default, "autoSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rtb_main.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_main.Location = new System.Drawing.Point(12, 437);
            this.rtb_main.Name = "rtb_main";
            this.rtb_main.Size = new System.Drawing.Size(765, 171);
            this.rtb_main.TabIndex = 16;
            this.rtb_main.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(792, 633);
            this.Controls.Add(this.statusStrip_mainForm);
            this.Controls.Add(this.rtb_main);
            this.Controls.Add(this.bn_close);
            this.Controls.Add(this.tab_main);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tab_main.ResumeLayout(false);
            this.tabCurators.ResumeLayout(false);
            this.tabCurators.PerformLayout();
            this.tabArtists.ResumeLayout(false);
            this.tabArtists.PerformLayout();
            this.tabArtPieces.ResumeLayout(false);
            this.tabArtPieces.PerformLayout();
            this.gb_status.ResumeLayout(false);
            this.gb_status.PerformLayout();
            this.statusStrip_mainForm.ResumeLayout(false);
            this.statusStrip_mainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tabCurators;
        private System.Windows.Forms.TabPage tabArtists;
        private System.Windows.Forms.TabPage tabArtPieces;
        private System.Windows.Forms.Button bn_viewCurator;
        private System.Windows.Forms.Button bn_curators_saveCuratorInFile;
        private System.Windows.Forms.Button bn_addCurator;
        private System.Windows.Forms.TextBox txb_curatorID;
        private System.Windows.Forms.TextBox txb_curator_lname;
        private System.Windows.Forms.TextBox txb_curator_fname;
        private System.Windows.Forms.Label lb_curatorID;
        private System.Windows.Forms.Label lb_curator_lname;
        private System.Windows.Forms.Label lb_curator_fname;
        private System.Windows.Forms.Label lb_curators_title;
        private System.Windows.Forms.Button bn_close;
        private System.Windows.Forms.RichTextBox rtb_main;
        private System.Windows.Forms.Button bn_viewArtists;
        private System.Windows.Forms.Button bn_addArtist;
        private System.Windows.Forms.TextBox txb_artistID;
        private System.Windows.Forms.TextBox txb_artist_lname;
        private System.Windows.Forms.TextBox txb_artist_fname;
        private System.Windows.Forms.Label lb_artistID;
        private System.Windows.Forms.Label lb_artist_lname;
        private System.Windows.Forms.Label lb_artist_fname;
        private System.Windows.Forms.Label lb_artists_title;
        private System.Windows.Forms.GroupBox gb_status;
        private System.Windows.Forms.TextBox txb_artPiece_curatorID;
        private System.Windows.Forms.TextBox txb_artPiece_artistID;
        private System.Windows.Forms.TextBox txb_artPiece_value;
        private System.Windows.Forms.Label lb_curator_id;
        private System.Windows.Forms.Label lb_artist_ID;
        private System.Windows.Forms.Label lb_artPiece_value;
        private System.Windows.Forms.TextBox txb_artPiece_year;
        private System.Windows.Forms.TextBox txb_artPiece_title;
        private System.Windows.Forms.TextBox txb_artPiece_pieceID;
        private System.Windows.Forms.Label lb_artPiece_year;
        private System.Windows.Forms.Label lb_artPiece_title;
        private System.Windows.Forms.Label lb_artPieceID;
        private System.Windows.Forms.Label lb_artPiece;
        private System.Windows.Forms.Button bn_listArtPieces;
        private System.Windows.Forms.Button bn_sellArtpiece;
        private System.Windows.Forms.RadioButton rb_inStorage;
        private System.Windows.Forms.RadioButton rb_onDisplay;
        private System.Windows.Forms.Button bn_addArtPiece;
        private System.Windows.Forms.StatusStrip statusStrip_mainForm;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_MainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button bn_artPiece_saveArtPieces;
        private System.Windows.Forms.Button bn_artists_saveArtists;
        private System.Windows.Forms.Button bn_artPiece_saveArtPiece;
        private System.Windows.Forms.Button bn_curators_appendCuratorInFile;
        private System.Windows.Forms.Button bn_curators_updateCuratorInFile;
        private System.Windows.Forms.Button bn_curators_updateCuratorInFileV2;
    }
}