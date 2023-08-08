using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema85_BuilderPattern.builder;
using Tema85_BuilderPattern.models;

namespace Tema85_BuilderPattern.concreteBuilder
{
    public class CarBuilder:Builder
    {
        Car car;
        public CarBuilder()
        {
            car=new Car("Ford");
        }

        public void addBrandName()
        {
            car.add(" Adding the car brand: " + car.brandName);
        }

        public void buildBody()
        {
            car.add(" Making the car body.");
        }

        public void insertWheels()
        {
            car.add(" 4 wheels are added to the car.");
        }

        public Vehicle getVehicle()
        {
            return car;
        }

    }
}
