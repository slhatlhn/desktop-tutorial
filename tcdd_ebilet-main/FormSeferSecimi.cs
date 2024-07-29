using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using zehBet.data;
using zehBet.sinifler;

namespace zehBet
{
    public partial class formSeferSecimi : Form
    {
        List<Sefer> seferler;
        Sefer secilenSefer;
        DateTime tarih;
        int totalHeight = 0;
        public formSeferSecimi(List<Sefer> seferler,DateTime tarih)
        {
            InitializeComponent();
            this.seferler = seferler;
            secilenSefer = new Sefer();
            this.tarih = tarih;
        }
        int panelX = 0;
        int panelY = 3;
        int panelW = 780;
        int panelH = 104;

        private void FormSeferSecimi_Load(object sender, EventArgs e)
        {
            buttonDevam.Enabled = false;
            labelTarih.Text = $"{tarih.ToString("yyyy-MM-dd")} {tarih.ToString("dddd")}";
            if(tarih.Date == DateTime.Now.Date)
            {
               btnOncekiGun.Enabled = false;
            }
            SeferlerGoster();
            panelMain.AutoScrollMinSize = new Size(panelMain.Width, totalHeight);
        }
        private void PanelleriTemizle()
        {
            panelMain.Controls.Clear();
            panelY = 0; // panelY değişkenini başlangıç konumuna sıfırlayın
            totalHeight = 0; // totalHeight değişkenini sıfırlayın
            buttonDevam.Enabled=false;
        }
        private void SeferlerGoster()
        {
            for (int i = 0; i < seferler.Count; i++)
            {
                // Dış katman panelini oluşturun
                Panel panelDisKatman = new Panel();
                panelDisKatman.Location = new Point(panelX, panelY);
                panelDisKatman.Size = new Size(panelW, panelH);
                panelDisKatman.Name = i.ToString();
                panelDisKatman.BackColor = i % 2 == 0 ? Color.Gray : Color.LightGray;// Arka plan rengini belirgin yapın

                // İç paneli oluşturun
                Panel panelIlk = new Panel();
                panelIlk.Location = new Point(3, 3);
                panelIlk.Name = "panelIlk" + i;
                panelIlk.Size = new Size(167, 100);
                panelDisKatman.Controls.Add(panelIlk);

                // Etiketi oluşturun
                Label labelIlk = new Label();
                labelIlk.Location = new Point(44, 49);
                labelIlk.Name = "LabelIlk" + i;
                labelIlk.Size = new Size(100, 20);
                labelIlk.Text = seferler[i].VarisSuresi;
                panelIlk.Controls.Add(labelIlk);

                Label labelVaris = new Label();
                labelVaris.Location = new Point(41, 13);
                labelVaris.Name = "LabelVaris" + i;
                labelVaris.Size = new Size(82, 13);
                labelVaris.Text = "VARIŞ SÜRESİ";
                panelIlk.Controls.Add(labelVaris);

                Panel panelIkinci = new Panel();
                panelIkinci.Location = new Point(176, 3);
                panelIkinci.Size = new Size(221, 100);
                panelIkinci.Name = "PanelIkinci" + i;

                RadioButton radioButtonS = new RadioButton();
                radioButtonS.Location = new Point(13, 49);
                radioButtonS.Name = "radioButtonS" + i;
                radioButtonS.Size = new Size(84, 17);
                radioButtonS.Text = "Standart";

                RadioButton radioButtonE = new RadioButton();
                radioButtonE.Location = new Point(128, 50);
                radioButtonE.Name = "radioButtonE" + i;
                radioButtonE.Size = new Size(61, 17);
                radioButtonE.Text = "Esnek";
                panelIkinci.Controls.Add(radioButtonE);
                panelIkinci.Controls.Add(radioButtonS);

                Label labelAdi = new Label();
                labelAdi.Text = seferler[i].ToString();
                labelAdi.Location = new Point(40, 13);
                labelAdi.Size = new Size(116, 13);
                labelAdi.Name = "labelAdi" + i;
                panelIkinci.Controls.Add(labelAdi);



                Panel panelUcuncu = new Panel();
                panelUcuncu.Location = new Point(403, 3);
                panelUcuncu.Name = "panelUcuncu";
                panelUcuncu.Size = new Size(157, 100);
                panelDisKatman.Controls.Add(panelUcuncu);

                ComboBox comboboxIlk = new ComboBox();
                comboboxIlk.Name = "ComboboxIlk" + i;
                comboboxIlk.Location = new Point(17, 40);
                comboboxIlk.Size = new Size(121, 21);
                comboboxIlk.Items.Add(seferler[i].Tren.Id);
                panelUcuncu.Controls.Add(comboboxIlk);


                Panel paneldorduncu = new Panel();
                paneldorduncu.Location = new Point(563, 3);
                paneldorduncu.Name = "paneldorduncu" + i;
                paneldorduncu.Size = new Size(97, 100);
                panelDisKatman.Controls.Add(paneldorduncu);

                Label labelucret = new Label();
                labelucret.Name = "labelucret" + i;
                labelucret.Text = seferler[i].Ucreti.ToString();
                labelucret.Size = new Size(38, 13);
                labelucret.Location = new Point(28, 40);
                paneldorduncu.Controls.Add(labelucret);


                Panel panelbesinci = new Panel();
                panelbesinci.Location = new Point(663, 3);
                panelbesinci.Name = "panelbesinci" + i;
                panelbesinci.Size = new Size(117, 100);
                panelDisKatman.Controls.Add(panelbesinci);

                CheckBox checkBoxSec = new CheckBox();
                checkBoxSec.Name = "radiobuttonsec" + i;
                checkBoxSec.Text = "Seç";
                checkBoxSec.Size = new Size(47, 17);
                checkBoxSec.Location = new Point(40, 20);
                checkBoxSec.CheckedChanged += CheckBox_Checked;

                panelbesinci.Controls.Add(checkBoxSec);
                var item = panelDisKatman.Controls;

                //Dış katman panelini formun kontrolüne ekleyin
                panelDisKatman.Controls.Add(panelIkinci);
                panelMain.Controls.Add(panelDisKatman);
                panelY += 108;
                totalHeight += panelDisKatman.Height;
            }
            
        }
        private void CheckBox_Checked(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            // Olay işleyicisini geçici olarak devre dışı bırak
            checkBox.CheckedChanged -= CheckBox_Checked;

            // Diğer CheckBox'ların işaretini kaldır
            foreach (var panel in panelMain.Controls)
            {
                if (panel is Panel panelDisKatman)
                {
                    foreach (var item in panelDisKatman.Controls)
                    {
                        if (item is Panel innerPanel)
                        {
                            foreach (var innerItem in innerPanel.Controls)
                            {
                                if (innerItem is CheckBox otherCheckBox && otherCheckBox != checkBox)
                                {
                                    otherCheckBox.CheckedChanged -= CheckBox_Checked; // Olay işleyicisini geçici olarak devre dışı bırak
                                    otherCheckBox.Checked = false;
                                    panelDisKatman.BackColor = int.Parse(panelDisKatman.Name) % 2 == 0 ? Color.Gray : Color.LightGray;
                                    buttonDevam.Enabled = true;
                                    otherCheckBox.CheckedChanged += CheckBox_Checked; // Olay işleyicisini yeniden etkinleştir
                                }
                                if (innerItem is CheckBox otherChecBox && otherChecBox == checkBox)
                                {
                                    panelDisKatman.BackColor = Color.Blue;
                                    secilenSefer = seferler[int.Parse(panelDisKatman.Name)];
                                }
                            }
                        }
                    }
                }
            }

            // Seçili CheckBox'ın durumunu koru
            checkBox.Checked = true;
            // Olay işleyicisini yeniden etkinleştir
            checkBox.CheckedChanged += CheckBox_Checked;
        }

        private void buttonDevam_Click(object sender, EventArgs e)
        {
            MessageBox.Show(secilenSefer.ToString());
        }

        private void btnSonrakiGun_Click(object sender, EventArgs e)
        {
            btnOncekiGun.Enabled = true;
            tarih = tarih.AddDays(1);
            labelTarih.Text = $"{tarih.ToString("yyyy-MM-dd")} {tarih.ToString("dddd")}";
            secilenSefer = new Sefer();
            SeferleriGetir();
        }
        private void SeferleriGetir()
        {
            seferler = new List<Sefer>();
            seferler = Data.Seferler.Where(i => i.KalkisZamani.Date == tarih.Date).ToList();
            PanelleriTemizle();
            SeferlerGoster();
        }

        private void btnOncekiGun_Click(object sender, EventArgs e)
        {
            btnOncekiGun.Enabled = true;
            tarih = tarih.AddDays(-1);
            labelTarih.Text = $"{tarih.ToString("yyyy-MM-dd")} {tarih.ToString("dddd")}";
            secilenSefer = new Sefer();
            PanelleriTemizle();
            SeferleriGetir();
            if (tarih.Date == DateTime.Now.Date)
            {
                btnOncekiGun.Enabled = false;
            }
        }
    }
}
