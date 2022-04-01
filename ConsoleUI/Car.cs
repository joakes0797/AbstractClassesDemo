using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Car goes vroom vroom");
        }

        public bool hasTrunk { get; set; } = true;

    }
}
