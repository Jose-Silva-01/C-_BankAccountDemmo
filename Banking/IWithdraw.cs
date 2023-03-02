using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public interface IWithdraw
    {
        // Interfaces always starts the name with an I
        void Withdrawal(decimal amount);
    }
}
