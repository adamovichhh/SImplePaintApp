using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySimplePaint.Figures;

namespace MySimplePaint.FiguresCreatores
{
    public class BrokenLineCreator : ICreator
    {
        public bool IsManyPoint { get => true; }
        public bool IsCanFeel { get => false; }
        public bool IsPainting { get => false; }
        public bool IsVariableAngles { get => false; }
        public Figure Create(Color color, Color fillColor, float penWidth)
        {
            return new BrokenLine(color, penWidth);
        }

    }
}
