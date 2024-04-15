using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пр3_ОКФ
{
    internal class Figura
    {
        int x;
        int y;
        int h;
        PictureBox pb;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int H
        {
            get { return h; }
            set { h = value; }
        }
        public Figura(int nx,int ny,int nh, PictureBox npb) 
        {
            x= nx;
            y= ny;
            h = nh;
            pb = npb;
            Draw();
        }
        public void Draw()
        {
            Graphics gr = Graphics.FromImage(pb.Image);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            gr.FillRectangle(blueBrush, x, y, h, h);

            Point[] triangle1Points = { new Point(x, y), new Point(x + h / 2, y + h / 2), new Point(x, y + h) };
            Point[] triangle2Points = { new Point(x + h, y), new Point(x + h / 2, y + h / 2), new Point(x + h, y + h) };
            Point[] triangle3Points = { new Point(x, y), new Point(x + h / 2, y + h / 2), new Point(x + h, y) };
            Point[] triangle4Points = { new Point(x, y + h), new Point(x + h / 2, y + h / 2), new Point(x + h, y + h) };
            Pen redPen = new Pen(Color.Red, 2);
            gr.DrawPolygon(redPen, triangle1Points);
            gr.DrawPolygon(redPen, triangle2Points);
            gr.DrawPolygon(redPen, triangle3Points);
            gr.DrawPolygon(redPen, triangle4Points);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            int circleDiameter = h / 6;
            Point circleCenter = new Point(x + h / 3 + circleDiameter, y + h / 4); 
            gr.FillEllipse(greenBrush, circleCenter.X - circleDiameter / 2, circleCenter.Y - circleDiameter / 2, circleDiameter, circleDiameter);
            Point circleCenter2 = new Point(x + h / 3 + circleDiameter, y + 3 * h / 4);
            gr.FillEllipse(greenBrush, circleCenter2.X - circleDiameter / 2, circleCenter2.Y - circleDiameter / 2, circleDiameter, circleDiameter);
            pb.Refresh();
        }
        public void Edit(int nx, int ny, int nh)
        {
            x = nx;
            y = ny;
            h = nh;
            Draw();
        }

        public void Delete()
        {
            Graphics gr = Graphics.FromImage(pb.Image);
            gr.Clear(Color.Transparent);
            pb.Refresh();
        }
    }
}
