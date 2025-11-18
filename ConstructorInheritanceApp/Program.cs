using ConstructorInheritanceApp.Domain.Casestudy2;
using System;
namespace ConstructorInheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildTwo child1= new ChildTwo();
            Console.WriteLine(child1.Age);
        }
    }
}
