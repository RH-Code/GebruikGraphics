using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oefening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            

            //drawing a triangle
            //paper.DrawLine(pen, 20, 80, 70, 10);
            //paper.DrawLine(pen, 70, 10, 120, 80);
            //paper.DrawLine(pen, 20, 80, 120, 80);

            //drawing a X
            //paper.DrawLine(pen, 0, 0, 100, 100);
            //paper.DrawLine(pen, 0, 100, 100, 0);

            //drawing a right-angled triangle
            //paper.DrawLine(pen, 280, 10, 280, 280);
            //paper.DrawLine(pen, 10, 280, 280, 280);
            //paper.DrawLine(pen, 280, 10, 10, 280);

            //drawing a blanc tic-tac-toe
            //paper.DrawLine(pen, 100, 0, 100, 300);
            //paper.DrawLine(pen, 200, 0, 200, 300);
            //paper.DrawLine(pen, 0, 100, 300, 100);
            //paper.DrawLine(pen, 0, 200, 300, 200);

            //drawing a simple house
            //drawing bottom of house
            paper.DrawRectangle(pen, 10, 120, 270, 170);
            //drawing the roof
            paper.DrawLine(pen, 10, 120, 150, 10);
            paper.DrawLine(pen, 150, 10, 280, 120);
            //drawing the door
            paper.DrawRectangle(pen, 30, 190, 70, 100);
            //drawing the window
            paper.DrawRectangle(pen, 130, 190, 120, 70);
        }
    }
}
