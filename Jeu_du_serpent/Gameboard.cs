using System;
namespace Jeu_du_serpent
{
	public class Gameboard
	{
		public static int TotalSquares = 50;

		public static int PlayGame(Player player)
		{
            if (player.PlayerPosition < TotalSquares)
            {
                Random random = new Random();
                int diceRoll = random.Next(1, 7);
                player.PlayerPosition += diceRoll;
                Console.WriteLine($"\n\n\n{player.Name} ,appuyez sur une touche pour lancer le dé");
                string lancerDeDes = Console.ReadLine();


                Console.WriteLine($"\n{player.Name} lance le dé et a fait un {diceRoll}");

                if (player.PlayerPosition > TotalSquares)
                {
                    player.PlayerPosition = 25;
                    Console.WriteLine($"Désolé {player.Name} vous repartez en case {player.PlayerPosition}");
                }


                switch (player.PlayerPosition)
                {
                    case 37:
                        {
                            Console.WriteLine("\n CASE PIEGE !!!! vous repartez en case 12");
                            player.PlayerPosition = 12;
                            break;
                        }
                    case 14:
                        {
                            Console.WriteLine("\n CASE PIEGE !!!! vous repartez en case 5");
                            player.PlayerPosition = 5;
                            break;
                        }
                    case 46:
                        {
                            Console.WriteLine("\n CASE PIEGE !!!! vous repartez en case 33");
                            player.PlayerPosition = 33;
                            break;
                        }
                    case 20:
                        {
                            Console.WriteLine("\n CASE BONUS !!!! vous foncez en case 35");
                            player.PlayerPosition = 35;
                            break;
                        }
                    case 31:
                        {
                            Console.WriteLine("\n CASE BONUS !!!! vous foncez en case 43");
                            player.PlayerPosition = 43;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n CASE BONUS !!!! vous foncez en case 17");
                            player.PlayerPosition = 17;
                            break;
                        }
                }
            }
            return player.PlayerPosition;
        }

    }
}


