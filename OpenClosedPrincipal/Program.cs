using System.Security.Principal;

namespace OpenClosedPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account.PerformAccount(new SimpleAccount());
            account.PerformAccount(new PayAccount());
        }
    }
}