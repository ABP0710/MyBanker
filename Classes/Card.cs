using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Classes
{
    //super class with interfaces
    public abstract class Card : IAccountNumber, ICustomer, ICardNumber
    {
        private string _accNumber;
        private string _cusName;
        private DateOnly _cusAge;

        public string regNumber = "Reg Nummer: 3520"; 
       

        public string cardNumber { get; set; }
        

        public string accNumber
        {
            set { _accNumber = value; }
            get { return _accNumber; }
        }

        public string cusName
        {
            get { return _cusName; }
            set { _cusName = value; }
        }


        public DateOnly cusAge
        {
            get { return _cusAge; }
            set { _cusAge = value; }
        }

        public Card(string cN, DateOnly cA)
        {
            this._cusName = cN;
            this._cusAge = cA;            
            this._accNumber = GenerateAccountNumber();
            this.cardNumber = GenerateCardNumber();
        }

        public string GenerateAccountNumber()
        {
            Random random = new Random();

            string[] a = new string[14];

            for (int i = 0; i < a.Length; i++)
            {
                string aN = random.Next(0,9).ToString();
                a[i] = aN;
            }

            return $"Konto Nummer: {a[0]}{a[1]}{a[2]}{a[3]}{a[4]}{a[5]}{a[6]}{a[7]}{a[8]}{a[9]}{a[10]}{a[11]}{a[12]}{a[13]}";
        }

        //abstract method used to get the different prefixes on the card numbers
        //the method is then overwritten in the sub-classes to get the wanted prefix
        protected abstract string GetPrefix();


        //method to make the card number and returning a string, starting with the prefix         
        public virtual string GenerateCardNumber()
        {
            string prefix = GetPrefix();
            Random random = new Random();

            string[] c = new string[12];

            for (int i = 0; i < c.Length; i++)
            {
                string cN = random.Next(0, 9).ToString();
                c[i] = cN;
            }

            return $"Kort Nummer: {prefix}{c[0]}{c[1]}{c[2]}{c[3]}{c[4]}{c[5]}{c[6]}{c[7]}{c[8]}{c[9]}{c[10]}{c[11]}";
        }
    }
}
