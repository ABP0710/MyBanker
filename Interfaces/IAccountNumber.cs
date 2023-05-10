using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Interfaces
{
    public interface IAccountNumber
    {
        protected string accNumber { get; set; }

        protected string GenerateAccountNumber();
    }
}
