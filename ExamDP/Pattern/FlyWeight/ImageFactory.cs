using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.FlyWeight
{
    public class ImageFactory
    {
        private Dictionary<string, Image> images = new Dictionary<string, Image>();

        public Image Get(string imageName)
        {
            if (this.images.ContainsKey(imageName))
                return this.images[imageName];
            Image image = new Image();
            image.data = imageName;
            this.images.Add(imageName, image);
            return image;
        }
    }
}
