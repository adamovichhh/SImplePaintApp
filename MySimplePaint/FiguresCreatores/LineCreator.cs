using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySimplePaint.Figures;

namespace MySimplePaint.FiguresCreatores
{
    public class LineCreator : ICreator
    {
        public bool IsManyPoint { get => false; }
        public bool IsCanFeel { get => false; }
        public bool IsPainting { get => false; }
        public bool IsVariableAngles { get => false; }
        public Figure Create(Color color, Color fillColor, float penWidth)
        {
            return new Line(color, penWidth);
        }

    }
}
