using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Human
    {

        public string firstName = "Unknown Person"; // member variable

        //member method: 
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {firstName}");
        }

    }
}
