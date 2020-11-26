namespace contruccion_de_interfaces
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.menuBar = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.lbl_window_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.input_username = new System.Windows.Forms.TextBox();
            this.input_pass = new System.Windows.Forms.TextBox();
            this.input_confirm_pass = new System.Windows.Forms.TextBox();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_confirm_pass = new System.Windows.Forms.Label();
            this.lbl_has_an_account = new System.Windows.Forms.Label();
            this.lnk_lbl_login = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.menuBar.Controls.Add(this.btn_minimize);
            this.menuBar.Controls.Add(this.lbl_window_title);
            this.menuBar.Controls.Add(this.btn_close);
            this.menuBar.Location = new System.Drawing.Point(-1, -1);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(803, 48);
            this.menuBar.TabIndex = 0;
            this.menuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseDown);
            this.menuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseMove);
            this.menuBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(659, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(72, 48);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // lbl_window_title
            // 
            this.lbl_window_title.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lbl_window_title.AutoSize = true;
            this.lbl_window_title.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_window_title.Location = new System.Drawing.Point(13, 13);
            this.lbl_window_title.Name = "lbl_window_title";
            this.lbl_window_title.Size = new System.Drawing.Size(268, 26);
            this.lbl_window_title.TabIndex = 1;
            this.lbl_window_title.Text = "Estación meteorológica - Registro";
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
            this.btn_close.Location = new System.Drawing.Point(731, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(72, 48);
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // input_username
            // 
            this.input_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.input_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_username.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_username.ForeColor = System.Drawing.Color.White;
            this.input_username.Location = new System.Drawing.Point(287, 154);
            this.input_username.Name = "input_username";
            this.input_username.PlaceholderText = "Ingresa un nombre de usuario";
            this.input_username.Size = new System.Drawing.Size(225, 27);
            this.input_username.TabIndex = 1;
            this.input_username.TextChanged += new System.EventHandler(this.input_username_TextChange);
            // 
            // input_pass
            // 
            this.input_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.input_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_pass.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_pass.ForeColor = System.Drawing.Color.White;
            this.input_pass.Location = new System.Drawing.Point(287, 212);
            this.input_pass.Name = "input_pass";
            this.input_pass.PasswordChar = '•';
            this.input_pass.PlaceholderText = "Ingresa una contraseña";
            this.input_pass.Size = new System.Drawing.Size(225, 27);
            this.input_pass.TabIndex = 2;
            this.input_pass.TextChanged += new System.EventHandler(this.input_pass_TextChange);
            // 
            // input_confirm_pass
            // 
            this.input_confirm_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.input_confirm_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_confirm_pass.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_confirm_pass.ForeColor = System.Drawing.Color.White;
            this.input_confirm_pass.Location = new System.Drawing.Point(287, 271);
            this.input_confirm_pass.Name = "input_confirm_pass";
            this.input_confirm_pass.PasswordChar = '•';
            this.input_confirm_pass.PlaceholderText = "Confirma tu contraseña";
            this.input_confirm_pass.Size = new System.Drawing.Size(225, 27);
            this.input_confirm_pass.TabIndex = 3;
            this.input_confirm_pass.TextChanged += new System.EventHandler(this.input_confirm_pass_TextChange);
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_sign_up.Enabled = false;
            this.btn_sign_up.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_sign_up.FlatAppearance.BorderSize = 2;
            this.btn_sign_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_sign_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign_up.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sign_up.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_sign_up.Location = new System.Drawing.Point(287, 305);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(225, 35);
            this.btn_sign_up.TabIndex = 4;
            this.btn_sign_up.Text = "REGISTRARSE";
            this.btn_sign_up.UseVisualStyleBackColor = false;
            this.btn_sign_up.EnabledChanged += new System.EventHandler(this.btn_sign_up_EnabledChange);
            this.btn_sign_up.Click += new System.EventHandler(this.btn_sign_up_Click);
            this.btn_sign_up.MouseEnter += new System.EventHandler(this.btn_sign_up_MouseEnter);
            this.btn_sign_up.MouseLeave += new System.EventHandler(this.btn_sign_up_MouseLeave);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lbl_title.Location = new System.Drawing.Point(326, 89);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(148, 36);
            this.lbl_title.TabIndex = 5;
            this.lbl_title.Text = "REGISTRARSE";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(282, 131);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(76, 25);
            this.lbl_username.TabIndex = 6;
            this.lbl_username.Text = "Usuario:";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_pass.Location = new System.Drawing.Point(282, 189);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(108, 25);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "Contraseña:";
            // 
            // lbl_confirm_pass
            // 
            this.lbl_confirm_pass.AutoSize = true;
            this.lbl_confirm_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_confirm_pass.Font = new System.Drawing.Font("Poppins Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_confirm_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_confirm_pass.Location = new System.Drawing.Point(282, 248);
            this.lbl_confirm_pass.Name = "lbl_confirm_pass";
            this.lbl_confirm_pass.Size = new System.Drawing.Size(181, 25);
            this.lbl_confirm_pass.TabIndex = 8;
            this.lbl_confirm_pass.Text = "Repite la contraseña:";
            // 
            // lbl_has_an_account
            // 
            this.lbl_has_an_account.AutoSize = true;
            this.lbl_has_an_account.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_has_an_account.ForeColor = System.Drawing.Color.White;
            this.lbl_has_an_account.Location = new System.Drawing.Point(322, 354);
            this.lbl_has_an_account.Name = "lbl_has_an_account";
            this.lbl_has_an_account.Size = new System.Drawing.Size(160, 23);
            this.lbl_has_an_account.TabIndex = 9;
            this.lbl_has_an_account.Text = "¿Ya tienes una cuenta?";
            // 
            // lnk_lbl_login
            // 
            this.lnk_lbl_login.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lnk_lbl_login.AutoSize = true;
            this.lnk_lbl_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnk_lbl_login.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lnk_lbl_login.ForeColor = System.Drawing.Color.White;
            this.lnk_lbl_login.LinkColor = System.Drawing.Color.White;
            this.lnk_lbl_login.Location = new System.Drawing.Point(354, 377);
            this.lnk_lbl_login.Name = "lnk_lbl_login";
            this.lnk_lbl_login.Size = new System.Drawing.Size(94, 23);
            this.lnk_lbl_login.TabIndex = 10;
            this.lnk_lbl_login.TabStop = true;
            this.lnk_lbl_login.Text = "Iniciar Sesión";
            this.lnk_lbl_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_lbl_login_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 24);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lnk_lbl_login);
            this.Controls.Add(this.lbl_has_an_account);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_sign_up);
            this.Controls.Add(this.input_confirm_pass);
            this.Controls.Add(this.input_pass);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.lbl_confirm_pass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.signUp_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label lbl_window_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox input_username;
        private System.Windows.Forms.TextBox input_pass;
        private System.Windows.Forms.TextBox input_confirm_pass;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_confirm_pass;
        private System.Windows.Forms.Label lbl_has_an_account;
        private System.Windows.Forms.LinkLabel lnk_lbl_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}