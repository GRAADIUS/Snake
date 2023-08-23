using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Uno
    {/*
        static EndScreen endScreen;
        static void Main()
        {
            endScreen = new EndScreen();
            endScreen.Inscription();
        }
        */
        static StartScreen startScreen;
        static void Main()
        {
            startScreen = new StartScreen();
            startScreen.Inscription();
        }
    }
}
