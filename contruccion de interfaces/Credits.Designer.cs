namespace contruccion_de_interfaces
{
    partial class Credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credits));
            this.menuBar = new System.Windows.Forms.Panel();
            this.lbl_window_title = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_creator = new System.Windows.Forms.Label();
            this.lbl_expedient_number = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_title_creator = new System.Windows.Forms.Label();
            this.lbl_title_expedient_number = new System.Windows.Forms.Label();
            this.lbl_title_email = new System.Windows.Forms.Label();
            this.btn_okay = new System.Windows.Forms.Button();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.menuBar.Controls.Add(this.lbl_window_title);
            this.menuBar.Controls.Add(this.btn_minimize);
            this.menuBar.Controls.Add(this.btn_close);
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 48);
            this.menuBar.TabIndex = 0;
            this.menuBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseDown);
            this.menuBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseMove);
            this.menuBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuBar_MouseUp);
            // 
            // lbl_window_title
            // 
            this.lbl_window_title.AutoSize = true;
            this.lbl_window_title.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_window_title.Location = new System.Drawing.Point(12, 14);
            this.lbl_window_title.Name = "lbl_window_title";
            this.lbl_window_title.Size = new System.Drawing.Size(76, 26);
            this.lbl_window_title.TabIndex = 1;
            this.lbl_window_title.Text = "Creditos";
            this.lbl_window_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_window_title_MouseDown);
            this.lbl_window_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_window_title_MouseMove);
            this.lbl_window_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_window_title_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimize.Image")));
            this.btn_minimize.Location = new System.Drawing.Point(656, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(72, 48);
            this.btn_minimize.TabIndex = 3;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(728, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(72, 48);
            this.btn_close.TabIndex = 2;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_creator
            // 
            this.lbl_creator.AutoSize = true;
            this.lbl_creator.Font = new System.Drawing.Font("Poppins Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_creator.ForeColor = System.Drawing.Color.White;
            this.lbl_creator.Location = new System.Drawing.Point(274, 122);
            this.lbl_creator.Name = "lbl_creator";
            this.lbl_creator.Size = new System.Drawing.Size(252, 26);
            this.lbl_creator.TabIndex = 1;
            this.lbl_creator.Text = "Jacob Naedh Palomo Martínez";
            // 
            // lbl_expedient_number
            // 
            this.lbl_expedient_number.AutoSize = true;
            this.lbl_expedient_number.Font = new System.Drawing.Font("Poppins Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_expedient_number.ForeColor = System.Drawing.Color.White;
            this.lbl_expedient_number.Location = new System.Drawing.Point(370, 201);
            this.lbl_expedient_number.Name = "lbl_expedient_number";
            this.lbl_expedient_number.Size = new System.Drawing.Size(59, 26);
            this.lbl_expedient_number.TabIndex = 1;
            this.lbl_expedient_number.Text = "297221";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Poppins Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(279, 282);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(241, 26);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "jacob_npm24@outlook.com";
            // 
            // lbl_title_creator
            // 
            this.lbl_title_creator.AutoSize = true;
            this.lbl_title_creator.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_creator.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title_creator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lbl_title_creator.Location = new System.Drawing.Point(329, 85);
            this.lbl_title_creator.Name = "lbl_title_creator";
            this.lbl_title_creator.Size = new System.Drawing.Size(142, 50);
            this.lbl_title_creator.TabIndex = 1;
            this.lbl_title_creator.Text = "Creador";
            // 
            // lbl_title_expedient_number
            // 
            this.lbl_title_expedient_number.AutoSize = true;
            this.lbl_title_expedient_number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_expedient_number.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title_expedient_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lbl_title_expedient_number.Location = new System.Drawing.Point(258, 162);
            this.lbl_title_expedient_number.Name = "lbl_title_expedient_number";
            this.lbl_title_expedient_number.Size = new System.Drawing.Size(283, 50);
            this.lbl_title_expedient_number.TabIndex = 1;
            this.lbl_title_expedient_number.Text = "No. de expediente";
            // 
            // lbl_title_email
            // 
            this.lbl_title_email.AutoSize = true;
            this.lbl_title_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_email.Font = new System.Drawing.Font("Poppins Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lbl_title_email.Location = new System.Drawing.Point(253, 243);
            this.lbl_title_email.Name = "lbl_title_email";
            this.lbl_title_email.Size = new System.Drawing.Size(294, 50);
            this.lbl_title_email.TabIndex = 1;
            this.lbl_title_email.Text = "Correo electrónico";
            // 
            // btn_okay
            // 
            this.btn_okay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_okay.FlatAppearance.BorderSize = 2;
            this.btn_okay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_okay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okay.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_okay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_okay.Location = new System.Drawing.Point(258, 358);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btn_okay.Size = new System.Drawing.Size(283, 48);
            this.btn_okay.TabIndex = 2;
            this.btn_okay.Text = "ACEPTAR";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            this.btn_okay.MouseEnter += new System.EventHandler(this.btn_okay_MouseEnter);
            this.btn_okay.MouseLeave += new System.EventHandler(this.btn_okay_MouseLeave);
            // 
            // Credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_okay);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_expedient_number);
            this.Controls.Add(this.lbl_creator);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.lbl_title_email);
            this.Controls.Add(this.lbl_title_expedient_number);
            this.Controls.Add(this.lbl_title_creator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Credits";
            this.Text = "Credits";
            this.Load += new System.EventHandler(this.Credits_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Label lbl_window_title;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Label lbl_creator;
        private System.Windows.Forms.Label lbl_expedient_number;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_title_creator;
        private System.Windows.Forms.Label lbl_title_expedient_number;
        private System.Windows.Forms.Label lbl_title_email;
        private System.Windows.Forms.Button btn_okay;
    }
}