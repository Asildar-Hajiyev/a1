using System;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Motor = 2.3;
            car.DriveWay = 5;
            car.DriveTime = 23;
            car.Cycle = "123";
            car.Color = "Black";
            Console.WriteLine("Car; " + car.Motor + " Motor; " + car.DriveWay + " DriveWay; " + car.DriveTime + " DriweTime; " + car.Cycle + " Cycle; " + car.Color + " Color; ");
            Console.WriteLine();
            Bicycle bicycle = new Bicycle();
            bicycle.DriveWay = 95;
            bicycle.DriveTime = 17;
            bicycle.Cycle = "3456";
            bicycle.Color = "Black";
            Console.WriteLine("Bicycle; " +  bicycle.DriveWay + " DriveWay; " + bicycle.DriveTime + " DriweTime; " + bicycle.Cycle + " Cycle; " + bicycle.Color + " Color; ");
            Console.WriteLine();
            Bus bus = new Bus();
            bus.DriveWay = 225;
            bus.DriveTime = 23;
            bus.Cycle = "30200";
            bus.Color = "Yellow";
            Console.WriteLine("Bus; " + " Motor; " + bus.DriveWay + " DriveWay; " + bus.DriveTime + " DriweTime; " + bus.Cycle + " Cycle; " + bus.Color + " Color; ");


        }
    }
}
