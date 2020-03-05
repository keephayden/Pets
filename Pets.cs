using System;

namespace Pets
{
    class Pet
    {
        public string type; 
        public string name;
        public string owner;
        public double weight;
        public Pet(string Type, string Name, string Owner, double Weight)
        {
            
            type=Type;
            name=Name;
            owner=Owner;
            weight=Weight;
        }
        public string getTag()
        {
            string tag="If lost call "+owner;
            return tag;
        }
    }
}