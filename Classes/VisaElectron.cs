using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    public class VisaElectron : Card , IInternational, IExpirationDate
    {
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
        public VisaElectron(string cN, DateOnly cA ) : base(cN, cA )
        {
            expirationDate = GenerateExpirationDate();
        }

        // overriding the method from the super-class to set the prefix
        protected override string GetPrefix()
        {
            List<string> visaEList = new List<string>() { "4026", "4175", "4508", "4844", "4913", "4917" };
            Random random = new Random();
            return visaEList[random.Next(0, visaEList.Count - 1)];
        }

        //finding the expiration date, first get todays date
        //add todays date to the variable then adding 5 years
        public DateOnly GenerateExpirationDate()
        {
            DateTime toDay = DateTime.Now;
            DateOnly creationDay = new DateOnly(toDay.Year, toDay.Month, toDay.Day);

            return creationDay.AddYears(5);
        }

        public override string ToString()
        {
            return $" {cusName} \r\n {regNumber} \r\n {accNumber} \r\n {cardNumber} \r\n {expirationDate} \r\n";
        }
    }
}
