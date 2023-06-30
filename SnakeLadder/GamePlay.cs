using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class GamePlay
    {
        public const int No_Play = 0,Ladder = 1,Snake = 2;
        public int PlayerPosition = 0;

        Random random = new Random();
        public int PlayerDieRoll()
        {
            int diceRoll = random.Next(1, 7);
            return diceRoll;    
        }
        public void CheckOption()
        {
            int diceRolling = this.PlayerDieRoll();
            int Option = random.Next(0, 3);
            switch (Option)
            {
                case No_Play:
                    break;
                case Ladder:
                    this.PlayerPosition += diceRolling;
                    break;
                case Snake:
                    this.PlayerPosition -= diceRolling;
                    break;
            }
            Console.WriteLine(this.PlayerPosition);
        }
    }
}
