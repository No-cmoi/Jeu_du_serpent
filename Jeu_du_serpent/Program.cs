using System;
using Jeu_du_serpent;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Joueur 1, Entrez votrez nom :");
            Player player1 = new Player(Console.ReadLine());

            Console.WriteLine("Joueur 2, Entrez votre nom :");
            Player player2 = new Player(Console.ReadLine());

            string replay = "oui";

            while (replay == "oui")
            {
                player1.PlayerPosition = 0;
                player2.PlayerPosition = 0;

                while (true)
                {
                    player1.PlayerPosition = Gameboard.PlayGame(player1);

                    if (player1.PlayerPosition == Gameboard.TotalSquares)
                    {
                        player1.AnnouncePosition();
                        player2.AnnounceWinner();
                        break;
                    }
                    else
                    {
                        player1.AnnouncePosition();
                    }


                    player2.PlayerPosition = Gameboard.PlayGame(player2);
                    if (player2.PlayerPosition == Gameboard.TotalSquares)
                    {
                        player2.AnnouncePosition();
                        player2.AnnounceWinner();
                        break;
                    }
                    else
                    {
                        player2.AnnouncePosition();

                    }

                }

                Console.WriteLine("\nVoulez-vous jouer une nouvelle partie ? oui ? non ?");
                replay = Console.ReadLine();

            }
            Console.WriteLine("\n\n\n\t\t\t\t\tGAME OVER");
        }
    }
}