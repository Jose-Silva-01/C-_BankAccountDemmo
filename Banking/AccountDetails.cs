using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public abstract class AccountDetails
    {
        // It means that these functions are not defined, they need to define it
        public abstract string GetAccountName();

        public abstract string GetAccountTypeName();

        public abstract string Name { get; }
    }
}
