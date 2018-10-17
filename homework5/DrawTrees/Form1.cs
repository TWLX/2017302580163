using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawTrees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Graphics graphics;

        public void drawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            double num1 = Convert.ToDouble(angle1.Text);
            double th1 = num1 * Math.PI / 180;
            double num2 = Convert.ToDouble(angle2.Text);
            double th2 = num2 * Math.PI / 180;
            double per1 = Convert.ToDouble(length1.Text);
            double per2 = Convert.ToDouble(length2.Text);
            double k = Convert.ToDouble(length2.Text);

            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);

            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);
            drawLine(x0, y0, x2, y2);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2);

        }

        public void drawLine(double x0, double y0, double x1, double y1)
        {
            string c = listBox1.Text;
            Color color = Color.FromName(c);
            Pen pen = new Pen(color);
            graphics.DrawLine(
            pen,
            (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 250, 410, 100, -Math.PI / 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Color color = Color.White;
            graphics.Clear(color);
        }
    }
}
