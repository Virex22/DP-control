using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.Memento
{
    public class Pixel
    {
        private int x;
        private int y;

        public int GetX()
        {
            return x;
        }
        public void SetX(int x)
        {
            this.x = x;
        }
        public int GetY()
        {
            return x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
    }
}
