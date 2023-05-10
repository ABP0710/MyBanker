using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Interfaces
{
    public interface ICustomer
    {
        public string cusName { get; set;  }

        public DateOnly cusAge { get; set; }
    }
}
