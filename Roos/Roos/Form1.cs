using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Roos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnTeken_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBox1.CreateGraphics();
            SolidBrush brush1 = new SolidBrush(Color.Green);
            SolidBrush brush2 = new SolidBrush(Color.Blue);
            SolidBrush brush3 = new SolidBrush(Color.Yellow);
            SolidBrush brush4 = new SolidBrush(Color.Red);

            paper.FillEllipse(brush1, 10, 10, 160, 160);
            paper.FillEllipse(brush2, 30, 30, 120, 120);
            paper.FillEllipse(brush3, 50, 50, 80, 80);
            paper.FillEllipse(brush4, 70, 70, 40, 40);
        }
    }
}
