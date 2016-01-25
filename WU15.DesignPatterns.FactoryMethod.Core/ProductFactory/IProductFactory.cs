using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WU15.DesignPatterns.FactoryMethod.Core
{  // JAG ÄR PÅ SIDA 26 I DESIGNMÖNSTER KOLLA GENOM DE.
    public class IProductFactory
    {
        ElectronicProductBase CreateProduct(ProductType product);
    }
}
