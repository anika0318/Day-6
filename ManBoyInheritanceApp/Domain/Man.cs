using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Domain
{
    class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man is playing");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Man is Eating");
        }
        public void Read()
        {
            Console.WriteLine("Man is Reading");
        }
    }
}
