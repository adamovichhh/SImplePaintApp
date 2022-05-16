using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;

namespace MySimplePaint.Figures
{
    [DataContract]
    public abstract class Figure
    {
        #region Variable's
        [DataMember]
        public PointF[] points;

        [DataMember]
        public Color color;

        protected Pen pen;

        [DataMember]
        public float penWidth;

        [DataMember]
        public Color fillColor;

        [DataMember]
        public bool isFeel = false;
        #endregion

        public Figure(Color color, float penWidth)
        {
            this.penWidth = penWidth;
            this.color = color;
        }
        public abstract void Draw(Graphics graphics);
        public abstract Figure Clone();
    }
}
