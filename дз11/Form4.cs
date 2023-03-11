using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз11
{
    public partial class Form4 : Form
    {
        public Color col = Color.Black;
        public Point point;
        public Point point1;
        public Point point2;
        public Pen pen;
        public float widthPen;
        public Brush br;
        public Rectangle rectangle;
        public int index =0;
        public int index1 = 0;
        public int dashStyle = 0;
        public int htch = 0;
        public int st = 0;
        // public Size size;
        public Form4()
        {
            InitializeComponent();
             widthPen = Wigh.Value;
             pen = new Pen(col, widthPen);
             br = new SolidBrush(Color.Transparent);
        }

       
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
            Graphics g = e.Graphics;
            pen.DashStyle = (DashStyle)dashStyle;
            if (Line.Checked)
            {
                pen.StartCap = (LineCap)index;
                pen.EndCap = (LineCap)index1;
                g.DrawLine(pen, point, point1);
                
            }
            else 
            {
                rectangle = new Rectangle(point.X, point.Y, point1.X - point.X, point1.Y - point.Y);
                if (Gradient.Checked)
                {
                    br = new LinearGradientBrush(rectangle, button1.BackColor, button2.BackColor, (LinearGradientMode)htch);
                }
                if (Hatch.Checked)
                {
                    br = new HatchBrush((HatchStyle)st, button1.BackColor, button2.BackColor);
                }
                if (Ellipse.Checked) {

                    g.FillEllipse(br, rectangle);
                    g.DrawEllipse(pen, rectangle);
                   
                }
                else if (Rectangle.Checked)
                {
                    g.FillRectangle(br, rectangle);
                    g.DrawRectangle(pen, rectangle);
                   
                }
            }
            
        }
        private void Color1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = pictureBox1.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Color1.BackColor = dialog.Color;
                pictureBox1.BackColor = dialog.Color;
                this.Refresh();
            }

        }

        private void Color2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Color2.BackColor = dialog.Color;
                col = dialog.Color;
                pen = new Pen(col, widthPen);
                br = new SolidBrush(col);
                this.Refresh();
            }

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
          
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            point1 = new Point(e.X, e.Y);
            this.Refresh();
        }

       

        private void Wigh_Scroll(object sender, EventArgs e)
        {
            widthPen = Wigh.Value;
            pen = new Pen(col, widthPen);
            this.Refresh();
        }

        private void Start_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = Start.SelectedIndex;
            if (index > 3) index += 12;
            this.Refresh();
        }

        private void End_SelectedIndexChanged(object sender, EventArgs e)
        {
            index1 = End.SelectedIndex;
            if (index1 > 3) index1 += 12;
           
        }

        private void DiferentLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            dashStyle = DiferentLine.SelectedIndex;
            this.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                button1.BackColor = dialog.Color;
                br = new SolidBrush(dialog.Color);
                this.Refresh();
            }
        }
        private void Solid_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            this.Refresh();
        }

        private void Hatch_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                button2.BackColor = dialog.Color;
               
                this.Refresh();
            }
        }

        private void Gradient_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
          
            this.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            htch = comboBox1.SelectedIndex;
            this.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            st = comboBox2.SelectedIndex;
            this.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.DefaultExt = "*.png";
            save.Filter = "PNG files (*.png)| *.png|JPEG(*.jpeg)|*.jpeg";
            if (save.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(save.FileName);
            }
        }
    }
}
