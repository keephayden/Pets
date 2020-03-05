using System;

namespace Pets
{
    class Dog:Pet
    {
        public Dog(string Name, string Owner, double Weight):base("Dog",Name, Owner,Weight)
        {
            name=Name;
            owner=Owner;
            weight=Weight;
        }
        public string bark (int count)
        {
            int sound;
            string bark= "";

            for (sound=0;sound<count;sound++)
            {
                bark +="bark!";
            }
            return bark;
        }
    }
}