using System;

namespace References_Stretch_Zachory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assigns myFirstSedan to Sedan and MyAutomobile to myFirst Sedan. (I think)
            Sedan myFirstSedan = new Sedan(0);
            IAutomobile myAutomobile = myFirstSedan;

            Sedan myOtherSedan = new Sedan(0);

            // Increases speed of myFirstSedan and compares speed with myAutomobile in a True or False statement.
            myFirstSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            // Increases speed of myOtherSedan and compares speed with myFirstSedan in a True or False statement.
            myOtherSedan.IncreaseSpeed();
            Console.WriteLine(myFirstSedan.Speed);
            Console.WriteLine(myAutomobile.Speed);
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            Truck myTruck = new Truck(50, 500, "MyTrUck");

            // Calls stringify method and describes automobiles.
            myFirstSedan.Stringify();
            myAutomobile.Stringify();
            myOtherSedan.Stringify();
            myTruck.Stringify();
        }
    }
}