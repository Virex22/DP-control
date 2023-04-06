using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDP.Pattern.Bridge
{
    public class Yellow : Icolor
    {
        public ConsoleColor GetColor()
        {
            return ConsoleColor.Yellow;
        }
    }
}
