using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Domain
{
    class Toddler:Boy
    {
        public override void Play()
        {
            Console.WriteLine("Toddler is Playing");
        }
        public override void Eat()
        {
            Console.WriteLine("Toddler is Eating");
        }
        
    }
}
