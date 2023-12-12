using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgLab
{
    internal class FrostyFractal
    {
        int size;
        int order;
        Color color;
        PictureBox pictureBox;
        public FrostyFractal(int size, int order, PictureBox pictureBox, Color color)
        {
            this.size = size;
            this.order = order;
            this.pictureBox = pictureBox;
            this.color = color;
        }
        public Bitmap CreateFractal(Color bg)
        {
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height, PixelFormat.Format24bppRgb);
            
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(bg);
                int centerX = bmp.Width / 2;
                int centerY = bmp.Height / 2;
                Point p1 = new Point(centerX - size / 2, centerY - size / 2);
                Point p2 = new Point(centerX + size / 2, centerY - size / 2);
                Point p3 = new Point(centerX + size / 2, centerY + size / 2);
                Point p4 = new Point(centerX - size / 2, centerY + size / 2);
                g.DrawRectangle(new Pen(color), p1.X, p1.Y, size, size);
                Step(order, size, p1, p2, g);
                Step(order, size, p3, p2, g);
                Step(order, size, p3, p4, g);
                Step(order, size, p1, p4, g);
            }
            return bmp;
        }
        private void Step(int order, int length, Point startPoint, Point endPoint, Graphics g)
        {
            if (order == 0)
            {
                int lineLength = length / 3;
                Point p2 = new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);
                Point p3;
                if (startPoint.X == endPoint.X)
                    p3 = new Point(startPoint.X - lineLength * (Math.Abs(startPoint.Y - endPoint.Y) / (startPoint.Y - endPoint.Y)), p2.Y);
                else
                    p3 = new Point(p2.X, startPoint.Y - lineLength * (Math.Abs(startPoint.X - endPoint.X) / (startPoint.X - endPoint.X)));
                g.DrawLine(new Pen(color), p2, p3);
            }
            else
            {
                int lineLength = length / 3;
                int partLength = length / 2;

                Point p1 = new Point(startPoint.X, startPoint.Y);
                Point p2 = new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);
                Point p3;
                if (startPoint.X == endPoint.X)
                    p3 = new Point(startPoint.X - lineLength * (Math.Abs(startPoint.Y - endPoint.Y) / (startPoint.Y - endPoint.Y)), p2.Y);
                else
                    p3 = new Point(p2.X, startPoint.Y - lineLength * (Math.Abs(startPoint.X - endPoint.X) / (startPoint.X - endPoint.X)));
                Point p4 = new Point(endPoint.X, endPoint.Y);

                g.DrawLine(new Pen(color), p2, p3);

                Step(order - 1, partLength, p1, p2, g);
                Step(order - 1, lineLength, p2, p3, g);
                Step(order - 1, lineLength, p3, p2, g);
                Step(order - 1, partLength, p2, p4, g);
            }
        }
    }
}
