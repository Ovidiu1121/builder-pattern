
using Tema85_BuilderPattern.models;
using Tema85_BuilderPattern.builder;
using Tema85_BuilderPattern.director;
using Tema85_BuilderPattern.concreteBuilder;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("*** Builder Pattern Demonstration. ***");
        // Making a car



        Builder builder = new CarBuilder();
        Director director = new CarDirector();
        Vehicle vehicle = director.instruct(builder);
        vehicle.showProduct();
        // Making a motorcycle
        builder = new MotorCycleBuilder();
        director = new MotorCycleDirector();
        vehicle=director.instruct(builder);
        vehicle.showProduct();

    }
}


