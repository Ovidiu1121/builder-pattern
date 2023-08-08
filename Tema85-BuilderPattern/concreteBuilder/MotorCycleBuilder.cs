using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema85_BuilderPattern.builder;
using Tema85_BuilderPattern.models;

namespace Tema85_BuilderPattern.concreteBuilder
{
    public class MotorCycleBuilder : Builder
    {

        MotorCycle motorCycle;
        public MotorCycleBuilder()
        {
            motorCycle=new MotorCycle("Honda");
        }

        public void addBrandName()
        {
            motorCycle.add(" Adding the brand name: " + motorCycle.brandName);
        }

        public void buildBody()
        {
            motorCycle.add(" Making the body of the motorcycle.");
        }

        public Vehicle getVehicle()
        {
            return motorCycle;
        }

        public void insertWheels()
        {
            motorCycle.add(" 2 wheels are added to the motorcycle.");
        }
    }
}
