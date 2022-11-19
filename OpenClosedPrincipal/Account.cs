using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipal
{
    class Account
    {
        public void PerformAccount(IType accountType)
        {
            accountType.CalculatorInterest();
        }
    }
}
