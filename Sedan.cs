using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace References_Stretch_Zachory
{
    // Creates Sedan class and variables for it.
    class Sedan : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LiscensePlate { get; private set; }

        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LiscensePlate = "TRCS-56";
        }
        // Creating sentence and the speed increase and decrease values.
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed og {Speed} on {Wheels} wheels, with a Liscense Plate # of {LiscensePlate}.");
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
