using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem.Domain
{
    class Accountant:Employee
    {
        public Accountant(string name, int employeid, double basicsalary) : base(name, employeid, basicsalary)
        {
        }
        public override double CalculateTotalSalary()
        {
            double HRA=0.3*basicsalary;
            return HRA;
        }
        public override void Printsalary()
        {
            double HRA = 0.3 * basicsalary;
            Console.WriteLine("SalarySlip-Manager");
            Console.WriteLine("Name " + name);
            Console.WriteLine("Employeeid " + employeid);
            Console.WriteLine("Basesalary " + basicsalary);
            Console.WriteLine("HRA " + HRA);
            Console.WriteLine("TotalSalary " + CalculateTotalSalary());
        }
    }
}
