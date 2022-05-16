using System;
using System.Drawing;
using MySimplePaint.Figures;

namespace MySimplePaint.FiguresCreatores
{
    public interface ICreator
    {
        bool IsManyPoint { get; }
        bool IsCanFeel { get; }
        bool IsPainting { get; }
        bool IsVariableAngles { get; }
        Figure Create(Color color, Color fillColor, float penWidth);
    }
}
