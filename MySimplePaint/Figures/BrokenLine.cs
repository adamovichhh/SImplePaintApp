using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MySimplePaint.Figures
{
    class BrokenLine : Figure
    {
        public BrokenLine(Color color, float penWidth) : base(color, penWidth) 
        {
            this.color = color;
            this.penWidth = penWidth;
        }

        public override void Draw(Graphics graphics)
        {
            pen = new Pen(color, penWidth);
            graphics.DrawLines(pen, points);
        }

        public override Figure Clone()
        {
            return (BrokenLine)MemberwiseClone();
        }
    }
}
