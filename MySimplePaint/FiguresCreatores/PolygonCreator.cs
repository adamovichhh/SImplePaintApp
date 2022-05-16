using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySimplePaint.Figures;
using System.Drawing;

namespace MySimplePaint.FiguresCreatores
{
    public class PolygonCreator : ICreator
    {
        public bool IsManyPoint { get => true; }
        public bool IsCanFeel { get => true; }
        public bool IsPainting { get => false; }
        public bool IsVariableAngles { get => false; }
        public Figure Create(Color color, Color fillColor, float penWidth)
        {
            return new Polygon(color, fillColor, penWidth);
        }
    }
}
