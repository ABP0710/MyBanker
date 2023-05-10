using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{

    public class MasterCard : Card, ICredit, IInternational, IExpirationDate
    {
        private bool _allowOverDraw;
        private int _creditAmount;
        private bool _allowInternationalUse;

        public DateOnly expirationDate { get; set; }
        

        public bool allowInternationalUse
        {
            get { return _allowInternationalUse; }
            set
            {
                value = true;
                _allowInternationalUse = value;
            }
        }
        public bool allowOverDraw
        {
            get { return _allowOverDraw; }
            set
            {
                value = true;
                _allowOverDraw = value;
            }
        }

        public int creditAmount
        {
            get { return _creditAmount; }
            set
            {
                value = 40000;
                _creditAmount = value;
            }
        }


        public MasterCard(string cN, DateOnly cA ) : base(cN, cA)
        {
            expirationDate = GenerateExpirationDate();
        }

        // overriding the method from the super-class to set the prefix
        protected override string GetPrefix()
        {
            List<string> masterCardList = new List<string>() { "51", "52", "53", "54", "55" };
            Random random = new Random();
            return $"{masterCardList[random.Next(0, masterCardList.Count - 1)]}{random.Next(0, 9)}{random.Next(0, 9)}";
        }
        
        //finding the expiration date, first get todays date
        //add todays date to the variable then adding 5 years
        public DateOnly GenerateExpirationDate()
        {
            DateTime toDay = DateTime.Now;
            DateOnly creationDay = new DateOnly(toDay.Year,toDay.Month,toDay.Day);

            return creationDay.AddYears(5);
        }

        public override string ToString()
        {
            return $" {cusName} \r\n {regNumber} \r\n {accNumber} \r\n {cardNumber} \r\n {expirationDate} \r\n";
        }
    }
}
