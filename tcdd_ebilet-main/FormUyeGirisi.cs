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
    public partial class FormUyeGirisi : Form
    {
        public FormUyeGirisi()
        {
            InitializeComponent();
        }

        private void buttonÜyeGirisi_Click(object sender, EventArgs e)
        {
            string ePosta = textBox1.Text;
            string sifre = textBox2.Text;
            MessageBox.Show(ePosta + " " + sifre);
         }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;

        }
    }
}
