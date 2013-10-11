using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EindoefeningGraphics2
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

        private void btnToon_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Violet);
            SolidBrush brush2 = new SolidBrush(Color.Yellow);
            SolidBrush brush3 = new SolidBrush(Color.Green);
            SolidBrush brush4 = new SolidBrush(Color.Red);

            paper.FillRectangle(brush, 0, 0, 150, 45);
            paper.FillRectangle(brush2, 0, 45, 175, 45);
            paper.FillRectangle(brush3, 0, 90, 120, 45);
            paper.FillRectangle(brush4, 0, 135, 130, 45);
        }
    }
}
