using System;

namespace ChainOfCommand
{
    public abstract class ParkingAttendant
    {
        protected ParkingAttendant NextAttendant;

        public void SetParkingAttendant(ParkingAttendant pa)
        {
            NextAttendant = pa;
        }
        public abstract void ControlAttendant(Vehicle v);
    }

    public class SmallParkingAttendant : ParkingAttendant
    {
        public override void ControlAttendant(Vehicle v)
        {
            if (v.Size <= 2)
            {
                Console.WriteLine($"Your {v.Manufacture} car can be park at {GetType().Name}");
            }
            else
            {
                NextAttendant?.ControlAttendant(v);
            }
        }
    }
    public class MediumParkingAttendant : ParkingAttendant
    {
        public override void ControlAttendant(Vehicle v)
        {
            if (v.Size <= 5)
            {
                Console.WriteLine($"Your {v.Manufacture} car can be park at {GetType().Name}");
            }
            else
            {
                NextAttendant?.ControlAttendant(v);
            }
        }
    }

    public class LargeParkingAttendant : ParkingAttendant
    {
        public override void ControlAttendant(Vehicle v)
        {
            if (v.Size <= 7)
            {
                Console.WriteLine($"Your {v.Manufacture} car can be park at {GetType().Name}");
            }
            else
            {
                NextAttendant?.ControlAttendant(v);
            }
        }
    }
    public class OutdoorParkingAttendant : ParkingAttendant
    {
        public override void ControlAttendant(Vehicle v)
        {
            Console.WriteLine(v.Size <= 11
                ? $"Your {v.Manufacture} car can be park at {GetType().Name}"
                : "Your vehicle can't be parked at our facility");
        }
    }
}
