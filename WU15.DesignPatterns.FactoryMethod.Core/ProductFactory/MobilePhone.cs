using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WU15.DesignPatterns.FactoryMethod.Core
{
    public class MobilePhone : ElectronicProductBase
    {
        public PhoneType PhoneType { get; set; }
        public MobilePhone()
        {
            Name = "Mobile Phone";
            Description = "Enables mobile phone calls.";
        }
    }
}
