using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Interfaces
{
    public interface IExpirationDate
    {
        public DateOnly expirationDate { get; set; }

        public abstract DateOnly GenerateExpirationDate();
        
    }    
}
