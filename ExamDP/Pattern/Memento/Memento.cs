using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.Memento
{
    public class Memento
    {
        private List<Pixel>? state;

        public void setState(List<Pixel> pixels)
        {
            this.state = new List<Pixel>();
            foreach (Pixel pixel in pixels)
            {
                this.state.Add(pixel);
            }
        }
        public List<Pixel>? getState()
        {
            return this.state;
        }
    }
}
