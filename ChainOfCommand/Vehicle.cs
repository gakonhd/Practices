namespace ChainOfCommand
{
    public class Vehicle
    {
        public Vehicle(int size)
        {
            Size = size;
        }

        public int Size { get; }
        public string Manufacture { get; set; }
        public int Year { get; set; }
    }
}
