using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Polymorphism___operator_overloading
{
    public class TrustAccount : SavingsAccount
    {
        
        private DateTime withdrawYear = DateTime.Now;
        private int Value = 0;
        public TrustAccount (string Name = "Unnamed Account", double Balance = 0.0, double InteRest = 0.0)
            : base(Name, Balance,InteRest)
        {
            
          
        }
        public override bool Deposit(double amount)
        {
            if (amount >= 5000 )
            {
                 Balance += 50;
                
            }
            return base.Deposit(amount);
        }
        public override bool Withdraw(double amount)
        {
            if (DateTime.Now.Year != withdrawYear.Year)
            {
                Value = 0;
                withdrawYear = DateTime.Now;
            }
            if (Value<=3 && amount > Balance * 0.20)
            {
                Value += 1;
                return base.Withdraw(amount);
                
            }
            else
            {
                return false;
            }
        }
    }
}
