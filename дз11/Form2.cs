using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз11
{
    public partial class Form2 : Form
    {
        public double x, y;
        public double xMin = -10, xMax = 10;

        public double scale = 40;
       
        Pen pen = new Pen(Color.Red, 2);
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = drawingArea.CreateGraphics();

            g.Clear(Color.White);


            g.DrawLine(Pens.Black, 0, drawingArea.Height / 2, drawingArea.Width, drawingArea.Height / 2);
            g.DrawLine(Pens.Black, drawingArea.Width / 2, 0, drawingArea.Width / 2, drawingArea.Height);


            for (x = xMin; x <= xMax; x += 0.1)
            {
               
                y = Math.Cos(x);

                g.DrawRectangle(pen, (float)(drawingArea.Width / 2 + x * scale), (float)(drawingArea.Height / 2 - y * scale), 1, 1);
            }
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics g = drawingArea.CreateGraphics();

            g.Clear(Color.White);

            
            g.DrawLine(Pens.Black, 0, drawingArea.Height / 2, drawingArea.Width, drawingArea.Height / 2);
            g.DrawLine(Pens.Black, drawingArea.Width / 2, 0, drawingArea.Width / 2, drawingArea.Height);

            
            for (x = xMin; x <= xMax; x += 0.1)
            {
                y = Math.Sin(x);
                g.DrawRectangle(pen, (float)(drawingArea.Width / 2+x * scale), (float)(drawingArea.Height / 2 - y * scale), 1, 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Graphics g = drawingArea.CreateGraphics();
        
            g.Clear(Color.White);


            g.DrawLine(Pens.Black, 0, drawingArea.Height / 2, drawingArea.Width, drawingArea.Height / 2);
            g.DrawLine(Pens.Black, drawingArea.Width / 2, 0, drawingArea.Width / 2, drawingArea.Height);


            for (x = xMin; x <= xMax; x += 0.1)
            {
                  y = Math.Tan(x);
              
               
                g.DrawRectangle(pen, (float)(drawingArea.Width / 2 + x * scale), (float)(drawingArea.Height / 2 - y * scale), 1, 1);
            }
        }
    }
}

