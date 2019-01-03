using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            var sParkingAttendant = new SmallParkingAttendant();
            var mParkingAttendant = new MediumParkingAttendant();
            var lParkingAttendant = new LargeParkingAttendant();
            var oParkingAttendant = new OutdoorParkingAttendant();
            sParkingAttendant.SetParkingAttendant(mParkingAttendant);
            mParkingAttendant.SetParkingAttendant(lParkingAttendant);
            lParkingAttendant.SetParkingAttendant(oParkingAttendant);

            do
            {
                Vehicle newVehicle;
                
                Console.WriteLine("\nWhat is the size of your vehicle ?");
                cki = Console.ReadKey(true);
                if (char.IsDigit(cki.KeyChar))
                {
                    int.TryParse(cki.KeyChar.ToString(), out var size);
                    Console.WriteLine($"Vehicle size is {size}");
                    newVehicle = new Vehicle(size);
                    Console.WriteLine("\nWhat is the name of your vehicle ?");
                    var val = Console.ReadLine();
                    Console.WriteLine($"Vehicle name is {val}");
                    newVehicle.Manufacture = val;
                    sParkingAttendant.ControlAttendant(newVehicle);
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
