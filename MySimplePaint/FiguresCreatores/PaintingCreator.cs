using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using MySimplePaint.Figures;

namespace MySimplePaint.FiguresCreatores
{   
    public class PaintingCreator : ICreator
    {
        public bool IsManyPoint { get => false; }
        public bool IsCanFeel { get => true; }
        public bool IsPainting { get => true; }
        public bool IsVariableAngles { get => false; }
        public Figure Create(Color color, Color fillColor, float penWidth)
        {
            return new Painting(color, penWidth);
        }

    }
}
