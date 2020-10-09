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
                Game.askForName();
                Game.userWelcome();
                Game.askQuestions();
                Game.sayGoodbay();
                Game.playAgain();
            } while (Game.askPlayAgain == "a");
        }
    }
}
