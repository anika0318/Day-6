using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem.Domain
{
     class Developer:Employee
    {
        public Developer(string name,int employeeid,double basicsalary) : base(name, employeeid, basicsalary)
        {

        }
        public override double CalculateTotalSalary()
        {
            double HRA=0.4*basicsalary;
            return HRA;
        }
        public override void Printsalary()
        {
            double HRA = 0.4 * basicsalary;
            Console.WriteLine("SalarySlip-Manager");
            Console.WriteLine("Name " + name);
            Console.WriteLine("Employeeid " + employeid);
            Console.WriteLine("Basesalary " + basicsalary);
            Console.WriteLine("HRA " + HRA);
            Console.WriteLine("TotalSalary " + CalculateTotalSalary());
        }
    }
}
