namespace CGS_Windows_Form
{
    partial class loginSql
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
            this.bn_login_cancel = new System.Windows.Forms.Button();
            this.bn_login_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bn_login_cancel
            // 
            this.bn_login_cancel.AutoSize = true;
            this.bn_login_cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_login_cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_login_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bn_login_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bn_login_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_login_cancel.Location = new System.Drawing.Point(411, 309);
            this.bn_login_cancel.Name = "bn_login_cancel";
            this.bn_login_cancel.Size = new System.Drawing.Size(132, 41);
            this.bn_login_cancel.TabIndex = 21;
            this.bn_login_cancel.Text = "Exit";
            this.bn_login_cancel.UseVisualStyleBackColor = false;
            this.bn_login_cancel.Click += new System.EventHandler(this.bn_login_cancel_Click);
            // 
            // bn_login_login
            // 
            this.bn_login_login.AllowDrop = true;
            this.bn_login_login.AutoEllipsis = true;
            this.bn_login_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_login_login.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_login_login.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bn_login_login.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bn_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_login_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bn_login_login.Location = new System.Drawing.Point(262, 309);
            this.bn_login_login.Name = "bn_login_login";
            this.bn_login_login.Size = new System.Drawing.Size(128, 41);
            this.bn_login_login.TabIndex = 20;
            this.bn_login_login.Text = "Login";
            this.bn_login_login.UseVisualStyleBackColor = true;
            this.bn_login_login.Click += new System.EventHandler(this.bn_login_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(382, 227);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(161, 26);
            this.tb_password.TabIndex = 19;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(382, 144);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(161, 26);
            this.tb_username.TabIndex = 18;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(257, 228);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(98, 25);
            this.lb_password.TabIndex = 17;
            this.lb_password.Text = "Password";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(257, 144);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(102, 25);
            this.lb_username.TabIndex = 16;
            this.lb_username.Text = "Username";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(260, 45);
            this.lb_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(283, 60);
            this.lb_title.TabIndex = 15;
            this.lb_title.Text = "Welcome to the \r\nCGS Art Gallery\r\n";
            // 
            // loginSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bn_login_cancel);
            this.Controls.Add(this.bn_login_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_title);
            this.Name = "loginSql";
            this.Text = "loginSql";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bn_login_cancel;
        private System.Windows.Forms.Button bn_login_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_title;
    }
}