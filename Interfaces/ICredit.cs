using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker.Interfaces
{
    public interface ICredit
    {
        public bool allowOverDraw { get; }

        public int creditAmount { get; set; }
    }
}
