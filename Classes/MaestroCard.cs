using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{

    public class MaestroCard : Card, IInternational, IExpirationDate
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

        public MaestroCard(string cN, DateOnly cA ) : base(cN, cA)
        {
            expirationDate = GenerateExpirationDate();
        }

        // overriding the method from the super-class to set the prefix
        protected override string GetPrefix()
        {
            List<string> maestroList = new List<string>() { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
            Random random = new Random();
            string[] c = new string[3];
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = random.Next(0, 9).ToString();
            }
            return maestroList[random.Next(0, maestroList.Count - 1)] + $"{c[0]}{c[1]}{c[2]}";
        }

        //finding the expiration date, first get todays date
        //add todays date to the variable then adding 68 months
        public DateOnly GenerateExpirationDate()
        {
            DateTime toDay = DateTime.Now;
            DateOnly creationDay = new DateOnly(toDay.Year, toDay.Month, toDay.Day);

            return creationDay.AddMonths(68);
        }

        public override string ToString()
        {
            return $" {cusName} \r\n {regNumber} \r\n {accNumber} \r\n {cardNumber} \r\n {expirationDate} \r\n";
        }
    }
}
