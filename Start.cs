using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Start
    {
        static StartScreen startScreen;
        static void Main()
        {
            startScreen = new StartScreen();
            startScreen.Inscription();
        }
    }
}
