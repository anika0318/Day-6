using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem.Domain
{
    class Employee
    {
        private string _name;
        private int _employeid;
        protected double _basicsalary;

        public int Employeeid { get; }

        public Employee(string name, int employeid, int basicsalary)
        {
            _name = name;
            _employeid = employeid;
            _basicsalary = basicsalary;
        }

        public Employee(string name, int employeeid, double basicsalary)
        {
            _name = name;
            Employeeid = employeeid;
            _basicsalary = basicsalary;
        }

        public virtual double CalculateTotalSalary()
        {
            return _basicsalary;
        }
        public virtual void Printsalary()
        {
            Console.WriteLine("Salary Slip");
            Console.WriteLine("Name " + _name);
            Console.WriteLine("Employeeid " + _employeid);
            Console.WriteLine("BaseSalary " + _basicsalary);
            Console.WriteLine("TotalSalary "+ CalculateTotalSalary());
        }
        public string name
        {
            get { return _name; }
        }
        public int employeid
        {
            get { return _employeid; }
        }
        public double basicsalary
        {
            get { return _basicsalary; }
        }

    }
}
