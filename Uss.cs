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

            List<int> numlist = new List<int>();

            numlist.Add(1);
            numlist.Add(2);
            numlist.Add(3);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.RemoveAt(0);

            List<point> pList = new List<point>();
            pList.Add(p1);
            pList.Add(p2);
        }
    }
}
