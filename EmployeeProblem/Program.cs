using EmployeeProblem.Domain;
using System;
namespace EmployeeProblem
{
   class Program
    {
        static void Main(string[] args)
        {
            Manager m=new Manager("Ashi",5662,100000);
            Accountant a = new Accountant("Riya", 5782, 80000);
            Developer d = new Developer("Ajay", 7637, 70000);

            Printsalaryslip(m);
            Printsalaryslip(a);
            Printsalaryslip(d);

        }
        static void Printsalaryslip(Employee Employee)
        {
            Employee.Printsalary();
        }
    }
}
