using System;

namespace Pets
{
    class Cat:Pet
    {
        public Cat(string Name, string Owner, double Weight):base("Cat",Name,Owner,Weight)
        {
            name=Name;
            owner=Owner;
            weight=Weight;
        }
        public string meow(int count)
        {
            string meow="";
            int sound;
            for(sound=0;sound<count;sound++)
            {
                meow+="meow.";
            }
            return meow;
        }
    }
}