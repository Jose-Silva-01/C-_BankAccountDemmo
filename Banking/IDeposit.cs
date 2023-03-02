using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public interface IDeposit
    {
        //All interface is public so you don't need to specify it as public

        void Deposit(decimal amount);
    }
}
