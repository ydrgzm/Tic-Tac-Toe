using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Classes
{
    class Player
    {
        public String Name { get; set; }
        public int Score { get; set; }
        public int Symbol { get;}

        public Player(int symbol)
        {
            Symbol = symbol;
        }
    }
}
