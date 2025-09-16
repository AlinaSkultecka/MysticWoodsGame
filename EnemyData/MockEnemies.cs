using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticWoodsGame.EnemyData
{
   public class EnemyLevel1 : EnemyData.Enemy { }
   public class EnemyLevel2 : EnemyData.Enemy { }
   public class EnemyLevel3 : EnemyData.Enemy { }

    public class MockEnemies
    {
         public static EnemyLevel1[] Enemies1 = {
            new EnemyLevel1 { EnemyName = "Mischievous Rat", HP = 35, Damage = 10, Gold = 5 },
            new EnemyLevel1 { EnemyName = "Slime Sprite", HP = 50, Damage = 10, Gold = 10 },
            new EnemyLevel1 { EnemyName = "Forest Goblin", HP = 60, Damage = 15, Gold = 20 }
            };
         public static EnemyLevel2[] Enemies2 = {
            new EnemyLevel2 { EnemyName = "Enchanted Spider", HP = 90, Damage = 20, Gold = 30 },
            new EnemyLevel2 { EnemyName = "Skeleton Knight", HP = 100, Damage = 25, Gold = 30 },
            new EnemyLevel2 { EnemyName = "Giant Wolf", HP = 110, Damage = 25, Gold = 25 },
            new EnemyLevel2 { EnemyName = "Bandit Rogue", HP = 120, Damage = 30, Gold = 40 },
            new EnemyLevel2 { EnemyName = "Vampire Bat", HP = 120, Damage = 35, Gold = 50 }

            };
         public static EnemyLevel3[] Enemies3 = {
            new EnemyLevel3 { EnemyName = "Forest Witch", HP = 140, Damage = 50, Gold = 80 },
            new EnemyLevel3 { EnemyName = "Dark Sorcerer", HP = 150, Damage = 50, Gold = 70 },
            new EnemyLevel3 { EnemyName = "Fire Elemental", HP = 160, Damage = 55, Gold = 90 },
            new EnemyLevel3 { EnemyName = "Orc Brute", HP = 180, Damage = 40, Gold = 60 },
            new EnemyLevel3 { EnemyName = "Forest Troll", HP = 200, Damage = 45, Gold = 80 },
            new EnemyLevel3 { EnemyName = "Bandit Leader", HP = 220, Damage = 60, Gold = 120 },
            new EnemyLevel3 { EnemyName = "Crystal Golem", HP = 250, Damage = 45, Gold = 150 }
            };
        
    }
}
