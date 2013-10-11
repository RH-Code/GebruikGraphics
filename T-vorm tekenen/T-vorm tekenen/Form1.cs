using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace T_vorm
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
            Pen pen = new Pen(Color.Blue);
            
            /*The T-shape with 8 lines.*/
            paper.DrawLine(pen, 10, 10, 280, 10);
            paper.DrawLine(pen, 10, 10, 10, 70);
            paper.DrawLine(pen, 280, 10, 280, 70);
            paper.DrawLine(pen, 10, 70, 105, 70);
            paper.DrawLine(pen, 175, 70, 280, 70);
            paper.DrawLine(pen, 105, 70, 105, 280);
            paper.DrawLine(pen, 175, 70, 175, 280);
            paper.DrawLine(pen, 105, 280, 175, 280);

            /*The T-shape with 2 rectangles*/
            //paper.DrawRectangle(pen, 10, 10, 280, 70);
            //paper.DrawRectangle(pen, 105, 80, 80, 210);
        }
    }
}
