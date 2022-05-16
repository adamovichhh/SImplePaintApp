using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySimplePaint.Figures;
using System.Drawing;
using System.Runtime.Serialization;

namespace MySimplePaint
{
    [DataContract]
    public class AllFigures
    {
        [DataMember]
        public Stack<Figure> stackFigures = new Stack<Figure>();

        [DataMember]
        public List<Figure> listFigures = new List<Figure>();

        public void Add(Figure figure)
        {
            listFigures.Add(figure);
        }

        public void Clear()
        {
            listFigures.Clear();
            stackFigures.Clear();
        }

        public void RemoveLast()
        {
            if (listFigures.Count != 0)
            {
                stackFigures.Push(listFigures.Last());
                listFigures.Remove(listFigures.Last());
            }
        }

        public void ReturnLast()
        {
            if (stackFigures.Count != 0)
            {
                listFigures.Add(stackFigures.Pop());
            }
        }

        public void DrawFigures(Graphics graphics)
        {
            for (int i = 0; i < listFigures.Count; i++)
            {
                listFigures[i].Draw(graphics);
            }
        }

        public bool IsStackEmpty()
        {
            return (stackFigures.Count == 0);
        }
        public bool IsListEmpty()
        {
            return (listFigures.Count == 0);
        }



    }
}
