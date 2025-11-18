using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Domain.Casestudy2
{
    class ChildTwo : ParentTwo
    {
        public ChildTwo() : base(100)
        {

        }
        public ChildTwo(int age) : base(age)//function overloading
        {
            {
            }
        }

    }
}
