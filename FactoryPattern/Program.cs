using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like your vehicle to have two or four wheels?");
            string wheelCount = (Console.ReadLine());

            ICallable vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Build();
            Console.ReadLine();

        }        
        
    }
}
