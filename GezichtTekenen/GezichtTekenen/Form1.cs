using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GezichtTekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWis_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTeken_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            SolidBrush brush1 = new SolidBrush(Color.Pink);
            SolidBrush brush2 = new SolidBrush(Color.Red);
            SolidBrush brush3 = new SolidBrush(Color.Black);
            SolidBrush brush4 = new SolidBrush(Color.DarkSalmon);
            SolidBrush brush5 = new SolidBrush(Color.White);

            //We put the neck and ears first, because of the pen outlining. 
            //Those have to be behind the face
            
            //Creating the neck
            paper.FillRectangle(brush1, 87, 160, 20, 30);
            paper.DrawRectangle(pen, 87, 160, 20, 30);
            
            //Creating the ears
            paper.FillEllipse(brush1, 35, 60, 20, 30);
            paper.DrawEllipse(pen, 35, 60, 20, 30);
            paper.FillEllipse(brush1, 145, 60, 20, 30);
            paper.DrawEllipse(pen, 145, 60, 20, 30);
            paper.FillEllipse(brush4, 40, 67, 10, 15);
            paper.DrawEllipse(pen, 40, 67, 10, 15);
            paper.FillEllipse(brush4, 150, 67, 10, 15);
            paper.DrawEllipse(pen, 150, 67, 10, 15);
            
            //Creating the face
            paper.FillEllipse(brush1, 50, 10, 100, 160);
            paper.DrawEllipse(pen, 50, 10, 100, 160);

            //Creating the eyes
            paper.FillEllipse(brush5, 70, 40, 25, 40);
            paper.DrawEllipse(pen, 70, 40, 25, 40);
            paper.FillEllipse(brush5, 105, 40, 25, 40);
            paper.DrawEllipse(pen, 105, 40, 25, 40);
            paper.FillEllipse(brush3, 77, 60, 10, 20);
            paper.FillEllipse(brush3, 112, 60, 10, 20);

            //Creating the nose
            paper.FillEllipse(brush4, 87, 80, 25, 40);
            paper.DrawEllipse(pen, 87, 80, 25, 40);

            //Creating the mouth
            paper.FillEllipse(brush3, 79, 130, 25, 25);
            paper.FillEllipse(brush2, 82, 144, 10, 10);
                       
        }

        
    }
}
