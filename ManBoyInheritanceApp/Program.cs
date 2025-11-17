using ManBoyInheritanceApp.Domain;
using System;

namespace ManBoyInheritanceApp
{
    internal class Program
    {
        static void Main()
        {
            Casestudy1(); 
            Casestudy2 ();
            Casestudy5 ();
        }
        static void Casestudy1()
        {
            Boy y; 
            y=new Boy();
            y.Play();
            y.Eat();
            y.Read();
        }
        static void Casestudy2()
        {
            Toddler x;
            x=new Toddler();
            x.Play();
            x.Eat();
            x.Read();
            Console.WriteLine(x.GetType());
        }
        private static void Casestudy5()
        {
            object x;
            x = 100;
            Console.WriteLine(x.GetType());
            x = "hello";
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
            Man temp=new Man();
            temp.Play();
        }

    }
}
