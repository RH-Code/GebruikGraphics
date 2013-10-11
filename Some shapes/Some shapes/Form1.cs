using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Some_shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeken_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();

            Bitmap pic = new Bitmap(@"C:\Users\Ruben\documents\visual studio 2010\Projects\Some shapes\Some shapes\bin\Debug\DSC_0258bis.jpg");

            Pen pen = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Red);
            SolidBrush brush = new SolidBrush(Color.Red);

            paper.DrawRectangle(pen, 10, 10, 100, 50);
            paper.DrawLine(pen2, 10, 10, 110, 60);
            paper.DrawRectangle(pen, 10, 80, 100, 50);
            paper.DrawEllipse(pen2, 10, 80, 100, 50);
            paper.DrawRectangle(pen, 130, 10, 150, 150);
            paper.DrawImage(pic, 131, 11, 149, 149);
            paper.FillEllipse(brush, 10, 150, 100, 50);
        }
    }
}
