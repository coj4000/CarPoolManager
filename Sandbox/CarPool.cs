using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class CarPool
    {
        // This instance field will contain license plates as keys,
        // and Car objects as values
        Dictionary<String, Car> carList;
       

        public CarPool()
        {
            carList = new Dictionary<string, Car>();
        }

        // Add the given car to the car pool
        public void AddCarToPool(Car aCar)
        {
            carList.Add(aCar.GetLicensePlate(), aCar);
        }

        // Remove the car with the given license plate from the car pool.
        // If the license plate does not exist, do nothing
        public void RemoveCarFromPool(String licensePlate)
        {
            
                if (carList.ContainsKey(licensePlate))
                {
                    carList.Remove(licensePlate);    
                }
        }

        // If a Car object corresponding to the given license plate exists, return it.
        // Otherwise, return null
        public Car LookupCar(String licensePlate)
        {
                
                if (carList.ContainsKey(licensePlate))
                {
                return carList[licensePlate];
                }
            else
            {
                return null;
            }
               
            
            
           
        }

        // Print out all cars in the pool
        // (leave this method as it is)
        public void PrintAllCarsInPool()
        {
            foreach (KeyValuePair<String, Car> kvp in carList)
            {
                Car aCar = kvp.Value;
                Console.WriteLine("{0} is a {1} {2}", aCar.GetLicensePlate(), aCar.GetBrand(), aCar.GetModel());
            }
        }
    }
}
