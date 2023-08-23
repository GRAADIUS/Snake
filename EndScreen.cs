using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class EndScreen
    {
        public void Inscription(int b)
        {
            Console.SetWindowSize(51, 26);
            Console.SetBufferSize(51, 26);
            Console.Clear();
            string[] ss = new string[7];
            ss[0] = "ssssss s     s  ssss  ";
            ss[1] = "s      ss    s  s   s ";
            ss[2] = "s      s s   s  s    s";
            ss[3] = "ssss   s  s  s  s    s";
            ss[4] = "s      s   s s  s    s";
            ss[5] = "s      s    ss  s   s ";
            ss[6] = "ssssss s     s  ssss  ";

            for (int i = 0; i < ss.Length; i++)
                for (int j = 0; j < ss[i].Length; j++)
                {
                    Console.SetCursorPosition(j + 14, i + 1);
                    Console.Write(ss[i][j]);
                }
            Console.SetCursorPosition(17, 11);
            Console.Write("Sinu konto: {0}", b);
            Console.ReadLine();
        }
    }
}
