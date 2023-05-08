﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class horisontalLine
    {
        List<point> pList;

        public horisontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(point p in pList) 
            {
                p.Draw();
            }
        }

    }
}
