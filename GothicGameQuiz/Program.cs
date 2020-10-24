using System;
using System.Diagnostics.CodeAnalysis;

namespace GothicGameQuiz
{
    class Program
    {
        static void Main(string[] args)

        {
            do
            {
                Player.askForName();
                Game.userWelcome();
                Game.askQuestions();
                Game.sayGoodbay();
                Game.playAgain();
                Player.points = 0;
            } while (Game.askPlayAgain == "a");
        }


    }
}
