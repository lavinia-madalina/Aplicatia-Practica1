using System;
using System.Collections.Generic;
using System.Text;

using static System.Console; // chestia asta ma scapa de scris Console.WriteLine BWAHAHAHAH
// acuma scriu numai WriteLine

namespace Quizgame
{
    class Game
    {
        // constructor ul
        private string Gametitle = "mor cu zile";
        private string Description = "Intrebarile nu trebuie luate ca atare\nAcesta este doar un pamflet\nEnjoy :)\n";
        public Player CurrentPlayer;
        private TriviaItem MorTrivia;
        public Game()
        {
           //MorTrivia = new TriviaItem("eu ma dau batuta - da sau nu?","da");
        }
        // play method
        public void Play()
        {
<<<<<<< HEAD
            Console.WriteLine("Bine ati venit la joculet");
            Console.WriteLine("Press oriunde ca sa iesi");
            Console.WriteLine("Press oriunde ca sa iesi");
            Console.ReadKey();
=======
            Title = Gametitle; 
            WriteLine($"Bine v-am gasit la {Gametitle}");
            WriteLine(Description);
            WriteLine("Introdu numele tau aici:");
            string PlayerName;
            PlayerName= ReadLine();
            //aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa casca ochii la Line sa fie cu l mare
            CurrentPlayer = new Player(PlayerName);
            WriteLine($"Welcome to {Gametitle}, {CurrentPlayer.Name}!");
            WriteLine($"Punctajul tau initial este {CurrentPlayer.Score}!");
            WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA");
            //MorTrivia.AskQuestion();
            ReadKey();
>>>>>>> update
        }
    }
}