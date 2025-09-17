using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticWoodsGame.PlayerData
{
    internal class AddNewPlayer
    {
        // Case 1
        public static void AddPlayer(List<Player> players)
        {
            Console.WriteLine("Dear player, enter your name: ");
            string playerName = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Dear {playerName}, choose your character class: 'Knight', 'Forest Mage', 'Shadow Rogue', 'Spirit Shaman'\n");

            Console.WriteLine("Class Knight:");
            Console.WriteLine("  HP: 150, Max HP: 150, Damage: 20, Gold: 100");
            Console.WriteLine("  A brave protector wearing enchanted armor, unafraid of dark creatures.\n");

            Console.WriteLine("Class Forest Mage:");
            Console.WriteLine("  HP: 100, Max HP: 120, Damage: 30, Gold: 150");
            Console.WriteLine("  A magic wielder who calls upon the forces of nature and forest spirits.\n");

            Console.WriteLine("Class Shadow Rogue:");
            Console.WriteLine("  HP: 120, Max HP: 120, Damage: 25, Gold: 120");
            Console.WriteLine("  A clever trickster who strikes from the shadows and moves unseen.\n");

            Console.WriteLine("Class Spirit Shaman:");
            Console.WriteLine("  HP: 130, Max HP: 130, Damage: 15, Gold: 130");
            Console.WriteLine("  A mystical healer in tune with the spirits, mending wounds and guiding allies.\n");

            Console.WriteLine("Enter your choice: ");
            string playerClass = Console.ReadLine().ToLower();

            int HP, MaxHP, Damage, Gold;

            switch (playerClass)
            {
                case "knight":
                    Console.WriteLine("\nYou have chosen the Knight class.\nA noble protector of the realm, clad in enchanted armor.\n");
                    HP = MaxHP = 150;
                    Damage = 20;
                    Gold = 100;
                    break;

                case "forest mage":
                case "mage":
                    Console.WriteLine("\nYou have chosen the Forest Mage class.\nA wielder of nature's magic, calling upon elemental forces.\n");
                    HP = MaxHP = 100;
                    Damage = 30;
                    Gold = 150;
                    break;

                case "shadow rogue":
                case "rogue":
                    Console.WriteLine("\nYou have chosen the Shadow Rogue class.\nA cunning trickster who strikes from shadows and vanishes like mist.\n");
                    HP = MaxHP = 120;
                    Damage = 25;
                    Gold = 120;
                    break;

                case "spirit shaman":
                case "shaman":
                    Console.WriteLine("\nYou have chosen the Spirit Shaman class.\nA mystical healer in tune with the spirits, guiding allies with enchanted rituals.\n");
                    HP = MaxHP = 130;
                    Damage = 15;
                    Gold = 130;
                    break;

                default:
                    Console.WriteLine("\nInvalid class choice. Defaulting to Knight.\n");
                    playerClass = "knight";
                    HP = MaxHP = 150;
                    Damage = 20;
                    Gold = 100;
                    break;
            }
            
            Console.WriteLine($"Class: {playerClass}, HP: {HP}/{MaxHP}, Damage: {Damage}, Gold: {Gold}\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("The forest welcomes you, hero, and the winds whisper tales of your destiny...\n");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Player playerToAdd = new Player
            {
                PlayerName = playerName,
                PlayerClass = playerClass,
                HP = HP,
                MaxHP = MaxHP,
                Damage = Damage,
                Gold = Gold
            };

            players.Add(playerToAdd);

        }
    }
}
