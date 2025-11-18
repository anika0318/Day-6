using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Domain
{
    class SavingAccount:Account
    {
        public SavingAccount(int accno,string name,double balance) : base(accno, name, balance)
        {
         
        }
        public override void Withdrawal(double amount)
        {
            if (_balance - amount >= 500)
            {
                _balance=_balance - amount;
            }
        }
    }
}
