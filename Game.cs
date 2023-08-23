using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Snake;

namespace Snake
{
    class Game
    {
        int score = 0;

        static Walls walls;
        static FoodFactory foodFactory;
        static Snake snake;
        static Timer time;
        static Music music;
        static EndScreen endScreen;
        static Meaning meaning;
        public void Play(int x, int y)
        {
            Console.Clear();
            Console.CursorVisible = false;
            walls = new Walls(x, y, '#');
            foodFactory = new FoodFactory(x, y, '@');
            foodFactory.CreateFood();
            snake = new Snake(x / 2, y / 2, 4);
            int b = 0;
            time = new Timer(Loop, null, 0, 150);
            music = new Music();
            meaning = new Meaning();
            endScreen = new EndScreen();
            music.playMusic();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Rotation(key.Key);
                }
            }
            void Loop(object obj)
            {
                if (walls.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
                {
                    music.ifDeath();
                    endScreen.Inscription(b);
                }
                else if (snake.Eat(foodFactory.food))
                {
                    foodFactory.CreateFood();
                    //meaning.updateScore();
                    ++b;
                    music.ifEat();
                }
                else
                {
                    snake.Move();
                }
            }
        }
    }
}