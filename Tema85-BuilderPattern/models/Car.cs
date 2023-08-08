using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema85_BuilderPattern.models
{
    public class Car:Vehicle
    {
        public string brandName;
        public Car(String brandName)
        {
            this.brandName=brandName;
            Console.WriteLine("\nWe are about to make a " + brandName+ " car.");
        }
    }
}
