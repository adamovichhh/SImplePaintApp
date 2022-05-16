using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySimplePaint.Figures;
using System.Drawing;

namespace MySimplePaint.FiguresCreatores
{
    public class RegularPolygonCreator : ICreator
    {
        public bool IsManyPoint { get => false; }
        public bool IsCanFeel { get => true; }
        public bool IsPainting { get => false; }
        public bool IsVariableAngles { get => true; }
        public Figure Create(Color color, Color fillColor, float penWidth)
        {
            return new Figures.RegularPolygon(color, fillColor, penWidth);
        }
    }
}
