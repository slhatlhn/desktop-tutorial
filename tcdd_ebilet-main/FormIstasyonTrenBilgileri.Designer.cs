namespace zehBet
{
    partial class FormIstasyonTrenBilgileri
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
            this.labelIstasyon = new System.Windows.Forms.Label();
            this.labelTarih = new System.Windows.Forms.Label();
            this.buttonİstasyonTrenBilgileri = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelIstasyon
            // 
            this.labelIstasyon.AutoSize = true;
            this.labelIstasyon.Location = new System.Drawing.Point(27, 17);
            this.labelIstasyon.Name = "labelIstasyon";
            this.labelIstasyon.Size = new System.Drawing.Size(46, 13);
            this.labelIstasyon.TabIndex = 0;
            this.labelIstasyon.Text = "İstasyon";
            // 
            // labelTarih
            // 
            this.labelTarih.AutoSize = true;
            this.labelTarih.Location = new System.Drawing.Point(27, 83);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(31, 13);
            this.labelTarih.TabIndex = 2;
            this.labelTarih.Text = "Tarih";
            // 
            // buttonİstasyonTrenBilgileri
            // 
            this.buttonİstasyonTrenBilgileri.Location = new System.Drawing.Point(30, 165);
            this.buttonİstasyonTrenBilgileri.Name = "buttonİstasyonTrenBilgileri";
            this.buttonİstasyonTrenBilgileri.Size = new System.Drawing.Size(157, 29);
            this.buttonİstasyonTrenBilgileri.TabIndex = 4;
            this.buttonİstasyonTrenBilgileri.Text = "İstasyon-Tren Bilgileri";
            this.buttonİstasyonTrenBilgileri.UseVisualStyleBackColor = true;
            this.buttonİstasyonTrenBilgileri.Click += new System.EventHandler(this.buttonİstasyonTrenBilgileri_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ANKARA GAR ",
            "ERYAMANYHT",
            "SELÇUKLU YHT",
            "ESKİŞEHİR YHT",
            "MERAM YHT",
            "PENDİK YHT",
            "SÖĞUTLÜÇEŞME YHT",
            "BALIKESİR YHT"});
            this.comboBox1.Location = new System.Drawing.Point(30, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // FormIstasyonTrenBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 230);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonİstasyonTrenBilgileri);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.labelIstasyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormIstasyonTrenBilgileri";
            this.Text = "FormIstasyonTrenBilgileri";
            this.Load += new System.EventHandler(this.FormIstasyonTrenBilgileri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIstasyon;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Button buttonİstasyonTrenBilgileri;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}