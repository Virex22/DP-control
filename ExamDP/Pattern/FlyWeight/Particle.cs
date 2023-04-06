using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.FlyWeight
{
    public class Particle
    {
        private int x;
        private int y;
        private Image image;
        private ImageFactory factory;

        public Particle(ImageFactory factory)
        {
            this.factory = factory;
        }

        public void setImage(string imageName)
        {
            this.image = factory.Get(imageName);
        }
        public void SetCoords(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Image getImage()
        {
            return this.image;
        }
    }
}
