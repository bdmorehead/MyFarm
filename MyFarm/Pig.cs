using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Pig
    {

        public string NamePig { get; set; }
        public string PigEats { get; set; }
        public string PigSays { get; set; }
        public string PigLives { get; set; }

        public Pig(string name, string eats, string says, string lives)
        {
            NamePig = name;
            PigEats = eats;
            PigSays = says;
            PigLives = lives;
        }


    }
}
