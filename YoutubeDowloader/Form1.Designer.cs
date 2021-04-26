namespace YoutubeDowloader
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Btn_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Alt = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_Url = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Dowland = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonMp3 = new System.Windows.Forms.RadioButton();
            this.radioButtonMp4 = new System.Windows.Forms.RadioButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbl_durum = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox3);
            this.bunifuGradientPanel1.Controls.Add(this.Btn_Close);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.btn_Alt);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(64)))), ((int)(((byte)(100)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(64)))), ((int)(((byte)(100)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(64)))), ((int)(((byte)(100)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(600, 52);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(80, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Close.Image")));
            this.Btn_Close.ImageActive = null;
            this.Btn_Close.Location = new System.Drawing.Point(566, 9);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(25, 25);
            this.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Close.TabIndex = 8;
            this.Btn_Close.TabStop = false;
            this.Btn_Close.Zoom = 10;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(185, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "YouTube Dowloader";
            // 
            // btn_Alt
            // 
            this.btn_Alt.BackColor = System.Drawing.Color.Transparent;
            this.btn_Alt.Image = ((System.Drawing.Image)(resources.GetObject("btn_Alt.Image")));
            this.btn_Alt.ImageActive = null;
            this.btn_Alt.Location = new System.Drawing.Point(535, 9);
            this.btn_Alt.Name = "btn_Alt";
            this.btn_Alt.Size = new System.Drawing.Size(25, 25);
            this.btn_Alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Alt.TabIndex = 7;
            this.btn_Alt.TabStop = false;
            this.btn_Alt.Zoom = 10;
            this.btn_Alt.Click += new System.EventHandler(this.btn_Alt_Click);
            // 
            // txt_Url
            // 
            this.txt_Url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Url.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Url.ForeColor = System.Drawing.Color.White;
            this.txt_Url.HintForeColor = System.Drawing.Color.White;
            this.txt_Url.HintText = "";
            this.txt_Url.isPassword = false;
            this.txt_Url.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txt_Url.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Url.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txt_Url.LineThickness = 3;
            this.txt_Url.Location = new System.Drawing.Point(111, 116);
            this.txt_Url.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(377, 44);
            this.txt_Url.TabIndex = 2;
            this.txt_Url.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Dowland
            // 
            this.btn_Dowland.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btn_Dowland.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.btn_Dowland.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Dowland.BorderRadius = 0;
            this.btn_Dowland.ButtonText = "Dowland";
            this.btn_Dowland.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dowland.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Dowland.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Dowland.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Dowland.Iconimage")));
            this.btn_Dowland.Iconimage_right = null;
            this.btn_Dowland.Iconimage_right_Selected = null;
            this.btn_Dowland.Iconimage_Selected = null;
            this.btn_Dowland.IconMarginLeft = 0;
            this.btn_Dowland.IconMarginRight = 0;
            this.btn_Dowland.IconRightVisible = true;
            this.btn_Dowland.IconRightZoom = 0D;
            this.btn_Dowland.IconVisible = true;
            this.btn_Dowland.IconZoom = 40D;
            this.btn_Dowland.IsTab = false;
            this.btn_Dowland.Location = new System.Drawing.Point(190, 206);
            this.btn_Dowland.Name = "btn_Dowland";
            this.btn_Dowland.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.btn_Dowland.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.btn_Dowland.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Dowland.selected = false;
            this.btn_Dowland.Size = new System.Drawing.Size(215, 48);
            this.btn_Dowland.TabIndex = 3;
            this.btn_Dowland.Text = "Dowland";
            this.btn_Dowland.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Dowland.Textcolor = System.Drawing.Color.White;
            this.btn_Dowland.TextFont = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Dowland.Click += new System.EventHandler(this.btn_Dowland_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Url";
            // 
            // radioButtonMp3
            // 
            this.radioButtonMp3.AutoSize = true;
            this.radioButtonMp3.Checked = true;
            this.radioButtonMp3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMp3.ForeColor = System.Drawing.Color.White;
            this.radioButtonMp3.Location = new System.Drawing.Point(211, 174);
            this.radioButtonMp3.Name = "radioButtonMp3";
            this.radioButtonMp3.Size = new System.Drawing.Size(51, 22);
            this.radioButtonMp3.TabIndex = 5;
            this.radioButtonMp3.TabStop = true;
            this.radioButtonMp3.Text = "Mp3";
            this.radioButtonMp3.UseVisualStyleBackColor = true;
            this.radioButtonMp3.CheckedChanged += new System.EventHandler(this.radioButtonMp3_CheckedChanged);
            // 
            // radioButtonMp4
            // 
            this.radioButtonMp4.AutoSize = true;
            this.radioButtonMp4.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonMp4.ForeColor = System.Drawing.Color.White;
            this.radioButtonMp4.Location = new System.Drawing.Point(327, 174);
            this.radioButtonMp4.Name = "radioButtonMp4";
            this.radioButtonMp4.Size = new System.Drawing.Size(51, 22);
            this.radioButtonMp4.TabIndex = 6;
            this.radioButtonMp4.Text = "Mp4";
            this.radioButtonMp4.UseVisualStyleBackColor = true;
            this.radioButtonMp4.CheckedChanged += new System.EventHandler(this.radioButtonMp4_CheckedChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.BackColor = System.Drawing.Color.Transparent;
            this.lbl_durum.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_durum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_durum.Location = new System.Drawing.Point(256, 313);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(79, 19);
            this.lbl_durum.TabIndex = 7;
            this.lbl_durum.Text = "Loadıng";
            this.lbl_durum.Visible = false;
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            this.lbl_header.Location = new System.Drawing.Point(0, 93);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(600, 19);
            this.lbl_header.TabIndex = 9;
            this.lbl_header.Text = "______________________________________";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_header.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(262, 260);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(600, 339);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_durum);
            this.Controls.Add(this.radioButtonMp4);
            this.Controls.Add(this.radioButtonMp3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Dowland);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonMp4;
        private System.Windows.Forms.RadioButton radioButtonMp3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Dowland;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Url;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Close;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Alt;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

    }
}

