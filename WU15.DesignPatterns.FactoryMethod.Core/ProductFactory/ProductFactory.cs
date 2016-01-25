using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WU15.DesignPatterns.FactoryMethod.Core
{
    public class ProductFactory : IProductFactory
    {
        public ProductFactory()
        {
            Console.WriteLine("Creating the products factory.");
        }

        public ElectronicProductBase CreateProduct(ProductType product)
        {
            switch (product)
            {
                case ProductType.Phone:
                    return new MobilePhone();
                
                case ProductType.Laptop:
                    return new Laptop();

                case ProductType.Mp3:
                    return new MP3Player();

                default:
                    return new GenericProduct();
            }
        }

    }
}
