using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MySimplePaint.Figures
{
    class Rectangle : Figure
    {
        private float width;
        private float height;

        private Brush brush;
        public Rectangle(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            this.fillColor = fillColor;
        }

        public override void Draw(Graphics graphics)
        {

            PointF leftCorner = new PointF(Math.Min(points[0].X, points[1].X), Math.Min(points[0].Y, points[1].Y));
            PointF rightCorner = new PointF(Math.Max(points[0].X, points[1].X), Math.Max(points[0].Y, points[1].Y));

            width = rightCorner.X - leftCorner.X;
            height = rightCorner.Y - leftCorner.Y;
             
            if (isFeel)
            {
                brush = new SolidBrush(fillColor);
                graphics.FillRectangle(brush, leftCorner.X, leftCorner.Y, width, height);
            }

            pen = new Pen(color, penWidth);
            graphics.DrawRectangle(pen, leftCorner.X, leftCorner.Y, width, height);
        }

        public override Figure Clone()
        {
            return (Rectangle)MemberwiseClone();
        }
    }
}
