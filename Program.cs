using MysticWoodsGame.PlayerData;
using System.Numerics;

namespace MysticWoodsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PlayerData.Player > players = new List<PlayerData.Player>();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=== Mystic Woods: A Hero’s Journey ===\n");
            Console.ResetColor();

            Console.WriteLine("                   _                               ");
            Console.WriteLine("                 _(_)_                        ");
            Console.WriteLine("   @@@@         (_)@(_)  vVVVv    _     @@@@         ");
            Console.WriteLine("  @@()@@  wWWWw   (_)\\   (___)  _(_)_  @@()@@        ");
            Console.WriteLine("   @@@@   (___)     `|/    Y   (_)@(_)  @@@@           ");
            Console.WriteLine("    /       Y       \\|/    |     /(_)    \\|              ");
            Console.WriteLine("  \\ |     \\ |/       | / \\ | /  \\|/       |/          ");
            Console.WriteLine("  \\\\|//   \\\\|///  \\\\\\|//\\\\\\|/// \\|///  \\\\\\|//  ");
            Console.WriteLine(" ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");
            Console.WriteLine("In lands of mist and magic deep,");
            Console.WriteLine("The Mystic Woods its secrets keep.");
            Console.WriteLine("Wondrous creatures, treasures untold,");
            Console.WriteLine("Await the brave, the daring, the bold.\n");

            Console.WriteLine("Step forth, hero, your journey begins,");
            Console.WriteLine("With courage strong, face dangers and wins...\n");

            Console.WriteLine("Press any key to enter the Mystic Woods...");
            Console.ReadKey();
            Console.Clear();

            AddNewPlayer.AddPlayer(players);

            bool running = true;
            while (running)

            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=== Mystic Woods: Hero's Journey ===\n");
                Console.ResetColor();
                Console.WriteLine("Choose your path, brave adventurer:\n");
                Console.WriteLine("[1] Go on an Adventure");       // Adventure
                Console.WriteLine("[2] Take a Rest");             // Take a break
                Console.WriteLine("[3] Check Your Status");       // Check your status
                Console.WriteLine("[4] Leave the Forest");        // Exit the game
                Console.Write("\nEnter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GameHelper.Adventure(players);
                        break;
                    case 2:
                        GameHelper.TakeBreak(players);
                        break;
                    case 3:
                        GameHelper.CheckStatus(players);
                        break;
                    case 4:
                        Console.WriteLine("Exit the Mystic Woods");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

            }
        }
    }
}
