using MysticWoodsGame.EnemyData;
using MysticWoodsGame.PlayerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticWoodsGame
{
    internal class GameHelper
    {
        //Case1 - Adventure
        public static void Adventure(List<PlayerData.Player> players)
        {
            Random random = new Random();
            int turn;
            Enemy chosenEnemy;
            for (turn = 1; turn <= 3; turn++)
            {
                // Pick a random enemy that is not defeated in the right enemy level
                if (turn == 1)
                {
                    do
                    {
                        int index = random.Next(MockEnemies.Enemies1.Length);
                        chosenEnemy = MockEnemies.Enemies1[index];
                    }
                    while (chosenEnemy.Defeated);
                }
                else if (turn == 2)
                {
                    do
                    {
                        int index = random.Next(MockEnemies.Enemies2.Length);
                        chosenEnemy = MockEnemies.Enemies2[index];
                    }
                    while (chosenEnemy.Defeated);
                }
                else
                {
                    do
                    {
                        int index = random.Next(MockEnemies.Enemies3.Length);
                        chosenEnemy = MockEnemies.Enemies3[index];
                    }
                    while (chosenEnemy.Defeated);
                }

                if (MockEnemies.Enemies3.Length == 0)
                {
                    Console.WriteLine("You have defeated all the enemies!");
                }


                bool playing = true;
                bool canHeal = true;
                while (playing)
                {
                    Console.Clear();

                    Console.WriteLine($"A wild {chosenEnemy.EnemyName} appears! The enemy has {chosenEnemy.Class}");
                    Console.WriteLine($"HP: {chosenEnemy.HP}, Damage: {chosenEnemy.Damage}, Gold: {chosenEnemy.Gold}\n");

                    Console.WriteLine("What will you do, hero?");
                    Console.WriteLine("[1] Strike the enemy");   // Attack
                    Console.WriteLine("[2] Use magic to heal"); // Heal
                    Console.WriteLine("[3] Flee away\n");              // Run
                    Console.Write("Enter your choice: ");
                    int round = int.Parse(Console.ReadLine());

                    switch (round)
                    {
                        case 1:
                            Console.WriteLine("\nYou swing your weapon at the enemy!"); ;
                            // Player attacks enemy
                            chosenEnemy.HP -= players[0].Damage;
                            Console.WriteLine($"Your attack hits the {chosenEnemy.EnemyName}, dealing {players[0].Damage} damage!\n");
                            if (chosenEnemy.HP <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("******************************************************");
                                Console.ResetColor();
                                Console.WriteLine($"The {chosenEnemy.EnemyName} falls!  VICTORY IS YOURS, BRAVE HERO!");
                                players[0].Gold += chosenEnemy.Gold;
                                Console.WriteLine($"You collect {chosenEnemy.Gold} gold. You now have {players[0].Gold} gold, hero!");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("******************************************************");
                                Console.ResetColor();
                                chosenEnemy.Defeated = true;
                                playing = false;
                                break;
                            }
                            // Enamy attacks player
                            players[0].HP -= chosenEnemy.Damage;
                            Console.WriteLine($"The {chosenEnemy.EnemyName} strikes you. You got {chosenEnemy.Damage} damage!");
                            if (players[0].HP <= 0)
                            {
                                Console.WriteLine("You have fallen in battle, hero… Your journey ends here.");
                                playing = false;
                            }
                            canHeal = true;
                            break;

                        case 2:
                            if (canHeal)
                            {
                                Console.WriteLine("\nYou call upon your magic to heal and restore your strength!");
                                players[0].HP += 15;
                                Console.WriteLine("Your wounds mend, and your strength grows by 15 points!");
                                canHeal = false;
                            }
                            else
                            {
                                Console.WriteLine("You cannot heal right now! Try another action.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("\nYou decide to flee, slipping away through the shadows of the forest!");
                            playing = false;
                            break;

                        default:
                            Console.WriteLine("That choice cannot be made, brave hero. Try again!");
                            break;
                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }

        }

        //Case2 - Take a break
        public static void TakeBreak(List<Player> players)
        {
            Console.Clear();

            Console.WriteLine("You chose to take a break in the magical forest!\n");
            Console.WriteLine("You hear the gentle song of a nearby stream, its water sparkling as if touched by starlight.");
            Console.WriteLine("Ancient trees stand tall around you, their leaves whispering secrets of forgotten ages.");
            Console.WriteLine("For a moment, you feel safe and your strength slowly returns.\n");
            players[0].HP += players[0].MaxHP;
            Console.WriteLine("Your wounds fade away, and your strength is fully restored!\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //Case3 - Check your status
        public static void CheckStatus(List<Player> players)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== Player Status: ===\n");
            Console.ResetColor();
            Console.WriteLine($"Player name: {players[0].PlayerName}");
            Console.WriteLine($"Player class: {players[0].PlayerClass}");
            Console.WriteLine($"Palyer level of HP: {players[0].HP}/{players[0].MaxHP}");
            Console.WriteLine($"Player level of Damage: {players[0].Damage}");
            Console.WriteLine($"Player level of Gold: {players[0].Gold}\n");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
