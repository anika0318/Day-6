using System;

using Inheritance.Domain;

namespace Inheritance
{
    class Program
    {
        static void Main()
        {
           Customer c1=new Customer("C2088", "Arnika","Kanpur");
            Console.WriteLine(c1);
            //Console.WriteLine("Object Created");
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.GetType());
            // Printinfo(new Customer("C2110", "Arnika"));
            Customer C2 = new Customer("C376", "Vidushi", "Delhi");
            Console.WriteLine(c1==C2);//Reference Equality checks for stack value and this is different
            Console.WriteLine(c1.Equals(C2));//now this is overidden by equal function


        }
        //static void CaseStudy1()
        //{
        //    Printinfo(new Customer("C2110", "Arnika"));
        //    Printinfo(new Customer("C3728", "Divi", "Noida"));
        //}
        static void Printinfo(Customer customer)
        {
            Console.WriteLine("id: "+customer.id);
            Console.WriteLine(customer.name);
            Console.WriteLine(customer.location);
        }
    }
}
