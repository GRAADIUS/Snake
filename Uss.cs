using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            horisontalLine upLine = new horisontalLine(0, 78, 0, '+');
            upLine.Drow();
            horisontalLine downLine = new horisontalLine(0, 78, 24, '+');
            downLine.Drow();
            verticalLine leftLine = new verticalLine(0, 24, 0, '+');
            leftLine.Drow();
            verticalLine rightLine = new verticalLine(0, 24, 78, '+');
            rightLine.Drow();





            Console.ReadLine();
        }
    }
}
