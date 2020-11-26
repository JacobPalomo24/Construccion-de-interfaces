namespace contruccion_de_interfaces
{
    partial class DataRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataRegister));
            this.menuBar = new System.Windows.Forms.Panel();
            this.lbl_window_title = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_precipitation = new System.Windows.Forms.Label();
            this.lbl_evaporation = new System.Windows.Forms.Label();
            this.lbl_maximum_temperature = new System.Windows.Forms.Label();
            this.lbl_minimum_temperature = new System.Windows.Forms.Label();
            this.input_id = new System.Windows.Forms.TextBox();
            this.input_precipitation = new System.Windows.Forms.TextBox();
            this.input_evaporation = new System.Windows.Forms.TextBox();
            this.input_maximum_temperature = new System.Windows.Forms.TextBox();
            this.input_minimum_temperature = new System.Windows.Forms.TextBox();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
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
            this.lbl_window_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_window_title.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_window_title.Location = new System.Drawing.Point(12, 14);
            this.lbl_window_title.Name = "lbl_window_title";
            this.lbl_window_title.Size = new System.Drawing.Size(306, 26);
            this.lbl_window_title.TabIndex = 2;
            this.lbl_window_title.Text = "Estación meteorológica - Alta de datos";
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
            this.btn_close.TabIndex = 1;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Poppins Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lbl_title.Location = new System.Drawing.Point(28, 92);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(198, 40);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "ALTA DE DATOS";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_id.ForeColor = System.Drawing.Color.White;
            this.lbl_id.Location = new System.Drawing.Point(337, 142);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(31, 26);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "ID:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(306, 178);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(62, 26);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Fecha:";
            // 
            // lbl_precipitation
            // 
            this.lbl_precipitation.AutoSize = true;
            this.lbl_precipitation.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_precipitation.ForeColor = System.Drawing.Color.White;
            this.lbl_precipitation.Location = new System.Drawing.Point(252, 214);
            this.lbl_precipitation.Name = "lbl_precipitation";
            this.lbl_precipitation.Size = new System.Drawing.Size(116, 26);
            this.lbl_precipitation.TabIndex = 4;
            this.lbl_precipitation.Text = "Precipitación:";
            // 
            // lbl_evaporation
            // 
            this.lbl_evaporation.AutoSize = true;
            this.lbl_evaporation.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_evaporation.ForeColor = System.Drawing.Color.White;
            this.lbl_evaporation.Location = new System.Drawing.Point(256, 250);
            this.lbl_evaporation.Name = "lbl_evaporation";
            this.lbl_evaporation.Size = new System.Drawing.Size(112, 26);
            this.lbl_evaporation.TabIndex = 5;
            this.lbl_evaporation.Text = "Evaporación:";
            // 
            // lbl_maximum_temperature
            // 
            this.lbl_maximum_temperature.AutoSize = true;
            this.lbl_maximum_temperature.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_maximum_temperature.ForeColor = System.Drawing.Color.White;
            this.lbl_maximum_temperature.Location = new System.Drawing.Point(183, 286);
            this.lbl_maximum_temperature.Name = "lbl_maximum_temperature";
            this.lbl_maximum_temperature.Size = new System.Drawing.Size(185, 26);
            this.lbl_maximum_temperature.TabIndex = 6;
            this.lbl_maximum_temperature.Text = "Temperatura máxima:";
            // 
            // lbl_minimum_temperature
            // 
            this.lbl_minimum_temperature.AutoSize = true;
            this.lbl_minimum_temperature.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_minimum_temperature.ForeColor = System.Drawing.Color.White;
            this.lbl_minimum_temperature.Location = new System.Drawing.Point(187, 322);
            this.lbl_minimum_temperature.Name = "lbl_minimum_temperature";
            this.lbl_minimum_temperature.Size = new System.Drawing.Size(181, 26);
            this.lbl_minimum_temperature.TabIndex = 7;
            this.lbl_minimum_temperature.Text = "Temperatura mínima:";
            // 
            // input_id
            // 
            this.input_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.input_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_id.Enabled = false;
            this.input_id.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_id.ForeColor = System.Drawing.Color.White;
            this.input_id.Location = new System.Drawing.Point(374, 141);
            this.input_id.Name = "input_id";
            this.input_id.Size = new System.Drawing.Size(225, 27);
            this.input_id.TabIndex = 8;
            this.input_id.Text = "1";
            // 
            // input_precipitation
            // 
            this.input_precipitation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.input_precipitation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_precipitation.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_precipitation.ForeColor = System.Drawing.Color.White;
            this.input_precipitation.Location = new System.Drawing.Point(374, 214);
            this.input_precipitation.Name = "input_precipitation";
            this.input_precipitation.Size = new System.Drawing.Size(225, 27);
            this.input_precipitation.TabIndex = 10;
            this.input_precipitation.TextChanged += new System.EventHandler(this.input_precipitation_TextChange);
            // 
            // input_evaporation
            // 
            this.input_evaporation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.input_evaporation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_evaporation.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_evaporation.ForeColor = System.Drawing.Color.White;
            this.input_evaporation.Location = new System.Drawing.Point(374, 250);
            this.input_evaporation.Name = "input_evaporation";
            this.input_evaporation.Size = new System.Drawing.Size(225, 27);
            this.input_evaporation.TabIndex = 11;
            this.input_evaporation.TextChanged += new System.EventHandler(this.input_evaporation_TextChange);
            // 
            // input_maximum_temperature
            // 
            this.input_maximum_temperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.input_maximum_temperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_maximum_temperature.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_maximum_temperature.ForeColor = System.Drawing.Color.White;
            this.input_maximum_temperature.Location = new System.Drawing.Point(374, 286);
            this.input_maximum_temperature.Name = "input_maximum_temperature";
            this.input_maximum_temperature.Size = new System.Drawing.Size(225, 27);
            this.input_maximum_temperature.TabIndex = 12;
            this.input_maximum_temperature.TextChanged += new System.EventHandler(this.input_maximum_temperature_TextChange);
            // 
            // input_minimum_temperature
            // 
            this.input_minimum_temperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.input_minimum_temperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_minimum_temperature.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_minimum_temperature.ForeColor = System.Drawing.Color.White;
            this.input_minimum_temperature.Location = new System.Drawing.Point(374, 322);
            this.input_minimum_temperature.Name = "input_minimum_temperature";
            this.input_minimum_temperature.Size = new System.Drawing.Size(225, 27);
            this.input_minimum_temperature.TabIndex = 13;
            this.input_minimum_temperature.TextChanged += new System.EventHandler(this.input_minimum_temperature_TextChange);
            // 
            // date_picker
            // 
            this.date_picker.CalendarFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date_picker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.date_picker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.date_picker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.date_picker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.date_picker.CustomFormat = "dd/mm/yyyy";
            this.date_picker.Enabled = false;
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_picker.Location = new System.Drawing.Point(374, 177);
            this.date_picker.Name = "date_picker";
            this.date_picker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_picker.Size = new System.Drawing.Size(225, 27);
            this.date_picker.TabIndex = 14;
            this.date_picker.Value = new System.DateTime(2020, 11, 25, 0, 0, 0, 0);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(32, 74);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(100, 24);
            this.pic_logo.TabIndex = 15;
            this.pic_logo.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.Enabled = false;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_save.FlatAppearance.BorderSize = 2;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_save.Location = new System.Drawing.Point(274, 375);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(250, 35);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.EnabledChanged += new System.EventHandler(this.btn_save_EnabledChanged);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseEnter += new System.EventHandler(this.btn_save_MouseEnter);
            this.btn_save.MouseLeave += new System.EventHandler(this.btn_save_MouseLeave);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_back.FlatAppearance.BorderSize = 2;
            this.btn_back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(145)))), ((int)(((byte)(0)))));
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_back.Location = new System.Drawing.Point(656, 74);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 35);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "REGRESAR";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseEnter += new System.EventHandler(this.btn_back_MouseEnter);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
            // 
            // DataRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.pic_logo);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.input_minimum_temperature);
            this.Controls.Add(this.input_maximum_temperature);
            this.Controls.Add(this.input_evaporation);
            this.Controls.Add(this.input_precipitation);
            this.Controls.Add(this.input_id);
            this.Controls.Add(this.lbl_minimum_temperature);
            this.Controls.Add(this.lbl_maximum_temperature);
            this.Controls.Add(this.lbl_evaporation);
            this.Controls.Add(this.lbl_precipitation);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estación meteorológica - Alta de datos";
            this.Load += new System.EventHandler(this.DataRegister_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Label lbl_window_title;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_precipitation;
        private System.Windows.Forms.Label lbl_evaporation;
        private System.Windows.Forms.Label lbl_maximum_temperature;
        private System.Windows.Forms.Label lbl_minimum_temperature;
        private System.Windows.Forms.TextBox input_id;
        private System.Windows.Forms.TextBox input_precipitation;
        private System.Windows.Forms.TextBox input_evaporation;
        private System.Windows.Forms.TextBox input_maximum_temperature;
        private System.Windows.Forms.TextBox input_minimum_temperature;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_back;
    }
}