using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Interfaces
{
    public interface ICardNumber
    {
        public string cardNumber { get; set; }

        public string GenerateCardNumber();
    }
}
