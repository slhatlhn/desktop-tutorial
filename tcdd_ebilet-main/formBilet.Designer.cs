namespace zehBet
{
    partial class formBilet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBilet));
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelDönüsTarihi = new System.Windows.Forms.Label();
            this.labelNereye = new System.Windows.Forms.Label();
            this.labelGidisDönüs = new System.Windows.Forms.Label();
            this.labelTekYön = new System.Windows.Forms.Label();
            this.radioButtonGidisDönüs = new System.Windows.Forms.RadioButton();
            this.radioButtonTekYön = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSatıs = new System.Windows.Forms.Label();
            this.labelRezervasyon = new System.Windows.Forms.Label();
            this.radioButtonSatıs = new System.Windows.Forms.RadioButton();
            this.radioButtonRezervasyon = new System.Windows.Forms.RadioButton();
            this.btnAra = new System.Windows.Forms.Button();
            this.labelYolcuSayısı = new System.Windows.Forms.Label();
            this.labelGidisTarihi = new System.Windows.Forms.Label();
            this.labelNereden = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePickerDonus = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGidis = new System.Windows.Forms.DateTimePicker();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dateTimePickerDonus);
            this.panel5.Controls.Add(this.comboBox2);
            this.panel5.Controls.Add(this.labelDönüsTarihi);
            this.panel5.Controls.Add(this.labelNereye);
            this.panel5.Controls.Add(this.labelGidisDönüs);
            this.panel5.Controls.Add(this.labelTekYön);
            this.panel5.Controls.Add(this.radioButtonGidisDönüs);
            this.panel5.Controls.Add(this.radioButtonTekYön);
            this.panel5.Location = new System.Drawing.Point(270, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 352);
            this.panel5.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Konya",
            "Balıkesir",
            "Eskişehir"});
            this.comboBox2.Location = new System.Drawing.Point(17, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // labelDönüsTarihi
            // 
            this.labelDönüsTarihi.AutoSize = true;
            this.labelDönüsTarihi.Location = new System.Drawing.Point(14, 128);
            this.labelDönüsTarihi.Name = "labelDönüsTarihi";
            this.labelDönüsTarihi.Size = new System.Drawing.Size(67, 13);
            this.labelDönüsTarihi.TabIndex = 7;
            this.labelDönüsTarihi.Text = "Dönüş Tarihi";
            // 
            // labelNereye
            // 
            this.labelNereye.AutoSize = true;
            this.labelNereye.Location = new System.Drawing.Point(14, 64);
            this.labelNereye.Name = "labelNereye";
            this.labelNereye.Size = new System.Drawing.Size(41, 13);
            this.labelNereye.TabIndex = 5;
            this.labelNereye.Text = "Nereye";
            // 
            // labelGidisDönüs
            // 
            this.labelGidisDönüs.AutoSize = true;
            this.labelGidisDönüs.Location = new System.Drawing.Point(138, 24);
            this.labelGidisDönüs.Name = "labelGidisDönüs";
            this.labelGidisDönüs.Size = new System.Drawing.Size(64, 13);
            this.labelGidisDönüs.TabIndex = 4;
            this.labelGidisDönüs.Text = "Gidiş-Dönüş";
            // 
            // labelTekYön
            // 
            this.labelTekYön.AutoSize = true;
            this.labelTekYön.Location = new System.Drawing.Point(39, 24);
            this.labelTekYön.Name = "labelTekYön";
            this.labelTekYön.Size = new System.Drawing.Size(48, 13);
            this.labelTekYön.TabIndex = 3;
            this.labelTekYön.Text = "Tek Yön";
            // 
            // radioButtonGidisDönüs
            // 
            this.radioButtonGidisDönüs.AutoSize = true;
            this.radioButtonGidisDönüs.Location = new System.Drawing.Point(109, 24);
            this.radioButtonGidisDönüs.Name = "radioButtonGidisDönüs";
            this.radioButtonGidisDönüs.Size = new System.Drawing.Size(14, 13);
            this.radioButtonGidisDönüs.TabIndex = 2;
            this.radioButtonGidisDönüs.TabStop = true;
            this.radioButtonGidisDönüs.UseVisualStyleBackColor = true;
            // 
            // radioButtonTekYön
            // 
            this.radioButtonTekYön.AutoSize = true;
            this.radioButtonTekYön.Location = new System.Drawing.Point(17, 24);
            this.radioButtonTekYön.Name = "radioButtonTekYön";
            this.radioButtonTekYön.Size = new System.Drawing.Size(14, 13);
            this.radioButtonTekYön.TabIndex = 1;
            this.radioButtonTekYön.TabStop = true;
            this.radioButtonTekYön.UseVisualStyleBackColor = true;
            this.radioButtonTekYön.CheckedChanged += new System.EventHandler(this.radioButtonTekYön_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePickerGidis);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.labelSatıs);
            this.panel4.Controls.Add(this.labelRezervasyon);
            this.panel4.Controls.Add(this.radioButtonSatıs);
            this.panel4.Controls.Add(this.radioButtonRezervasyon);
            this.panel4.Controls.Add(this.btnAra);
            this.panel4.Controls.Add(this.labelYolcuSayısı);
            this.panel4.Controls.Add(this.labelGidisTarihi);
            this.panel4.Controls.Add(this.labelNereden);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(6, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 352);
            this.panel4.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 225);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Konya",
            "Balıkesir",
            "Eskişehir"});
            this.comboBox1.Location = new System.Drawing.Point(6, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // labelSatıs
            // 
            this.labelSatıs.AutoSize = true;
            this.labelSatıs.Location = new System.Drawing.Point(35, 20);
            this.labelSatıs.Name = "labelSatıs";
            this.labelSatıs.Size = new System.Drawing.Size(30, 13);
            this.labelSatıs.TabIndex = 11;
            this.labelSatıs.Text = "Satış";
            // 
            // labelRezervasyon
            // 
            this.labelRezervasyon.AutoSize = true;
            this.labelRezervasyon.Location = new System.Drawing.Point(147, 20);
            this.labelRezervasyon.Name = "labelRezervasyon";
            this.labelRezervasyon.Size = new System.Drawing.Size(69, 13);
            this.labelRezervasyon.TabIndex = 2;
            this.labelRezervasyon.Text = "Rezervasyon";
            // 
            // radioButtonSatıs
            // 
            this.radioButtonSatıs.AutoSize = true;
            this.radioButtonSatıs.Location = new System.Drawing.Point(14, 20);
            this.radioButtonSatıs.Name = "radioButtonSatıs";
            this.radioButtonSatıs.Size = new System.Drawing.Size(14, 13);
            this.radioButtonSatıs.TabIndex = 0;
            this.radioButtonSatıs.TabStop = true;
            this.radioButtonSatıs.UseVisualStyleBackColor = true;
            // 
            // radioButtonRezervasyon
            // 
            this.radioButtonRezervasyon.AutoSize = true;
            this.radioButtonRezervasyon.Location = new System.Drawing.Point(127, 20);
            this.radioButtonRezervasyon.Name = "radioButtonRezervasyon";
            this.radioButtonRezervasyon.Size = new System.Drawing.Size(14, 13);
            this.radioButtonRezervasyon.TabIndex = 1;
            this.radioButtonRezervasyon.TabStop = true;
            this.radioButtonRezervasyon.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(14, 261);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // labelYolcuSayısı
            // 
            this.labelYolcuSayısı.AutoSize = true;
            this.labelYolcuSayısı.Location = new System.Drawing.Point(17, 196);
            this.labelYolcuSayısı.Name = "labelYolcuSayısı";
            this.labelYolcuSayısı.Size = new System.Drawing.Size(64, 13);
            this.labelYolcuSayısı.TabIndex = 8;
            this.labelYolcuSayısı.Text = "Yolcu Sayısı";
            // 
            // labelGidisTarihi
            // 
            this.labelGidisTarihi.AutoSize = true;
            this.labelGidisTarihi.Location = new System.Drawing.Point(17, 128);
            this.labelGidisTarihi.Name = "labelGidisTarihi";
            this.labelGidisTarihi.Size = new System.Drawing.Size(59, 13);
            this.labelGidisTarihi.TabIndex = 6;
            this.labelGidisTarihi.Text = "Gidiş Tarihi";
            // 
            // labelNereden
            // 
            this.labelNereden.AutoSize = true;
            this.labelNereden.Location = new System.Drawing.Point(17, 64);
            this.labelNereden.Name = "labelNereden";
            this.labelNereden.Size = new System.Drawing.Size(48, 13);
            this.labelNereden.TabIndex = 4;
            this.labelNereden.Text = "Nereden";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateTimePickerDonus
            // 
            this.dateTimePickerDonus.Location = new System.Drawing.Point(17, 164);
            this.dateTimePickerDonus.Name = "dateTimePickerDonus";
            this.dateTimePickerDonus.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDonus.TabIndex = 18;
            // 
            // dateTimePickerGidis
            // 
            this.dateTimePickerGidis.Location = new System.Drawing.Point(6, 164);
            this.dateTimePickerGidis.Name = "dateTimePickerGidis";
            this.dateTimePickerGidis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGidis.TabIndex = 20;
            // 
            // formBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 374);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "formBilet";
            this.Text = "formBilet";
            this.Load += new System.EventHandler(this.formBilet_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelDönüsTarihi;
        private System.Windows.Forms.Label labelNereye;
        private System.Windows.Forms.Label labelGidisDönüs;
        private System.Windows.Forms.Label labelTekYön;
        private System.Windows.Forms.RadioButton radioButtonGidisDönüs;
        private System.Windows.Forms.RadioButton radioButtonTekYön;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelSatıs;
        private System.Windows.Forms.Label labelRezervasyon;
        private System.Windows.Forms.RadioButton radioButtonSatıs;
        private System.Windows.Forms.RadioButton radioButtonRezervasyon;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label labelYolcuSayısı;
        private System.Windows.Forms.Label labelGidisTarihi;
        private System.Windows.Forms.Label labelNereden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDonus;
        private System.Windows.Forms.DateTimePicker dateTimePickerGidis;
    }
}