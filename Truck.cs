using System;
using System.Collections.Generic;
using System.Text;

namespace References_Stretch_Zachory
{
    class Truck : IAutomobile
    {
        // Creating variables for Truck
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LiscensePlate { get; private set; }

        public double Weight { get; }
        // Assigning properties to Truck on object's creation.
        public Truck(double speedParam, double weightParam, string liscenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LiscensePlate = liscenseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
        // Creating sentence and the speed increase and decrease values.
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with Liscense Plate # of {LiscensePlate}.");
        }

        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
