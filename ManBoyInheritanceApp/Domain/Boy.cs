using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Domain
{
    class Boy :Man //Asking boy to behave ISAa class of Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy is playing");
        }
        public override void Eat()
        {
            Console.WriteLine("Boy is eating");
        }
        public void Read()
        {
            Console.WriteLine("Boy is Reading");
        }
    }
}
