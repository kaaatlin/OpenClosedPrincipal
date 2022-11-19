using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrincipal
{
    public class PayAccount : IType
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculatorInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
            Console.WriteLine("Расчитана зарплатная ставка");
        }
    }
}
