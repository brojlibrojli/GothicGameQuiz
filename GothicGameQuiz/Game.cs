using System;

namespace GothicGameQuiz
{
    static class Game
    {
        public static string[] questions = new string[15];
        public static string[] answers = new string[15];
        public static string[] answersGiven = new string[15];
        public static string askPlayAgain = "";






        public static void userWelcome()
        {
            Console.WriteLine("\n" + "Witaj w grze Gothic Quiz " + Player.name + "!" + "\n" +
                "Przygotowalem 5 pytan." + "\n" +
                "Za poprawne otrzymasz 1 pkt," + "\n" +
                "za bledne tracisz 1 pkt." + "\n" +
                "Udzielaj tylko odpowiedz a, b lub c." + "\n" +
                "Powodzenia" + "!" + "\n");
        }

        public static void askQuestions()
        {
            questions[0] = "\n" + "Pytanie 1." + "\n" + "Ile glownych obozow znajduje sie wewnatrz koloni gorniczej w pierwszej czesci gothic?" + "\n" +
                "A. 3" + "\n" +
                "B. 4" + "\n" +
                "C. 5" + "\n";
            questions[1] = "\n" + "Pytanie 2." + "\n" + "Jak na imie ma czlowiek pilnujacy wejscia do zamku w starym obozie?" + "\n" +
                "A. Thorlof" + "\n" +
                "B. Thorus" + "\n" +
                "C. Thorben" + "\n"; ;
            questions[2] = "\n" + "Pytanie 3." + "\n" + "Jak nazywa sie slynne danie kucharza Snafa ze starego obozu?" + "\n" +
                "A. Potrawka z chrzaszcza" + "\n" +
                "B. Gularz Snaffa" + "\n" +
                "C. Mieso kopacza" + "\n"; ;
            questions[3] = "\n" + "Pytanie 4." + "\n" + "Ile rozdzialow liczy gra gothic?" + "\n" +
                "A. 4" + "\n" +
                "B. 5" + "\n" +
                "C. 6" + "\n"; ;
            questions[4] = "\n" + "Pytanie 5." + "\n" + "Do jakiej kasty nalezy Cor Angar w grze gothic 1?" + "\n" +
                "A. Straznicy" + "\n" +
                "B. Najemnicy" + "\n" +
                "C. Straznicy Swiatynni" + "\n";
            questions[5] = "\n" + "Pytanie 6." + "\n" + "Ile sily trzeba aby wladac bronia Uriziel?" + "\n" +
                "A. 30" + "\n" +
                "B. 60" + "\n" +
                "C. 90" + "\n";
            questions[6] = "\n" + "Pytanie 7." + "\n" + "Ilu magow tworzylo magiczna bariere w grze gothic 1?" + "\n" +
                "A. 12" + "\n" +
                "B. 13" + "\n" +
                "C. 14" + "\n";
            questions[7] = "\n" + "Pytanie 8." + "\n" + "Ktory przedmiot z podanych jest najbardziej wartosciowy w grze gothic?" + "\n" +
                "A. Jezyk ognistego jaszczura" + "\n" +
                "B. Skora trola" + "\n" +
                "C. Kiel cieniostwora" + "\n";
            questions[8] = "\n" + "Pytanie 9." + "\n" + "Ile wynosi maksymalna wartosc sily zrecznosci i many jaka mozemy zdobyc wydajac punkty nauki?" + "\n" +
                "A. 100" + "\n" +
                "B. 150" + "\n" +
                "C. 200" + "\n";
            questions[9] = "\n" + "Pytanie 10." + "\n" + "Jak nazywa sie pierscien zapewniajacy odpornosc na wszystkie zrodla obrazen w grze gothic 1?" + "\n" +
                "A. Pierscien wytrwalosci" + "\n" +
                "B. Pierscien niewzruszonosci" + "\n" +
                "C. Pomniejszy pierscien niezwyciezonosci" + "\n";
            questions[10] = "\n" + "Pytanie 11." + "\n" + "Jak nazywa sie miecz ktorym posluguje sie Gomez w grze gothic 1?" + "\n" +
                "A. Gniew Innosa" + "\n" +
                "B. Czerwony Wiatr" + "\n" +
                "C. Miecz Gomeza" + "\n";
            questions[11] = "\n" + "Pytanie 12." + "\n" + "Ile obrazen zadaje najlepszy luk w grze gothic 2 Noc Kruka?" + "\n" +
                "A. 160" + "\n" +
                "B. 180" + "\n" +
                "C. 200" + "\n";
            questions[12] = "\n" + "Pytanie 13." + "\n" + "Ktory kowal moze ulepszyc pancerz z magicznej rudy w grze gothic 1?" + "\n" +
                "A. Huno" + "\n" +
                "B. Stone" + "\n" +
                "C. Larson" + "\n";
            questions[13] = "\n" + "Pytanie 14." + "\n" + "Jaka odpornosc zapewnia Talizman Orkow w grze gothic 1?" + "\n" +
                "A. Ochrona przed Magia" + "\n" +
                "B. Ochrona przed Ogniem" + "\n" +
                "C. Ochrona przed Bronia" + "\n";
            questions[14] = "\n" + "Pytanie 15." + "\n" + "Po przekroczeniu jakiego progu zrecznosci w grze gothic 2 Noc Kruka" + "\n" +
                "otrzymujemy umiejetnosc akrobatyki?" + "\n" +
                "A. 80" + "\n" +
                "B. 90" + "\n" +
                "C. 100" + "\n";

            Game.answers[0] = "a";
            Game.answers[1] = "b";
            Game.answers[2] = "a";
            Game.answers[3] = "c";
            Game.answers[4] = "c";
            Game.answers[5] = "a";
            Game.answers[6] = "b";
            Game.answers[7] = "c";
            Game.answers[8] = "a";
            Game.answers[9] = "c";
            Game.answers[10] = "a";
            Game.answers[11] = "a";
            Game.answers[12] = "b";
            Game.answers[13] = "b";
            Game.answers[14] = "b";

            string[] CorrectFormatABC = new string[6] { "a", "b", "c", "A", "B", "C" };
            int questionsLength = Game.questions.Length;
            bool isCorrectFormatABC = true;

            for (int i = 0; i < questionsLength; i++)
            {
                Console.WriteLine(questions[i]);
                Game.answersGiven[i] = Console.ReadLine().ToLower();

                for (int j = 0; j < CorrectFormatABC.Length; j++)
                {
                    isCorrectFormatABC = Game.answersGiven[i] == CorrectFormatABC[j];
                    if (isCorrectFormatABC)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                while (!isCorrectFormatABC)
                {
                    Console.WriteLine("Nie poprawny format odpowiedzi." + "\n" +
                    "Wprowadz a, b lub c");
                    Game.answersGiven[i] = Console.ReadLine().ToLower();
                    for (int j = 0; j < CorrectFormatABC.Length; j++)
                    {
                        isCorrectFormatABC = Game.answersGiven[i] == CorrectFormatABC[j];
                        if (isCorrectFormatABC)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
                if ((answersGiven[i] == Game.answers[i]) && (isCorrectFormatABC))
                {
                    correctAnswer();
                }
                else
                {
                    uncorrectAnswer();
                }
            }
        }

        public static void correctAnswer()
        {

            Player.points++;
            Console.WriteLine("Poprawna odpowiedź." + "\n" + "otrzymujesz 1 punkt" + "\n"
                + "Twoj aktualny wynik to: " + Player.points);
        }

        public static void uncorrectAnswer()
        {
            Player.points--;
            Console.WriteLine("Bledna odpowiedź." + "\n" + "tracisz 1 punkt" + "\n"
                + "Twoj aktualny wynik to: " + Player.points);
        }

        public static void sayGoodbay()
        {
            Console.WriteLine("Dziekuje za gre " + Player.name + "." + "\n"
                + "Twoj koncowy wynik to: " + Player.points + " punktow." + "\n" + "\n");


        }

        public static void playAgain()
        {
            Console.WriteLine("Czy chcesz zagrac ponownie ? " + "\n"
                + "A. TAK" + "\n"
                + "B. NIE");
            Game.askPlayAgain = Console.ReadLine().ToLower();
            Console.Clear();
        }
    }
}

