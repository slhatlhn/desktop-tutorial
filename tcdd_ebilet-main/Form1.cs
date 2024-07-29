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

namespace zehBet
{
    public partial class Form1 : Form
    {
        string[] imageArray = { "C:\\Users\\USER\\Desktop\\tcdd_ebilet-main\\Image\\abc.png" };
        public Form1()
        {
            InitializeComponent();
           
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5 * 1000; 
            timer1.Enabled = true;
            panel2.BackgroundImage = Image.FromFile(imageArray[0]);
            timer1.Start();
            formBilet frmBilet = new formBilet();
            Data.GetData();
            FormShowMethod(frmBilet);
            
        }

        private void buttonBilet_Click(object sender, EventArgs e)
        {
            formBilet frmBilet = new formBilet();
            FormShowMethod(frmBilet);

        }

        private void buttonÜyeGirisi_Click(object sender, EventArgs e)
        {
            FormUyeGirisi frmUyeGiris = new FormUyeGirisi();
            FormShowMethod(frmUyeGiris);
        }

        private void buttonİstasyonTrenBilgileri_Click(object sender, EventArgs e)
        {
            FormIstasyonTrenBilgileri frmIstasyonTrenBilgileri = new FormIstasyonTrenBilgileri();
            FormShowMethod(frmIstasyonTrenBilgileri);
        }
        
        private void FormShowMethod(Form form)
        {
            panelSag.Controls.Clear(); // Panel'in içini temizliyoruz..
            form.TopLevel = false;
            panelSag.Controls.Add(form); // panel1 içerisinde formu ekledik

            form.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            form.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            form.BringToFront();
        }

    
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == imageArray.Length)
            {
                i = 0;
            }
            panel2.BackgroundImage = Image.FromFile(imageArray[i]);
            
           
        }

       
    }
}
