using System;
using System.Collections.Generic;
using System.Text;

namespace Quizgame
{
    class Player
    {
        public string Name;
        public int Score;
        public Player(string PlayerName)
        {
            Name = PlayerName;
            Score = 0;
        }
    }
}