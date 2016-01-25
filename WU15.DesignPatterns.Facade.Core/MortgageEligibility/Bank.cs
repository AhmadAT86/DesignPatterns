using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WU15.DesignPatterns.Facade.Core.MortgageEligibility
{
    //Subsystem
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, double amount)
        {
            Console.WriteLine(
                "# Checking {0} {1}s bank funds.",
                customer.FirstName,
                customer.LastName);

            return true;
        }
    }
}
