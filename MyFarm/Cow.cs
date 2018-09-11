using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Cow
    {

        public string NameCow { get; set; }
        public string CowEats { get; set; }
        public string CowSays { get; set; }
        public string CowLives { get; set; }

        public Cow(string name, string eats, string says, string lives)
        {
            NameCow = name;
        }
        //public string CowsEat(string eats)
        //{
        //    eats = "Hay";
        //}


    }
}
