using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Sheep
    {

        public string NameSheep { get; set; }
        public string SheepEats { get; set; }
        public string SheepSays { get; set; }
        public string SheepLives { get; set; }

        public Sheep(string name, string eats, string says, string lives)
        {
            NameSheep = name;
            SheepEats = eats;
            SheepSays = says;
            SheepLives = lives;
        }


    }
}
