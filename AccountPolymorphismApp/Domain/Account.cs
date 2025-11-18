using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Domain
{
    abstract class Account
    {
        private int _accno;
        private string _name;
        protected double _balance;

        public Account(int accno, string name, double balance)
        {
            _accno = accno;
            _name = name;
            _balance = balance;
        }
        //must be overriden by child class
        public abstract void Withdrawal(double amount);//abstract class ese hi banate h & when we make abstract metod class is alao made as abstract
        public void Deposit(double amount)
        {
            _balance += amount;
        }
        public double Balance
        {
            get { return _balance; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int Accountno
        {
            get { return _accno; }
        }
    }
}
