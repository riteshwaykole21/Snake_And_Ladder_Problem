using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class GamePlay
    {
        public void Play()
        {
            int PlayerPosition = 0;
            Console.WriteLine("Lets Start The Game");
            Console.WriteLine($"Player Position Is {PlayerPosition}");
        }
        public void PlayerDieRoll()
        {
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            Console.WriteLine($"The Player Get Number {diceRoll} on Die Roll");
        }
    }
}
