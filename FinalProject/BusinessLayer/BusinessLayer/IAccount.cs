using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    interface IAccount
    {
        void UpdateBalance(EnumTransactionType trans, decimal amnt);
    }
}
