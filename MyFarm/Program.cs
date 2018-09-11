using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my farm.");

            Console.WriteLine("We have four animals: A Cow, Pig, Sheep, and Chicken.");

            Cow cow = new Cow("Bella", "Hay", "Moo", "Field");
            Cow cow2 = new Cow("Chocolate", "Hay", "Moo", "Field");
            Cow cow3 = new Cow("Milky", "Hay", "Moo", "Field");
            Cow cow4 = new Cow("Jersey", "Hay", "Moo", "Field");

            Horse hor =  new Horse("Mr. Ed", "Hay", "Wilburrrrrrr", "Barn");
            Horse hor2 = new Horse("Jackpot", "Hay", "Neigh", "Barn");
            Horse hor3 = new Horse("Jim Beam", "Hay", "Neigh", "Barn");
            Horse hor4 = new Horse("Unicorn", "Candy", "NeighNeigh", "Rainbow Mountain");

            Sheep she =  new Sheep("Lambert", "Meat", "Roar", "Meadow");
            Sheep she2 = new Sheep("Momma", "Hay", "Baa", "Meadow");
            Sheep she3 = new Sheep("Lambchop", "Hay",     "Baa",     "Meadow");
            Sheep she4 = new Sheep("Mutton", "Hay",    "Baa",    "Meadow");

           Pig pig = new  Pig("Porky",  "Pork Rinds", "Thats all folks", "Farmhouse");
           Pig pig2 = new Pig("Porque", "Stuff", "Imma porque pig", "behind a fence");
           Pig pig3 = new Pig("Mike",   "Anything", "Oink", "Pen");
           Pig pig4 = new Pig("Bacon",  "Bacon", "Bacon", "Bacon");



            Console.WriteLine("What animals live on your farm?");
            Console.WriteLine("Type one: cow, horse, sheep, pig");
            string chosenAnimal = Console.ReadLine();
        }
     }

}
