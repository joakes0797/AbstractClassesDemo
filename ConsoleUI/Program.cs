using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle --done
             * The vehicle class shall have three string properties Year, Make, and Model --done
             * Set the defaults to something generic in the Vehicle class --done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation.  --done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.  --done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle     --done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle      --done
             * Provide the implementations for the abstract methods     --done
             * Only in the Motorcycle class will you override the virtual drive method      --done
            */

            // Create a list of Vehicle called vehicles     --done

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use 
             * constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax        --done
             */

            var toyota = new Car() { hasTrunk = true, Year = "2015", Make = "Toyota", Model= "Camry" };
            var harley = new Motorcycle() { hasSideCar = false, Year="2016", Make = "Harley Davidson", Model = "Switchback" };
            Vehicle chrysler = new Car() { hasTrunk = true, Year = "2017", Make = "Chrysler", Model = "300" } ;
            Vehicle suzuki = new Motorcycle() { hasSideCar = true, Year = "2013", Make = "Suzuki", Model = "TU250X" };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties     --done
             */

            vehicles.Add(toyota);
            vehicles.Add(harley);
            vehicles.Add(chrysler);
            vehicles.Add(suzuki);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year:  {vehicle.Year}");
                Console.WriteLine($"Make:  {vehicle.Make}");
                Console.WriteLine($"Model:  {vehicle.Model}");
                Console.WriteLine("----------");
            }

            // Call each of the drive methods for one car and one motorcycle        --done
            
            Console.WriteLine("These are the drive methods for the Toyota: ");
            toyota.DriveAbstract();
            toyota.DriveVirtual();
            Console.WriteLine("----------");

            Console.WriteLine("These are the drive methods for the Harley: ");
            harley.DriveAbstract();
            harley.DriveVirtual();
            Console.WriteLine("----------");

            #endregion            
            //Console.ReadLine();
        }
    }
}
