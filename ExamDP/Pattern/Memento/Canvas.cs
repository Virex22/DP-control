using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.Memento
{
    public class Canvas
    {
        private List<Pixel> pixels = new List<Pixel>();
        private Stack<Memento> lastMemento = new Stack<Memento>();

        public Memento PlacePixel(Pixel pixel)
        {
            Memento memento = new Memento();
            memento.setState(this.pixels);
            this.pixels.Add(pixel);
            this.lastMemento.Push(memento);
            return memento;
        }

        public Memento RemovePixel(Pixel pixel)
        {
            Memento memento = new Memento();
            memento.setState(this.pixels);
            this.pixels.Remove(pixel);
            this.lastMemento.Push(memento);
            return memento;
        }

        public void Undo()
        {
            try { 
                Memento? last = this.lastMemento.Pop();
                Reset(last);
            }
            catch (Exception e)
            {
                Console.WriteLine("Impossible de revenir en arriere");
                return;
            }
        }
        public void Reset(Memento memento)
        {
            List<Pixel>? state = memento.getState();
            if (state != null)
                this.pixels = state.ToList();
            else
                Console.WriteLine("Impossible de charger le memento");
        }
        public void Draw()
        {
            Console.WriteLine("Pixel on : ");
            foreach (var pixel in this.pixels)
                Console.WriteLine("   x=" + pixel.GetX() + "y=" + pixel.GetY());
        }

    }
}
