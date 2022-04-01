using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle goes lurba lurba lurba");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle does not drive virtually.");
        }

        public bool hasSideCar { get; set; } = true;

    }
}
