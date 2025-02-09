using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance___Polymorphism___operator_overloading
{
    public class SavingsAccount : Account
    {
        public double InteRest { get; set; }
        public SavingsAccount (string Name = "Unnamed Account", double Balance = 0.0 , double InteRest = 0.0) 
            :base(Name,Balance)
        {
            this.InteRest = InteRest;
        }
       
        public override string ToString()
        {
            return $" {base.ToString()}, Interest : {InteRest}";
        }
    }
}
