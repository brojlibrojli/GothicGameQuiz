using System;
using System.Diagnostics.CodeAnalysis;

namespace GothicGameQuiz
{
    class Program
    {
        static void Main(string[] args)
            
        {
            string[] pytania = new string[5];
            string[] odpowiedzi = new string[5];
            string[] udzielone = new string[5];
            int punkty = 0;
            pytania[0] = "Ile glownych obozow znajduje sie wewnatrz koloni gorniczej w pierwszej czesci gothic?" + "\n" +
                "a. 3" + "\n" +
                "b. 4" + "\n" +
                "c. 5" + "\n";
            pytania[1] = "Jak na imie ma czlowiek pilnujacy wejscia do zamku w starym obozie?" + "\n" +
                "a. Thorlof" + "\n" +
                "b. Thorus" + "\n" +
                "c. Thorben" + "\n"; ;
            pytania[2] = "Jak nazywa sie slynne danie kucharza Snafa ze starego obozu?" + "\n" +
                "a. Potrawka z chrzaszcza" + "\n" +
                "b. Gularz Snaffa" + "\n" +
                "c. Mieso kopacza" + "\n"; ;
            pytania[3] = "Ile rozdzialow liczy gra gothic?" + "\n" +
                "a. 4" + "\n" +
                "b. 5" + "\n" +
                "c. 6" + "\n"; ;
            pytania[4] = "Do jakiej kasty nalezy Cor Angar w grze gothic 1?" + "\n" +
                "a. Straznicy" + "\n" +
                "b. Najemnicy" + "\n" +
                "c. Straznicy Swiatynni" + "\n"; ;

            odpowiedzi[0] = "a";
            odpowiedzi[1] = "b";
            odpowiedzi[2] = "a";
            odpowiedzi[3] = "c";
            odpowiedzi[4] = "c";


            Console.WriteLine("Witaj w grze Gothic Quiz." +
                " Przygotowalem 5 pytan. " + "\n" +
                "Za poprawne otrzymasz 1 pkt, za nie poprawne tracisz 1 pkt." +
                 " Powodzenia" + "\n");

            {

                {
                    for (int i = 0; i < pytania.Length; i++)
                    {
                        Console.WriteLine(pytania[i]);
                        udzielone[i] = Console.ReadLine();
                        if (udzielone[i] == odpowiedzi[i]) 
                        {
                            punkty++;
                            Console.WriteLine("\n"+"Poprawna odpowiedz, otrzymujesz jeden punkt: " + "aktualny wynik: " + punkty);
                        }
                        else
                        {
                            punkty--;
                            Console.WriteLine("\n"+"Nie poprawdna odpowiedz, tracisz punkt: " + "aktualny wynik: " + punkty);
                        }
                    }
                    Console.WriteLine("Koniec Quizu, zdobyles: " + punkty + "punktow");



                }


            }
        }
    }
}
