using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema85_BuilderPattern.models;
using Tema85_BuilderPattern.builder;

namespace Tema85_BuilderPattern.director
{
    public class MotorCycleDirector:Director
    {
        public override Vehicle instruct(Builder builder)
        {
            builder.addBrandName();
            builder.buildBody();
            builder.insertWheels();
            return builder.getVehicle();
        }

    }
}
