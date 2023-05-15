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
            Console.SetWindowSize(50, 25);
            Console.SetBufferSize(50, 25);

            HorisontalLine upLine = new HorisontalLine(0, 48, 0, '¤');
            upLine.Drow();
            HorisontalLine downLine = new HorisontalLine(0, 48, 24, '¤');
            downLine.Drow();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '¤');
            leftLine.Drow();
            VerticalLine rightLine = new VerticalLine(0, 24, 48, '¤');
            rightLine.Drow();
            
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow(); //

            FoodCreator foodCreator = new FoodCreator(20, 20, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}