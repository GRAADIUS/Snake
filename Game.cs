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
        static Music music;
        static EndScreen endScreen;
        public void Play(int x, int y)
        {
            Console.Clear();
            Console.CursorVisible = false;
            walls = new Walls(x, y, '#');
            foodFactory = new FoodFactory(x, y, '@');
            foodFactory.CreateFood();
            snake = new Snake(x / 2, y / 2, 4);
            int score = 0;
            int speed = 150;
            music = new Music();
            endScreen = new EndScreen();
            music.playMusic();
            Loop();
            void Loop()
            {
                while (true)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.Rotation(key.Key);
                    }
                    if (walls.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
                    {
                        music.ifDeath();
                        endScreen.Inscription(score);
                        break;
                    }
                    else if (snake.Eat(foodFactory.food))
                    {
                        foodFactory.CreateFood();
                        ++score;
                        if (score >= 15 && score <= 65)
                            --speed;
                        music.ifEat();
                    }
                    else
                    {
                        snake.Move();
                    }
                    Thread.Sleep(speed);
                }
            }
        }
    }
}