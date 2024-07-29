using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zehBet.Properties;

namespace zehBet
{
    public partial class FormKoltukSecimi : Form
    {
        public FormKoltukSecimi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void FormKoltukSecimi_Load(object sender, EventArgs e)
        {
            PictureBoxCreate(flowLayoutPanel1, 1);
            PictureBoxCreate(flowLayoutPanel2, 2);
            PictureBoxCreate(flowLayoutPanel3, 3);
            PictureBoxCreate(flowLayoutPanel4, 4);
            PictureBoxCreate(flowLayoutPanel5, 5);
            PictureBoxCreate(flowLayoutPanel6, 6);
            PictureBoxCreate(flowLayoutPanel7, 7);
            PictureBoxCreate(flowLayoutPanel8, 8);
            PictureBoxCreate(flowLayoutPanel9, 9);
        }

        private void PictureBoxCreate(FlowLayoutPanel flowLayoutPanel, int panelNo)
        {
            for (int i = 25 * (panelNo - 1); i < 25 * panelNo; i++)
            {
                PictureBox p = new PictureBox();
                //pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
                p.Name = i.ToString();
                p.Size = new System.Drawing.Size(41, 36);
                p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                p.Image = Image.FromFile("C:\\Users\\USER\\Desktop\\tcdd_ebilet-main\\Image\\seat.png");
                p.Click += PictureBox_Click;
                flowLayoutPanel.Controls.Add(p);
            }


        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            MessageBox.Show(pb.Name);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
