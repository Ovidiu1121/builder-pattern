using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema85_BuilderPattern.builder;
using Tema85_BuilderPattern.models;

namespace Tema85_BuilderPattern.director
{
    public class CarDirector : Director
    {
        // The car director follows
        // its own sequence:
        // Make body-> add wheels->then add the brand name.
        public override Vehicle instruct(Builder builder)
        {
            builder.buildBody();
            builder.insertWheels();
            builder.addBrandName();
            return builder.getVehicle();
        }
    }
}
