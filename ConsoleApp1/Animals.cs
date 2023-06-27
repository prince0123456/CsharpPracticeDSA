using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animals
    {
        public string name;
        public string sound;
        static int numOfAnimals = 0;

        public Animals() 
        {
            name = "No Name";
            sound = "No sound";
        }
        public Animals( string name="No name")
        {
            this.name = name;
            this.sound = "No Sound";
            numOfAnimals++;
        }
        public Animals(string name="No Name",string sound="No sound")
        {
            this.name = name;
            this.sound=sound;
            numOfAnimals++;

        }
        public void MakeSound()
        {
            Console.WriteLine("0 says {1}",name,sound);

        }
        public static int GetNumAnimals()
        {
            return numOfAnimals;
        }
    }

}
