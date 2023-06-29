using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.Play();
            gamePlay.PlayerDieRoll();
            Console.ReadLine();
        }
    }
}
