namespace CGS_Windows_Form
{
    partial class CuratorSql
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
            this.bn_addCurator = new System.Windows.Forms.Button();
            this.txb_curator_Id = new System.Windows.Forms.TextBox();
            this.txb_curator_lname = new System.Windows.Forms.TextBox();
            this.txb_curator_fname = new System.Windows.Forms.TextBox();
            this.lb_curator_Id = new System.Windows.Forms.Label();
            this.lb_curator_lname = new System.Windows.Forms.Label();
            this.lb_curator_fname = new System.Windows.Forms.Label();
            this.lb_curators_title = new System.Windows.Forms.Label();
            this.bn_cancel = new System.Windows.Forms.Button();
            this.txb_curator_commission = new System.Windows.Forms.TextBox();
            this.lb_curator_commission = new System.Windows.Forms.Label();
            this.dgv_curator = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_Artist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Artist)).BeginInit();
            this.SuspendLayout();
            // 
            // bn_addCurator
            // 
            this.bn_addCurator.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_addCurator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_addCurator.Location = new System.Drawing.Point(88, 280);
            this.bn_addCurator.Name = "bn_addCurator";
            this.bn_addCurator.Size = new System.Drawing.Size(142, 38);
            this.bn_addCurator.TabIndex = 23;
            this.bn_addCurator.Text = "Add Curator";
            this.bn_addCurator.UseVisualStyleBackColor = false;
            this.bn_addCurator.Click += new System.EventHandler(this.bn_addCurator_Click);
            // 
            // txb_curator_Id
            // 
            this.txb_curator_Id.Location = new System.Drawing.Point(215, 183);
            this.txb_curator_Id.Name = "txb_curator_Id";
            this.txb_curator_Id.Size = new System.Drawing.Size(282, 26);
            this.txb_curator_Id.TabIndex = 22;
            // 
            // txb_curator_lname
            // 
            this.txb_curator_lname.Location = new System.Drawing.Point(215, 141);
            this.txb_curator_lname.Name = "txb_curator_lname";
            this.txb_curator_lname.Size = new System.Drawing.Size(282, 26);
            this.txb_curator_lname.TabIndex = 21;
            // 
            // txb_curator_fname
            // 
            this.txb_curator_fname.Location = new System.Drawing.Point(215, 99);
            this.txb_curator_fname.Name = "txb_curator_fname";
            this.txb_curator_fname.Size = new System.Drawing.Size(282, 26);
            this.txb_curator_fname.TabIndex = 20;
            // 
            // lb_curator_Id
            // 
            this.lb_curator_Id.AutoSize = true;
            this.lb_curator_Id.Location = new System.Drawing.Point(88, 189);
            this.lb_curator_Id.Name = "lb_curator_Id";
            this.lb_curator_Id.Size = new System.Drawing.Size(30, 20);
            this.lb_curator_Id.TabIndex = 19;
            this.lb_curator_Id.Text = "ID:";
            // 
            // lb_curator_lname
            // 
            this.lb_curator_lname.AutoSize = true;
            this.lb_curator_lname.Location = new System.Drawing.Point(88, 144);
            this.lb_curator_lname.Name = "lb_curator_lname";
            this.lb_curator_lname.Size = new System.Drawing.Size(90, 20);
            this.lb_curator_lname.TabIndex = 18;
            this.lb_curator_lname.Text = "Last Name:";
            // 
            // lb_curator_fname
            // 
            this.lb_curator_fname.AutoSize = true;
            this.lb_curator_fname.Location = new System.Drawing.Point(88, 99);
            this.lb_curator_fname.Name = "lb_curator_fname";
            this.lb_curator_fname.Size = new System.Drawing.Size(90, 20);
            this.lb_curator_fname.TabIndex = 17;
            this.lb_curator_fname.Text = "First Name:";
            // 
            // lb_curators_title
            // 
            this.lb_curators_title.AutoSize = true;
            this.lb_curators_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_curators_title.Location = new System.Drawing.Point(83, 57);
            this.lb_curators_title.Name = "lb_curators_title";
            this.lb_curators_title.Size = new System.Drawing.Size(236, 29);
            this.lb_curators_title.TabIndex = 16;
            this.lb_curators_title.Text = "Curator Information";
            // 
            // bn_cancel
            // 
            this.bn_cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_cancel.Location = new System.Drawing.Point(355, 280);
            this.bn_cancel.Name = "bn_cancel";
            this.bn_cancel.Size = new System.Drawing.Size(142, 38);
            this.bn_cancel.TabIndex = 24;
            this.bn_cancel.Text = "Cancel";
            this.bn_cancel.UseVisualStyleBackColor = false;
            this.bn_cancel.Click += new System.EventHandler(this.bn_cancel_Click);
            // 
            // txb_curator_commission
            // 
            this.txb_curator_commission.Location = new System.Drawing.Point(215, 227);
            this.txb_curator_commission.Name = "txb_curator_commission";
            this.txb_curator_commission.Size = new System.Drawing.Size(282, 26);
            this.txb_curator_commission.TabIndex = 26;
            // 
            // lb_curator_commission
            // 
            this.lb_curator_commission.AutoSize = true;
            this.lb_curator_commission.Location = new System.Drawing.Point(88, 233);
            this.lb_curator_commission.Name = "lb_curator_commission";
            this.lb_curator_commission.Size = new System.Drawing.Size(103, 20);
            this.lb_curator_commission.TabIndex = 25;
            this.lb_curator_commission.Text = "Commisssion";
            // 
            // dgv_curator
            // 
            this.dgv_curator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_curator.Location = new System.Drawing.Point(88, 335);
            this.dgv_curator.Name = "dgv_curator";
            this.dgv_curator.RowHeadersWidth = 62;
            this.dgv_curator.RowTemplate.Height = 28;
            this.dgv_curator.Size = new System.Drawing.Size(611, 227);
            this.dgv_curator.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_Artist
            // 
            this.dgv_Artist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Artist.Location = new System.Drawing.Point(750, 280);
            this.dgv_Artist.Name = "dgv_Artist";
            this.dgv_Artist.RowHeadersWidth = 62;
            this.dgv_Artist.RowTemplate.Height = 28;
            this.dgv_Artist.Size = new System.Drawing.Size(588, 265);
            this.dgv_Artist.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Artist DGV:";
            // 
            // CuratorSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 574);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Artist);
            this.Controls.Add(this.dgv_curator);
            this.Controls.Add(this.txb_curator_commission);
            this.Controls.Add(this.lb_curator_commission);
            this.Controls.Add(this.bn_cancel);
            this.Controls.Add(this.bn_addCurator);
            this.Controls.Add(this.txb_curator_Id);
            this.Controls.Add(this.txb_curator_lname);
            this.Controls.Add(this.txb_curator_fname);
            this.Controls.Add(this.lb_curator_Id);
            this.Controls.Add(this.lb_curator_lname);
            this.Controls.Add(this.lb_curator_fname);
            this.Controls.Add(this.lb_curators_title);
            this.Name = "CuratorSql";
            this.Text = "CuratorSql";
            this.Load += new System.EventHandler(this.CuratorSql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_curator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Artist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bn_addCurator;
        private System.Windows.Forms.TextBox txb_curator_Id;
        private System.Windows.Forms.TextBox txb_curator_lname;
        private System.Windows.Forms.TextBox txb_curator_fname;
        private System.Windows.Forms.Label lb_curator_Id;
        private System.Windows.Forms.Label lb_curator_lname;
        private System.Windows.Forms.Label lb_curator_fname;
        private System.Windows.Forms.Label lb_curators_title;
        private System.Windows.Forms.Button bn_cancel;
        private System.Windows.Forms.TextBox txb_curator_commission;
        private System.Windows.Forms.Label lb_curator_commission;
        private System.Windows.Forms.DataGridView dgv_curator;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_Artist;
        private System.Windows.Forms.Label label1;
    }
}