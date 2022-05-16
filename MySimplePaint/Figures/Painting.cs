using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MySimplePaint.Figures
{
    class Painting : Figure
    {
        private List<PointF> allPoints = new List<PointF>();
        private bool IsCreat;
        //private Brush brush;
        public Painting(Color color, float penWidth) : base(color, penWidth)
        {
            IsCreat = true;
        }

        public override void Draw(Graphics graphics)
        {
            

            if (IsCreat) {
                allPoints.Clear();
                allPoints.Add(points[0]); 
                allPoints.Add(points[0]);
                IsCreat = false;
            }
            else { allPoints.Add(points[1]); }

            pen = new Pen(color, penWidth);
            graphics.DrawLines(pen, allPoints.ToArray());
            /*for (int i = 0; i < allPoints.Count; i++)
            {
                if (isFeel)
                {
                    graphics.FillEllipse(brush,allPoints[i].X, allPoints[i].Y, 3, 3);
                }
            graphics.DrawLines(pen, allPoints.ToArray());
            }*/
        }

        public override Figure Clone()
        {
            return (Painting)MemberwiseClone();
        }
    }
}
