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
            point p1 = new point(1, 3, '=');
            p1.Draw();

            point p2 = new point(1, 4, '=');
            p2.Draw();
        }
    }
}
