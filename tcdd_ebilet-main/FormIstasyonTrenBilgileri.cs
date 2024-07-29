using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zehBet
{
    public partial class FormIstasyonTrenBilgileri : Form
    {
        public FormIstasyonTrenBilgileri()
        {
            InitializeComponent();
        }

        private void FormIstasyonTrenBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void buttonİstasyonTrenBilgileri_Click(object sender, EventArgs e)
        {
            string istasyonAdi = comboBox1.Text;
            DateTime tarih = Convert.ToDateTime(dateTimePicker1.Value);
            MessageBox.Show(istasyonAdi + " " + tarih);
        }
    }
}
