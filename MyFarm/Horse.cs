using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Horse
    {

        public string NameHorse { get; set; }
        public string HorseEats { get; set; }
        public string HorseSays { get; set; }
        public string HorseLives { get; set; }

        public Horse(string name, string eats, string says, string lives)
        {
            NameHorse = name;
            HorseEats = eats;
            HorseSays = says;
            HorseLives = lives;
        }


    }
}
