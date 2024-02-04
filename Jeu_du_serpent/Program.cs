// See https://aka.ms/new-console-template for more information

Console.WriteLine("Joueur 1, Entrez votrez nom :");
string player1 = Console.ReadLine();

Console.WriteLine("Joueur 2, Entrez votre nom :");
string player2 = Console.ReadLine();

int nombreDeCases = 50;
string replay = "oui";

while (replay == "oui")
{
    int player1position = 0;
    int player2position = 0;

    while (true)
    {
        player1position = PlayGame(player1, player1position);

        if (player1position == nombreDeCases)
        {
            announcePosition(player1, player1position);
            winner(player1);
            break;
        }
        else
        {
            announcePosition(player1, player1position);
        }

        player2position = PlayGame(player2, player2position);
        if (player2position == nombreDeCases)
        {
            announcePosition(player2, player2position);
            winner(player2);
            break;
        }
        else
        {
            announcePosition(player2, player2position);

        }

    }

    Console.WriteLine("\nVoulez-vous jouer une nouvelle partie ? oui ? non ?");
    replay = Console.ReadLine();

}
Console.WriteLine("\n\n\n\t\t\t\t\t\t\tGAME OVER");



static int PlayGame(string player, int position)
{
    int nombreDeCases = 50;
    if (position < nombreDeCases)
    {
        Random random = new Random();
        int diceRoll = random.Next(1, 7);
        position += diceRoll;
        Console.WriteLine("\n\n\n" + player + " ,appuyez sur une touche pour lancer le dé");
        string lancerDeDes = Console.ReadLine();


        Console.WriteLine("\n" + player + " lance le dé et a fait un " + diceRoll);

        if (position > nombreDeCases)
        {
            position = 25;
            Console.WriteLine("Désolé " + player + " vous repartez en case " + position);
        }


        switch (position)
        {
            case 37:
                {
                    Console.WriteLine("\n CASE PIEGE !!!! vous repartez en case 12");
                    position = 12;
                    break;
                }
            case 14:
                {
                    Console.WriteLine("\n CASE PIEGE !!!! vous repartez en case 5");
                    position = 5;
                    break;
                }
            case 46:
                {
                    Console.WriteLine("\n CASE PIEGE !!!! vous repartez en case 33");
                    position = 33;
                    break;
                }
            case 20:
                {
                    Console.WriteLine("\n CASE BONUS !!!! vous foncez en case 35");
                    position = 35;
                    break;
                }
            case 31:
                {
                    Console.WriteLine("\n CASE BONUS !!!! vous foncez en case 43");
                    position = 43;
                    break;
                }
            case 2:
                {
                    Console.WriteLine("\n CASE BONUS !!!! vous foncez en case 17");
                    position = 17;
                    break;
                }
        }
    }
    return position;
}

static void announcePosition(string player, int position)
{
    Console.WriteLine("\n" + player + " est désormais en case " + position);
}

static void winner(string player)
{
    Console.WriteLine("\n\n\nBRAVO " + player + " vous avez gagné !!!");

}