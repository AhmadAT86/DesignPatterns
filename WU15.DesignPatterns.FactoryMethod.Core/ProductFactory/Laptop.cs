using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WU15.DesignPatterns.FactoryMethod.Core
{
    public class Laptop : ElectronicProductBase
    {
        public ProcessorType ProcessorType { get; set; }
        public Laptop()
        {
            Name = "Laptop";
            Description = "Laptop is a small mobile computer with integrated screen";
        }
    }
}
