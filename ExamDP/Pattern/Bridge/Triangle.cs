using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.Bridge
{
    public class Triangle : AbstractShape
    {
        public Triangle(int size, Icolor color) : base(size, color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Size : " + this.size);
            Console.ForegroundColor = color.GetColor();
            Console.WriteLine(" ##        ");
            Console.WriteLine(" ####      ");
            Console.WriteLine(" ######    ");
            Console.WriteLine(" ########  ");
            Console.WriteLine(" ##########");
            Console.ResetColor();
        }
    }
}
