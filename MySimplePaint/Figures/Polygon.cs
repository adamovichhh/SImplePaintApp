using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MySimplePaint.Figures
{
    class Polygon : Figure
    { 
        private Brush brush;
        public Polygon(Color color, Color fillColor, float penWidth) : base(color, penWidth)
        {
            this.fillColor = fillColor;
        }

        public override void Draw(Graphics graphics)
        {

            if (isFeel)
            {
                brush = new SolidBrush(fillColor);
                graphics.FillPolygon(brush, points);
            }

            pen = new Pen(color, penWidth);
            graphics.DrawPolygon(pen, points);
        }

        public override Figure Clone()
        {
            return (Polygon)MemberwiseClone();
        }
    }
}
