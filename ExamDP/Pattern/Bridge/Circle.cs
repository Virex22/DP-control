using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.Bridge
{
    public class Circle : AbstractShape
    {
        public Circle(int size, Icolor color) : base(size, color)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Size : " + this.size);
            Console.ForegroundColor = color.GetColor();
            Console.WriteLine("   ###   ");
            Console.WriteLine("  #####  ");
            Console.WriteLine(" ####### ");
            Console.WriteLine("  #####  ");
            Console.WriteLine("   ###   ");
            Console.ResetColor();
        }
    }
}
    /*  DOCS 
using System;  
class ConsoleColorsClass
{
    static void Main(string[] args)
    {
        // Let's go through all Console colors and set them as foreground  
        foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
        {
            Console.ForegroundColor = color;
            Console.Clear();
            Console.WriteLine($ "Foreground color set to {color}");
        }
        Console.WriteLine("=====================================");
        Console.ForegroundColor = ConsoleColor.White;
        // Let's go through all Console colors and set them as background  
        foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
        {
            Console.BackgroundColor = color;
            Console.WriteLine($ "Background color set to {color}");
        }
        Console.WriteLine("=====================================");
        // Restore original colors  
        Console.ResetColor();
        Console.ReadKey();
    }
}
     */