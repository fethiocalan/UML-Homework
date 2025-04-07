namespace CarProject
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CarPrice = new DevExpress.XtraEditors.TextEdit();
            this.CarColor = new DevExpress.XtraEditors.TextEdit();
            this.CarYear = new DevExpress.XtraEditors.TextEdit();
            this.CarModal = new DevExpress.XtraEditors.TextEdit();
            this.CarBrand = new DevExpress.XtraEditors.TextEdit();
            this.CarImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarModal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 39);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Location = new System.Drawing.Point(1052, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(70, 39);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "X";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 186);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 35);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Brand : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(24, 266);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 35);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Modal : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(26, 361);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(247, 35);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Year of Production :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(26, 449);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(94, 35);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Color : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(27, 546);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(83, 35);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Price : ";
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(916, 591);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(194, 47);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "Add Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.CarImage_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(250, 685);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(193, 45);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(449, 533);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(17, 53);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "$";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(417, 45);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(114, 78);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "THE";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(539, 45);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(146, 78);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "FETH";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(691, 88);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(111, 35);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "Car Place";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CarPrice
            // 
            this.CarPrice.Location = new System.Drawing.Point(177, 533);
            this.CarPrice.Name = "CarPrice";
            this.CarPrice.Properties.Appearance.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarPrice.Properties.Appearance.Options.UseFont = true;
            this.CarPrice.Properties.Padding = new System.Windows.Forms.Padding(1);
            this.CarPrice.Size = new System.Drawing.Size(266, 48);
            this.CarPrice.TabIndex = 14;
            // 
            // CarColor
            // 
            this.CarColor.Location = new System.Drawing.Point(177, 436);
            this.CarColor.Name = "CarColor";
            this.CarColor.Properties.Appearance.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarColor.Properties.Appearance.Options.UseFont = true;
            this.CarColor.Properties.MaxLength = 15;
            this.CarColor.Properties.Padding = new System.Windows.Forms.Padding(1);
            this.CarColor.Size = new System.Drawing.Size(266, 48);
            this.CarColor.TabIndex = 13;
            // 
            // CarYear
            // 
            this.CarYear.Location = new System.Drawing.Point(293, 348);
            this.CarYear.Name = "CarYear";
            this.CarYear.Properties.Appearance.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarYear.Properties.Appearance.Options.UseFont = true;
            this.CarYear.Properties.Appearance.Options.UseTextOptions = true;
            this.CarYear.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.CarYear.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.CarYear.Properties.MaxLength = 4;
            this.CarYear.Properties.Padding = new System.Windows.Forms.Padding(1);
            this.CarYear.Size = new System.Drawing.Size(150, 48);
            this.CarYear.TabIndex = 12;
            // 
            // CarModal
            // 
            this.CarModal.Location = new System.Drawing.Point(177, 259);
            this.CarModal.Name = "CarModal";
            this.CarModal.Properties.Appearance.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarModal.Properties.Appearance.Options.UseFont = true;
            this.CarModal.Properties.MaxLength = 10;
            this.CarModal.Properties.Padding = new System.Windows.Forms.Padding(1);
            this.CarModal.Size = new System.Drawing.Size(266, 48);
            this.CarModal.TabIndex = 11;
            // 
            // CarBrand
            // 
            this.CarBrand.Location = new System.Drawing.Point(177, 179);
            this.CarBrand.Name = "CarBrand";
            this.CarBrand.Properties.Appearance.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarBrand.Properties.Appearance.Options.UseFont = true;
            this.CarBrand.Properties.MaxLength = 15;
            this.CarBrand.Properties.Padding = new System.Windows.Forms.Padding(1);
            this.CarBrand.Size = new System.Drawing.Size(266, 48);
            this.CarBrand.TabIndex = 10;
            // 
            // CarImage
            // 
            this.CarImage.BackgroundImage = global::CarProject.Properties.Resources.No_image;
            this.CarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CarImage.Location = new System.Drawing.Point(578, 223);
            this.CarImage.Name = "CarImage";
            this.CarImage.Size = new System.Drawing.Size(489, 203);
            this.CarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarImage.TabIndex = 2;
            this.CarImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CarProject.Properties.Resources.podiumCar;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(537, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 395);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.simpleButton2);
            this.panel2.Controls.Add(this.labelControl10);
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 601);
            this.panel2.TabIndex = 19;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(265, 122);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(650, 104);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Successfully Added";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe Print", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(386, 303);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(416, 111);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Preview The Car";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(32)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1122, 762);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.CarPrice);
            this.Controls.Add(this.CarColor);
            this.Controls.Add(this.CarYear);
            this.Controls.Add(this.CarModal);
            this.Controls.Add(this.CarBrand);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.CarImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CarPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarModal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox CarImage;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnSubmit;
        private DevExpress.XtraEditors.TextEdit CarBrand;
        private DevExpress.XtraEditors.TextEdit CarModal;
        private DevExpress.XtraEditors.TextEdit CarYear;
        private DevExpress.XtraEditors.TextEdit CarColor;
        private DevExpress.XtraEditors.TextEdit CarPrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}

