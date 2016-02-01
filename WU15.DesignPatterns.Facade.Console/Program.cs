﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WU15.DesignPatterns.Facade.Core.MortgageEligibility;

namespace WU15.DesignPatterns.Facade.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testar uppkopplingen mot GitHub
            // MorgageEligibility
            // Facade
            var mortgage = new Mortgage();

            var customer = new Customer("BO", "LEANDERSON");
            var amount = 125000.0;

            //Invoke the facade and the facade invokes all of it's subsystem.
            var isEligible = mortgage.IsEligible(customer, amount);

            System.Console.WriteLine(
                "=> {0} {1}s application for a loan of {2} has been {3}.",
                customer.FirstName,
                customer.LastName,
                amount,
                (isEligible ? "approved" : "rejected"));

            System.Console.ReadLine();

        }
    }
}
