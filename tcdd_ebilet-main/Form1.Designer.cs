namespace zehBet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSag = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonİstasyonTrenBilgileri = new System.Windows.Forms.Button();
            this.buttonÜyeGirisi = new System.Windows.Forms.Button();
            this.buttonBilet = new System.Windows.Forms.Button();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelIletisim = new System.Windows.Forms.Label();
            this.labelEngelsizUlasım = new System.Windows.Forms.Label();
            this.labelAcıkBiletlerim = new System.Windows.Forms.Label();
            this.labelRezervasyonlarım = new System.Windows.Forms.Label();
            this.labelBiletlerim = new System.Windows.Forms.Label();
            this.labelTürkce = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelSag);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonİstasyonTrenBilgileri);
            this.panel1.Controls.Add(this.buttonÜyeGirisi);
            this.panel1.Controls.Add(this.buttonBilet);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(40, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 625);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 623);
            this.panel2.TabIndex = 0;
            // 
            // panelSag
            // 
            this.panelSag.BackColor = System.Drawing.Color.White;
            this.panelSag.ForeColor = System.Drawing.Color.Black;
            this.panelSag.Location = new System.Drawing.Point(640, 110);
            this.panelSag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSag.Name = "panelSag";
            this.panelSag.Size = new System.Drawing.Size(743, 514);
            this.panelSag.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(644, 101);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(675, 1);
            this.panel3.TabIndex = 4;
            // 
            // buttonİstasyonTrenBilgileri
            // 
            this.buttonİstasyonTrenBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonİstasyonTrenBilgileri.ForeColor = System.Drawing.Color.Black;
            this.buttonİstasyonTrenBilgileri.Location = new System.Drawing.Point(923, 39);
            this.buttonİstasyonTrenBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonİstasyonTrenBilgileri.Name = "buttonİstasyonTrenBilgileri";
            this.buttonİstasyonTrenBilgileri.Size = new System.Drawing.Size(240, 38);
            this.buttonİstasyonTrenBilgileri.TabIndex = 3;
            this.buttonİstasyonTrenBilgileri.Text = "İstasyon - Tren Bilgileri";
            this.buttonİstasyonTrenBilgileri.UseVisualStyleBackColor = true;
            this.buttonİstasyonTrenBilgileri.Click += new System.EventHandler(this.buttonİstasyonTrenBilgileri_Click);
            // 
            // buttonÜyeGirisi
            // 
            this.buttonÜyeGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonÜyeGirisi.ForeColor = System.Drawing.Color.Black;
            this.buttonÜyeGirisi.Location = new System.Drawing.Point(789, 39);
            this.buttonÜyeGirisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonÜyeGirisi.Name = "buttonÜyeGirisi";
            this.buttonÜyeGirisi.Size = new System.Drawing.Size(115, 38);
            this.buttonÜyeGirisi.TabIndex = 2;
            this.buttonÜyeGirisi.Text = "Üye Girişi";
            this.buttonÜyeGirisi.UseVisualStyleBackColor = true;
            this.buttonÜyeGirisi.Click += new System.EventHandler(this.buttonÜyeGirisi_Click);
            // 
            // buttonBilet
            // 
            this.buttonBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBilet.ForeColor = System.Drawing.Color.Black;
            this.buttonBilet.Location = new System.Drawing.Point(644, 39);
            this.buttonBilet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBilet.Name = "buttonBilet";
            this.buttonBilet.Size = new System.Drawing.Size(127, 38);
            this.buttonBilet.TabIndex = 1;
            this.buttonBilet.Text = "bilet";
            this.buttonBilet.UseVisualStyleBackColor = true;
            this.buttonBilet.Click += new System.EventHandler(this.buttonBilet_Click);
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnglish.Location = new System.Drawing.Point(1340, 23);
            this.labelEnglish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(74, 25);
            this.labelEnglish.TabIndex = 14;
            this.labelEnglish.Text = "English";
            // 
            // labelIletisim
            // 
            this.labelIletisim.AutoSize = true;
            this.labelIletisim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIletisim.Location = new System.Drawing.Point(1340, 64);
            this.labelIletisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIletisim.Name = "labelIletisim";
            this.labelIletisim.Size = new System.Drawing.Size(74, 25);
            this.labelIletisim.TabIndex = 13;
            this.labelIletisim.Text = "İletişim";
            // 
            // labelEngelsizUlasım
            // 
            this.labelEngelsizUlasım.AutoSize = true;
            this.labelEngelsizUlasım.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEngelsizUlasım.Location = new System.Drawing.Point(1173, 64);
            this.labelEngelsizUlasım.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEngelsizUlasım.Name = "labelEngelsizUlasım";
            this.labelEngelsizUlasım.Size = new System.Drawing.Size(147, 25);
            this.labelEngelsizUlasım.TabIndex = 12;
            this.labelEngelsizUlasım.Text = "Engelsiz Ulaşım";
            // 
            // labelAcıkBiletlerim
            // 
            this.labelAcıkBiletlerim.AutoSize = true;
            this.labelAcıkBiletlerim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcıkBiletlerim.Location = new System.Drawing.Point(1020, 64);
            this.labelAcıkBiletlerim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAcıkBiletlerim.Name = "labelAcıkBiletlerim";
            this.labelAcıkBiletlerim.Size = new System.Drawing.Size(136, 25);
            this.labelAcıkBiletlerim.TabIndex = 11;
            this.labelAcıkBiletlerim.Text = "Açık Biletlerim";
            // 
            // labelRezervasyonlarım
            // 
            this.labelRezervasyonlarım.AutoSize = true;
            this.labelRezervasyonlarım.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezervasyonlarım.Location = new System.Drawing.Point(833, 64);
            this.labelRezervasyonlarım.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRezervasyonlarım.Name = "labelRezervasyonlarım";
            this.labelRezervasyonlarım.Size = new System.Drawing.Size(165, 25);
            this.labelRezervasyonlarım.TabIndex = 10;
            this.labelRezervasyonlarım.Text = "Rezervasyonlarım";
            // 
            // labelBiletlerim
            // 
            this.labelBiletlerim.AutoSize = true;
            this.labelBiletlerim.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBiletlerim.Location = new System.Drawing.Point(724, 64);
            this.labelBiletlerim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBiletlerim.Name = "labelBiletlerim";
            this.labelBiletlerim.Size = new System.Drawing.Size(94, 25);
            this.labelBiletlerim.TabIndex = 9;
            this.labelBiletlerim.Text = "Biletlerim";
            // 
            // labelTürkce
            // 
            this.labelTürkce.AutoSize = true;
            this.labelTürkce.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTürkce.Location = new System.Drawing.Point(1244, 23);
            this.labelTürkce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTürkce.Name = "labelTürkce";
            this.labelTürkce.Size = new System.Drawing.Size(69, 25);
            this.labelTürkce.TabIndex = 8;
            this.labelTürkce.Text = "Türkçe";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "abc.png");
            this.ımageList1.Images.SetKeyName(1, "12501-NOAIN2.jpg");
            this.ımageList1.Images.SetKeyName(2, "def.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1501, 839);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.labelIletisim);
            this.Controls.Add(this.labelEngelsizUlasım);
            this.Controls.Add(this.labelAcıkBiletlerim);
            this.Controls.Add(this.labelRezervasyonlarım);
            this.Controls.Add(this.labelBiletlerim);
            this.Controls.Add(this.labelTürkce);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelIletisim;
        private System.Windows.Forms.Label labelEngelsizUlasım;
        private System.Windows.Forms.Label labelAcıkBiletlerim;
        private System.Windows.Forms.Label labelRezervasyonlarım;
        private System.Windows.Forms.Label labelBiletlerim;
        private System.Windows.Forms.Label labelTürkce;
        private System.Windows.Forms.Button buttonİstasyonTrenBilgileri;
        private System.Windows.Forms.Button buttonÜyeGirisi;
        private System.Windows.Forms.Button buttonBilet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelSag;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

