namespace CGS_Windows
{
    partial class Login
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
            this.bn_exit = new System.Windows.Forms.Button();
            this.bn_submit = new System.Windows.Forms.Button();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_username = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_title = new System.Windows.Forms.Label();
            this.bn_login_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bn_exit
            // 
            this.bn_exit.AutoSize = true;
            this.bn_exit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_exit.Location = new System.Drawing.Point(233, 320);
            this.bn_exit.Name = "bn_exit";
            this.bn_exit.Size = new System.Drawing.Size(132, 41);
            this.bn_exit.TabIndex = 13;
            this.bn_exit.Text = "Exit";
            this.bn_exit.UseVisualStyleBackColor = false;
            this.bn_exit.Click += new System.EventHandler(this.bn_exit_Click);
            // 
            // bn_submit
            // 
            this.bn_submit.AllowDrop = true;
            this.bn_submit.AutoEllipsis = true;
            this.bn_submit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_submit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bn_submit.Location = new System.Drawing.Point(84, 320);
            this.bn_submit.Name = "bn_submit";
            this.bn_submit.Size = new System.Drawing.Size(128, 41);
            this.bn_submit.TabIndex = 12;
            this.bn_submit.Text = "Login";
            this.bn_submit.UseVisualStyleBackColor = true;
            this.bn_submit.Click += new System.EventHandler(this.bn_submit_Click);
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(204, 238);
            this.txb_password.Name = "txb_password";
            this.txb_password.PasswordChar = '*';
            this.txb_password.Size = new System.Drawing.Size(161, 26);
            this.txb_password.TabIndex = 11;
            // 
            // txb_username
            // 
            this.txb_username.Location = new System.Drawing.Point(204, 155);
            this.txb_username.Name = "txb_username";
            this.txb_username.Size = new System.Drawing.Size(161, 26);
            this.txb_username.TabIndex = 10;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(79, 239);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(98, 25);
            this.lb_password.TabIndex = 9;
            this.lb_password.Text = "Password";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(79, 155);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(102, 25);
            this.lb_username.TabIndex = 8;
            this.lb_username.Text = "Username";
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(82, 56);
            this.lb_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(283, 60);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Welcome to the \r\nCGS Art Gallery\r\n";
            // 
            // bn_login_register
            // 
            this.bn_login_register.AllowDrop = true;
            this.bn_login_register.AutoEllipsis = true;
            this.bn_login_register.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_login_register.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.bn_login_register.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bn_login_register.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bn_login_register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bn_login_register.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bn_login_register.Location = new System.Drawing.Point(164, 376);
            this.bn_login_register.Name = "bn_login_register";
            this.bn_login_register.Size = new System.Drawing.Size(128, 41);
            this.bn_login_register.TabIndex = 14;
            this.bn_login_register.Text = "Register";
            this.bn_login_register.UseVisualStyleBackColor = true;
            this.bn_login_register.Click += new System.EventHandler(this.bn_login_register_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(462, 441);
            this.Controls.Add(this.bn_login_register);
            this.Controls.Add(this.bn_exit);
            this.Controls.Add(this.bn_submit);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_username);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_title);
            this.Name = "Login";
            this.Text = "testForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bn_exit;
        private System.Windows.Forms.Button bn_submit;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button bn_login_register;
    }
}