using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public class DebetCard : Card
    {  
        public DebetCard(string cN, DateOnly cA) : base(cN, cA)
        {

        }
        
        // overriding the method from the super-class to set the prefix
        protected override string GetPrefix()
        {
            return "2400";
        }
        public override string ToString()
        {
            return $" {cusName} \r\n {regNumber} \r\n {accNumber} \r\n {cardNumber} \r\n";
        }
    }
}
