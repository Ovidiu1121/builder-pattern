using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema85_BuilderPattern.models
{
    public abstract class Vehicle
    {
        /*
      * You can use any data structure that you prefer.
      * I have used LinkedList<String> in this case.
      */
        private LinkedList<String> parts;
        public Vehicle()
        {
            parts = new LinkedList<String>();
        }
        public void add(String part)
        {
            // Adding parts
            parts.AddLast(part);
        }
        public void showProduct()
        {
            Console.WriteLine("These are the construction sequences:");

           foreach(String part in parts)
            {
                Console.WriteLine(part);
            }
        }

    }
}
