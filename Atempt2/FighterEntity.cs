using System;
using System.Collections.Generic;
using System.Text;

namespace Atempt2
{
    class FighterEntity
    {
        //Declaring some class variables
        Random r = new Random();
        private string name;
        private int health;
        private int strength;
        private int luck;

        public FighterEntity(string name)
        {
            int statsRange = 50;
            this.name = name;
            health = r.Next(statsRange);
            strength = r.Next(statsRange);
            luck = r.Next(statsRange);
        }

        public FighterEntity(string name, int statsRange)
        {
            this.name = name;
            health = r.Next(statsRange);
            strength = r.Next(statsRange);
            luck = r.Next(statsRange);
        }

        public void displayStats()
        {
            Console.WriteLine(string.Format("Name: {0}, Health: {1}, Strength: {2}, Luck: {3}",name,health,strength,luck));
        }
    }
}
