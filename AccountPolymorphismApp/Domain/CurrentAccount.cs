using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorphismApp.Domain
{
     class CurrentAccount:Account
    {
        public CurrentAccount(int accno,string name,double balance):base(accno,name,balance) { 
        
        }
        public override void Withdrawal(double amount)
        {
            if (_balance - amount > -10000)
            {
                _balance=_balance- amount;
            }
        }
    }
}
