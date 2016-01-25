using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WU15.DesignPatterns.Facade.Core.MortgageEligibility
{
    public class Mortgage
    {
        private readonly Bank bank = new Bank();
        private readonly Loan loan = new Loan();
        private readonly Credit credit = new Credit();

        public bool IsEligible(Customer customer, double amount)
        {
            Console.WriteLine(
                "{0} {1} is applying for a {2:C} loan.",
                customer.FirstName,
                customer.LastName, amount);

            var isEigible = true;
 
            if (!bank.HasSufficientSavings(customer, amount))
            {
                isEigible = false;
            }
            else if (!loan.HasNoBadLoans(customer))
            {
                isEigible = false;
            }
            else if (!credit.HasGoodCredit(customer))
            {
                isEigible = false;
            }

            return isEigible;
        }
    }
}
