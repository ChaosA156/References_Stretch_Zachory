using System;
using System.Collections.Generic;
using System.Text;

namespace References_Stretch_Zachory
{
    interface IAutomobile
    {
        // I think this collects everything and adds it to the IAutomobile, but I don't remember.
        public double Speed { get; }

        public int Wheels { get; }

        public string LiscensePlate { get; }

        public void Stringify();

    }
}
