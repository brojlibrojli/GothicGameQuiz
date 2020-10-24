using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace GothicGameQuiz
{
    static class Player
    {
        public static string name = "brak";
        public static int points = 0;
        
        public static void askForName()
        {
            Console.WriteLine("Podaj imie (Powinno zawierac od 3 do 12 znakow): ");
            Player.name = Console.ReadLine();
            //do
            //{
            //    if ((Player.name.Length < 3) || (Player.name.Length > 12))
            //    {
            //        Console.WriteLine("Nie poprawny format imienia, powinno zawierac od 3 do 12 znakow." + "\n" +
            //            "Wprowadz ponownie: ");
            //        Player.name = Console.ReadLine();
            //    }
            //} while ((Player.name.Length > 3) || (Player.name.Length < 12));
        }
    }
}
    

