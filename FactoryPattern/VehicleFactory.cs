using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class VehicleFactory
    {   
        public static ICallable GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower()) 
            {
                case "two":
                    return new Motorcycle();
                default:
                    return new Car();
            
            }
            
        }

        
    }
}
