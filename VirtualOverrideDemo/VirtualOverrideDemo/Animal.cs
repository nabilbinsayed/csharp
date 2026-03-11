using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideDemo
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true; // Default value
        }

        public virtual void MakeSound()
        {

        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                System.Console.WriteLine($"{Name} is eating");
            }
            else
            {
                System.Console.WriteLine($"{Name} isn't hungry");
            }
        }

        public virtual void Play()
        {
                System.Console.WriteLine($"{Name} is playing");
            
        }


    }
}
