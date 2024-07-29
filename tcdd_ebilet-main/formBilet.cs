using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zehBet.data;
using zehBet.sinifler;

namespace zehBet
{
    public partial class formBilet : Form
    {
        public formBilet()
        {
            InitializeComponent();
        }

        private void formBilet_Load(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            List<Sefer> seferler = new List<Sefer>();
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrEmpty(comboBox2.Text) && dateTimePickerGidis.Value.Date >= DateTime.Now.Date)
            {
                if (radioButtonGidisDönüs.Checked && dateTimePickerDonus.Value.Date >= dateTimePickerGidis.Value.Date)
                {
                    string biletTipi = radioButtonSatıs.Checked ? "Satış" : "Rezervasyon";
                    string nereden = comboBox1.Text;
                    DateTime gidisTarihi = dateTimePickerGidis.Value;
                    int yolcuSayisi = Convert.ToInt32(numericUpDown1.Value);


                    string biletYonu = radioButtonTekYön.Checked ? "Tek Yön" : "Gidiş Dönüş";
                    string nereye = comboBox2.Text;
                    DateTime dönüsTarihi = dateTimePickerDonus.Value;
                    seferler = Data.Seferler.Where(i => i.KalkisZamani.Date == dateTimePickerGidis.Value.Date && i.VarisZamani.Date == dateTimePickerDonus.Value.Date).ToList();
               
                }
                else
                {
                    string biletTipi = radioButtonSatıs.Checked ? "Satış" : "Rezervasyon";
                    string nereden = comboBox1.Text;
                    DateTime gidisTarihi = dateTimePickerGidis.Value;
                    int yolcuSayisi = Convert.ToInt32(numericUpDown1.Value);


                    string biletYonu = radioButtonTekYön.Checked ? "Tek Yön" : "Gidiş Dönüş";
                    string nereye = comboBox2.Text;
                    seferler = Data.Seferler.Where(i => i.KalkisZamani.Date == dateTimePickerGidis.Value.Date).ToList();
                  
                }
                formSeferSecimi formSefer = new formSeferSecimi(seferler, dateTimePickerGidis.Value); 
                formSefer.Show();
                Form1 form1 = new Form1();
                this.Hide();
                form1.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen değerleri boş girmeyiniz...");
            }

        }

        private void radioButtonTekYön_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTekYön.Checked)
            {
                dateTimePickerDonus.Enabled = false;
                dateTimePickerDonus.BackColor = Color.SkyBlue;

            }
            else
            {
                dateTimePickerDonus.Enabled = true;
                dateTimePickerDonus.BackColor = Color.White;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nereden = comboBox1.Text;
            string nereye = comboBox2.Text;
            comboBox1.Text = nereye;
            comboBox2.Text = nereden;
        }
    }
}
