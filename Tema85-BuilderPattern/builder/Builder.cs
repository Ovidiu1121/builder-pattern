using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema85_BuilderPattern.models;

namespace Tema85_BuilderPattern.builder
{
    public interface Builder
    {
        void addBrandName();
        void buildBody();
        void insertWheels();
        // The following method is used to
        // retrieve the object that is constructed.
        Vehicle getVehicle();
    }
}
