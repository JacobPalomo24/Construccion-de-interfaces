namespace contruccion_de_interfaces
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.input_username = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_input_username = new System.Windows.Forms.Label();
            this.lbl_input_password = new System.Windows.Forms.Label();
            this.input_password = new System.Windows.Forms.TextBox();
            this.lbl_not_account = new System.Windows.Forms.Label();
            this.link_sign_up = new System.Windows.Forms.LinkLabel();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_window_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.input_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_username.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_username.ForeColor = System.Drawing.Color.White;
            this.input_username.Location = new System.Drawing.Point(296, 182);
            this.input_username.Margin = new System.Windows.Forms.Padding(3, 3, 3, 16);
            this.input_username.MaximumSize = new System.Drawing.Size(225, 27);
            this.input_username.MinimumSize = new System.Drawing.Size(225, 27);
            this.input_username.Name = "input_username";
            this.input_username.PlaceholderText = "Ingresa tu nombre de usuario";
            this.input_username.Size = new System.Drawing.Size(225, 27);
            this.input_username.TabIndex = 0;
            this.input_username.TextChanged += new System.EventHandler(this.input_username_TextChange);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Poppins Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lbl_title.Location = new System.Drawing.Point(324, 111);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(3, 0, 3, 16);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(170, 36);
            this.lbl_title.TabIndex = 2;
            this.lbl_title.Text = "INICIAR SESIÓN";
            // 
            // lbl_input_username
            // 
            this.lbl_input_username.AutoSize = true;
            this.lbl_input_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_input_username.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_input_username.ForeColor = System.Drawing.Color.White;
            this.lbl_input_username.Location = new System.Drawing.Point(296, 160);
            this.lbl_input_username.Name = "lbl_input_username";
            this.lbl_input_username.Size = new System.Drawing.Size(76, 25);
            this.lbl_input_username.TabIndex = 3;
            this.lbl_input_username.Text = "Usuario:";
            // 
            // lbl_input_password
            // 
            this.lbl_input_password.AutoSize = true;
            this.lbl_input_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_input_password.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_input_password.ForeColor = System.Drawing.Color.White;
            this.lbl_input_password.Location = new System.Drawing.Point(292, 221);
            this.lbl_input_password.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_input_password.Name = "lbl_input_password";
            this.lbl_input_password.Size = new System.Drawing.Size(108, 25);
            this.lbl_input_password.TabIndex = 4;
            this.lbl_input_password.Text = "Contraseña:";
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_password.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_password.ForeColor = System.Drawing.Color.White;
            this.input_password.Location = new System.Drawing.Point(296, 243);
            this.input_password.MaximumSize = new System.Drawing.Size(225, 27);
            this.input_password.MinimumSize = new System.Drawing.Size(225, 27);
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '•';
            this.input_password.PlaceholderText = "Ingresa tu contraseña";
            this.input_password.Size = new System.Drawing.Size(225, 27);
            this.input_password.TabIndex = 5;
            this.input_password.TextChanged += new System.EventHandler(this.input_password_TextChange);
            // 
            // lbl_not_account
            // 
            this.lbl_not_account.AutoSize = true;
            this.lbl_not_account.BackColor = System.Drawing.Color.Transparent;
            this.lbl_not_account.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_not_account.ForeColor = System.Drawing.Color.White;
            this.lbl_not_account.Location = new System.Drawing.Point(321, 324);
            this.lbl_not_account.Name = "lbl_not_account";
            this.lbl_not_account.Size = new System.Drawing.Size(176, 25);
            this.lbl_not_account.TabIndex = 6;
            this.lbl_not_account.Text = "¿No tienes una cuenta?";
            // 
            // link_sign_up
            // 
            this.link_sign_up.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.link_sign_up.AutoSize = true;
            this.link_sign_up.BackColor = System.Drawing.Color.Transparent;
            this.link_sign_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_sign_up.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.link_sign_up.LinkColor = System.Drawing.Color.White;
            this.link_sign_up.Location = new System.Drawing.Point(365, 349);
            this.link_sign_up.Name = "link_sign_up";
            this.link_sign_up.Size = new System.Drawing.Size(87, 26);
            this.link_sign_up.TabIndex = 7;
            this.link_sign_up.TabStop = true;
            this.link_sign_up.Text = "Regístrate";
            this.link_sign_up.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_sign_up_LinkClicked);
            // 
            // btn_login
            // 
            this.btn_login.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.Enabled = false;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_login.FlatAppearance.BorderSize = 2;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_login.Location = new System.Drawing.Point(296, 285);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(225, 35);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "ENTRAR";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.EnabledChanged += new System.EventHandler(this.btn_login_EnabledChange);
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.MouseEnter += new System.EventHandler(this.btn_login_MouseEnter);
            this.btn_login.MouseLeave += new System.EventHandler(this.btn_login_MouseLeave);
            // 
            // lbl_window_title
            // 
            this.lbl_window_title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_window_title.AutoSize = true;
            this.lbl_window_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lbl_window_title.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_window_title.Location = new System.Drawing.Point(18, 13);
            this.lbl_window_title.Name = "lbl_window_title";
            this.lbl_window_title.Size = new System.Drawing.Size(307, 26);
            this.lbl_window_title.TabIndex = 10;
            this.lbl_window_title.Text = "Estación meteorológica - Iniciar sesión";
            this.lbl_window_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_window_title_MouseDown);
            this.lbl_window_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_window_title_MouseMove);
            this.lbl_window_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_window_title_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(729, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(72, 48);
            this.btn_close.TabIndex = 11;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(657, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(72, 48);
            this.btn_minimize.TabIndex = 12;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.menuBar.Controls.Add(this.btn_minimize);
            this.menuBar.Controls.Add(this.btn_close);
            this.menuBar.Controls.Add(this.lbl_window_title);
            this.menuBar.Location = new System.Drawing.Point(-1, -1);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(803, 48);
            this.menuBar.TabIndex = 13;
            this.menuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseDown);
            this.menuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseMove);
            this.menuBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 24);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.link_sign_up);
            this.Controls.Add(this.lbl_not_account);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.lbl_input_password);
            this.Controls.Add(this.lbl_input_username);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estación climatológica - Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_input_username;
        private System.Windows.Forms.Label lbl_input_password;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label lbl_not_account;
        private System.Windows.Forms.LinkLabel link_sign_up;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_window_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

