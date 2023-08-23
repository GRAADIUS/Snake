using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class StartScreen
    {
        public readonly int x = 50;
        public readonly int y = 25;
        static Game game;

        public void Inscription()
        {
            Console.SetWindowSize(x + 1, y + 1);
            Console.SetBufferSize(x + 1, y + 1);
            string[] ss = new string[8];
            ss[0] = "  sss   s    s   sss s   s   ssssss";
            ss[1] = " s   s  s    s  s  s s  s    s     ";
            ss[2] = "  s     ss   s s   s s s     s     ";
            ss[3] = "   s    s s  s sssss ss      ssssss";
            ss[4] = "    s   s  s s s   s s s     s     ";
            ss[5] = "     s  s   ss s   s s  s    s     ";
            ss[6] = "s    s  s    s s   s s   s   s     ";
            ss[7] = "  sss   s    s s   s s    s  ssssss";

            for (int i = 0; i < ss.Length; i++)
                for (int j = 0; j < ss[i].Length; j++)
                {
                    Console.SetCursorPosition(j + 8, i + 5);
                    Console.Write(ss[i][j]);
                }
            Console.SetCursorPosition(29, 25);
            Console.Write("Press Enter to start");
            Console.ReadLine();
            game = new Game();
            game.Play(x, y);
        }
    }
}
