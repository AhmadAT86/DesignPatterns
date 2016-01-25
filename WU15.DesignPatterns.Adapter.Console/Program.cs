using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WU15.DesignPatterns.Adapter.Core.ExternalBillingSystem;
using WU15.DesignPatterns.Adapter.Core.Sockets;

namespace WU15.DesignPatterns.Adapter.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            IInvoicingTarget invoicingTarget = new CustomerAdapter();
            ExternalBillingSystem client = new ExternalBillingSystem(invoicingTarget);
            client.RunInvoicing();

            System.Console.ReadLine();
        }
        //{
        //    //Socket
        //    var rectangularPlug = new RectangularPlug("Phase", "Neutral");
        //    System.Console.WriteLine(rectangularPlug.Connect());

        //    System.Console.ReadLine();
        //}
    }
}
