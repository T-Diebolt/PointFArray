using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointFArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Point point1 = new Point();

            point1.X = 50;
            point1.Y = 90;

            Point point2 = new Point(150, 100);
            Point point3 = new Point(100, 250);

            Graphics g = this.CreateGraphics();
            // should also have SolidBrush or Pen
            Pen redPen = new Pen(Color.Red);

            //g.DrawLine(redPen, point1, point2);
            //g.DrawLine(redPen, point2, point3);
            //g.DrawLine(redPen, point3, point1);

            Point[] quad = new Point[4];
            quad[0] = point1;
            quad[1] = point2;
            quad[2] = point3;
            quad[3] = new Point(300, 53);

            g.DrawPolygon(redPen, quad);
            g.FillPolygon(Brushes.Blue, quad);

        }
    }
}
