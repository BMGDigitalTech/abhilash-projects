using System;
using System.Collections.Generic;

namespace PolyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "silver", "A3"),
                new BMW(220, "red", "320 D")
            };

            foreach(var car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }

            Car AudiA4 = new Audi(250, "black", "A4");
            AudiA4.ShowDetails();
            AudiA4.SetCarIDInfo(254949, "Abhilash Narayan");
            AudiA4.GetCarIDInfo();

            Car BMWX3 = new BMW(300, "white", "X3");
            BMWX3.ShowDetails();
            BMWX3.SetCarIDInfo(257498, "Akhil Gunjikar");
            BMWX3.GetCarIDInfo();

            Car bmwcar = (Car)BMWX3;
            bmwcar.ShowDetails();

            Car tata = new Car(150, "yellow");
            tata.ShowDetails();

            Console.ReadKey();


        }
    }
}
