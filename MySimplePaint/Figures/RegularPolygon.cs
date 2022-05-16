using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MySimplePaint.Figures
{
    class RegularPolygon : Figure
    {
      
        public int numOfCorners = 3;
  
        private Brush brush;
        
        public RegularPolygon(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            this.fillColor = fillColor;
        }

        public override void Draw(Graphics graphics)
        {

            PointF[] vertices = new PointF[numOfCorners];
            vertices[0] = points[1];

            PointF o = points[0];
            PointF polar = new PointF(1 * (float)Math.Cos(Math.Acos(-1.0) * 2 / numOfCorners), 1 * (float)Math.Sin(Math.Acos(-1.0) * 2 / numOfCorners));
            PointF radNext = new PointF(points[1].X - o.X, points[1].Y - o.Y);
            PointF temp = new PointF();

            for (int i = 1; i < numOfCorners; i++)
            {
                temp.X = radNext.X * polar.X - radNext.Y * polar.Y;
                temp.Y = radNext.X * polar.Y + radNext.Y * polar.X;

                radNext.X = temp.X;
                radNext.Y = temp.Y;

                vertices[i].X = o.X + radNext.X;
                vertices[i].Y = o.Y + radNext.Y;
            }

            if (isFeel)
            {
                brush = new SolidBrush(fillColor);
                graphics.FillPolygon(brush, vertices);
            }

            pen = new Pen(color, penWidth);
            graphics.DrawPolygon(pen, vertices);
        }

        public override Figure Clone()
        {
            return (RegularPolygon)MemberwiseClone();
        }

        /*private PointF DegreesToXY(float degrees, float radius, PointF origin)
        {
            PointF xy = new PointF();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (float)Math.Cos(radians) * radius + origin.X;
            xy.Y = (float)Math.Sin(-radians) * radius + origin.Y;

            return xy;
        }

        public override void Draw(Graphics graphics)
        {
            List<PointF> verticles = new List<PointF>();
            
            PointF center = points[0];
            PointF firstTop = points[1];
            float radius, firstCorner;

            if (center.X <= firstTop.X && center.Y <= firstTop.Y)
            {
                firstCorner = (float)(180.0 / Math.PI * Math.Atan((center.Y - firstTop.Y) / (firstTop.X - center.X)));
                radius = (float)Math.Sqrt(Math.Pow(center.Y - firstTop.Y, 2) + Math.Pow(firstTop.X - center.X, 2));
            }
            else
            {
                if (center.X > firstTop.X && center.Y <= firstTop.Y)
                {
                    firstCorner = (float)(90.0 + 180.0 / Math.PI * Math.Atan((center.X - firstTop.X) / (center.Y - firstTop.Y)));
                    radius = (float)Math.Sqrt(Math.Pow(center.X - firstTop.X, 2) + Math.Pow(center.Y - firstTop.Y, 2));
                }
                else 
                {
                    if (center.X >= firstTop.X && center.Y > firstTop.Y)
                    {
                        firstCorner = (float)(180.0 + 180.0 / Math.PI * Math.Atan((firstTop.Y - center.Y) / (center.X - firstTop.X)));
                        radius = (float)Math.Sqrt(Math.Pow(firstTop.Y - center.Y, 2) + Math.Pow(center.X - firstTop.X, 2));
                    }
                    else
                    {
                        firstCorner = (float)(270.0 + 180.0 / Math.PI * Math.Atan((firstTop.X - center.X) / (firstTop.Y - center.Y)));
                        radius = (float)Math.Sqrt(Math.Pow(firstTop.X - center.X, 2) + Math.Pow(firstTop.Y - center.Y, 2));
                        
                    }
                }
            }

            //verticles.Add(DegreesToXY(firstCorner, radius, center));

            float step = 360.0f / numOfCorners;

            float angle = firstCorner; //starting angle
            for (double i = firstCorner; i < firstCorner + 360.0; i += step) //go in a full circle
            {
                verticles.Add(DegreesToXY(angle, radius, center)); //code snippet from above
                angle += step;
            }

            points = verticles.ToArray();
            
            if (isFeel)
            {
                graphics.FillPolygon(brush, points);
            }

            graphics.DrawPolygon(pen, points);
        }*/
    }
}
