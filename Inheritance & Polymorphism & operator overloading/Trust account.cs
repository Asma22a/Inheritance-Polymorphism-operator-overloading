using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Polymorphism___operator_overloading
{
    public class TrustAccount : Account
    {
        public double InteRest { get; set; }
        public int Value { get; set; }
        public TrustAccount (string Name = "Unnamed Account", double Balance = 0.0, double InteRest = 0.0, int Value = 0)
            : base(Name, Balance)
        {
            this.InteRest = InteRest;
            this.Value = Value;
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
            if(Value<=3 && amount > Balance * 0.20)
            {
                return base.Withdraw(amount);
                Value += 1;
            }
            else
            {
                return false;
            }
        }
    }
}
