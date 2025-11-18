using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem.Domain
{
    class Manager:Employee
    {
        public Manager(string name,int employeeid,double basicsalary) : base(name, employeeid, basicsalary)
        {

        }
        public override double CalculateTotalSalary()
        {
            double HRA=0.5*basicsalary;
            return HRA + basicsalary;
        }
        public override void Printsalary()
        {
            double HRA = 0.5 * basicsalary;
            Console.WriteLine("SalarySlip-Manager");
            Console.WriteLine("Name " + name);
            Console.WriteLine("Employeeid "+ employeid);
            Console.WriteLine("Basesalary " + basicsalary);
            Console.WriteLine("HRA " + HRA);
            Console.WriteLine("TotalSalary " + CalculateTotalSalary());
        }

    }
}
