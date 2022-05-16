using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MySimplePaint.Figures
{
    class Line : Figure
    {
        public Line(Color color, float penWidth) : base(color, penWidth){}

        public override void Draw(Graphics graphics)
        {
            pen = new Pen(color, penWidth);
            graphics.DrawLine(pen,points[0],points[1]);
        }
        public override Figure Clone()
        {
            return (Line)MemberwiseClone();
        }
    }
}
