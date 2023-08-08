using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema85_BuilderPattern.builder;
using Tema85_BuilderPattern.models;

namespace Tema85_BuilderPattern.director
{
    public abstract class Director
    {
        // Director knows how to use/instruct the
        // builder to create a vehicle.
        public abstract Vehicle instruct(Builder builder);

    }
}
