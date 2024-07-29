namespace zehBet
{
    partial class FormUyeGirisi
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
            this.labelEposta = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelÜyelik = new System.Windows.Forms.Label();
            this.labelParolamıUnuttum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonEDevletileGiris = new System.Windows.Forms.Button();
            this.buttonÜyeGirisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEposta
            // 
            this.labelEposta.AutoSize = true;
            this.labelEposta.Location = new System.Drawing.Point(58, 45);
            this.labelEposta.Name = "labelEposta";
            this.labelEposta.Size = new System.Drawing.Size(44, 13);
            this.labelEposta.TabIndex = 0;
            this.labelEposta.Text = "E-Posta";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(326, 45);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(28, 13);
            this.labelSifre.TabIndex = 1;
            this.labelSifre.Text = "Şifre";
            // 
            // labelÜyelik
            // 
            this.labelÜyelik.AutoSize = true;
            this.labelÜyelik.Location = new System.Drawing.Point(58, 98);
            this.labelÜyelik.Name = "labelÜyelik";
            this.labelÜyelik.Size = new System.Drawing.Size(36, 13);
            this.labelÜyelik.TabIndex = 2;
            this.labelÜyelik.Text = "Üyelik";
            // 
            // labelParolamıUnuttum
            // 
            this.labelParolamıUnuttum.AutoSize = true;
            this.labelParolamıUnuttum.Location = new System.Drawing.Point(124, 98);
            this.labelParolamıUnuttum.Name = "labelParolamıUnuttum";
            this.labelParolamıUnuttum.Size = new System.Drawing.Size(96, 13);
            this.labelParolamıUnuttum.TabIndex = 3;
            this.labelParolamıUnuttum.Text = "Parolamı Unuttum?";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(61, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "example@gmail.com";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(329, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // buttonEDevletileGiris
            // 
            this.buttonEDevletileGiris.Location = new System.Drawing.Point(61, 134);
            this.buttonEDevletileGiris.Name = "buttonEDevletileGiris";
            this.buttonEDevletileGiris.Size = new System.Drawing.Size(123, 29);
            this.buttonEDevletileGiris.TabIndex = 6;
            this.buttonEDevletileGiris.Text = "e-Devlet ile Giris";
            this.buttonEDevletileGiris.UseVisualStyleBackColor = true;
            // 
            // buttonÜyeGirisi
            // 
            this.buttonÜyeGirisi.Location = new System.Drawing.Point(329, 98);
            this.buttonÜyeGirisi.Name = "buttonÜyeGirisi";
            this.buttonÜyeGirisi.Size = new System.Drawing.Size(87, 29);
            this.buttonÜyeGirisi.TabIndex = 7;
            this.buttonÜyeGirisi.Text = "Üye Girişi";
            this.buttonÜyeGirisi.UseVisualStyleBackColor = true;
            this.buttonÜyeGirisi.Click += new System.EventHandler(this.buttonÜyeGirisi_Click);
            // 
            // FormUyeGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 216);
            this.Controls.Add(this.buttonÜyeGirisi);
            this.Controls.Add(this.buttonEDevletileGiris);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelParolamıUnuttum);
            this.Controls.Add(this.labelÜyelik);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelEposta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FormUyeGirisi";
            this.Text = "FormUyeGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEposta;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelÜyelik;
        private System.Windows.Forms.Label labelParolamıUnuttum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonEDevletileGiris;
        private System.Windows.Forms.Button buttonÜyeGirisi;
    }
}