using System;
using System.Collections.Generic;
using System.Linq;
using Test_Snake;

class Game
{
    static readonly int x = 80;
    static readonly int y = 26;
    static Walls walls;
    static FoodFactory foodFactory;
    static Snake snake;
    static Timer time;
    static Music music;

    static void Main()
    {
        Console.SetWindowSize(x + 1, y + 1);
        Console.SetBufferSize(x + 1, y + 1);
        Console.CursorVisible = false;
        walls = new Walls(x, y, '#');
        foodFactory = new FoodFactory(x, y, '@');
        foodFactory.CreateFood();
        snake = new Snake(x / 2, y / 2, 3);
        time = new Timer(Loop, null, 0, 150);
        music = new Music();
        music.playMusic();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.Rotation(key.Key);
            }
        }
        static void Loop(object obj)
        {
            if (walls.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
            {
                music.ifDeath();

                time.Change(0, Timeout.Infinite);
            }
            else if (snake.Eat(foodFactory.food))
            {
                foodFactory.CreateFood();
                music.ifEat();
            }
            else
            {
                snake.Move();
            }
        }
    }// Main()
}// class Game