using System;
namespace Jeu_du_serpent
{
	public class Player
	{
        public string Name { get; set; }
		public int PlayerPosition { get; set; }
        public bool IsWinner { get; set; }

        public Player(string name)
        {
            Name = name;
            PlayerPosition = 0;
            IsWinner = false;
        }

        public void AnnouncePosition()
        {
            Console.WriteLine($"\n{Name} est désormais en case {PlayerPosition}");
        }

        public void AnnounceWinner()
        {
            Console.WriteLine($"\nBravo {Name} vous avez gagné !!");
            IsWinner = true;
        }

    }
}

