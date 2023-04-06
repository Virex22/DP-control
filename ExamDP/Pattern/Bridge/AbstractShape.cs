using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.Bridge
{
    abstract public class AbstractShape
    {
        protected Icolor color;
        protected int size;

        protected AbstractShape(int size, Icolor color)
        {
            this.color = color;
            this.size = size;
        }

        abstract public void Draw();
    }
}
