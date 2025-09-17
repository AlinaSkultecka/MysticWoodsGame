using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysticWoodsGame.EnemyData
{
    public class Enemy
    {
        public string EnemyName { get; set; }
        public int HP { get; set; }
        public int BaseHP { get; set; }
        public int Damage { get; set; }
        public int Gold { get; set; }
        public bool Defeated { get; set; } = false;
        public string Class
        {
            get
            {
                if (BaseHP <= 60) return "1 level of villainy.";
                else if (BaseHP <= 100) return "2 level of villainy.";
                else return "advanced level of villainy";
            }
        }
    }
}
