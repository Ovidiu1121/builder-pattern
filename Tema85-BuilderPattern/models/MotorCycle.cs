using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema85_BuilderPattern.models
{
    public class MotorCycle:Vehicle
    {
        public string brandName;
        public MotorCycle(string brandName)
        {
            Console.WriteLine("\nWe are about to make a " + brandName+ " motorcycle.");
        }

    }
}
