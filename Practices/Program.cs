using System;

namespace Practices
{
    class Program
    {
        static void Main(string[] args)
        {
            var workWrap = new WorkWrap();
            var flag = true;
            while (flag)
            {
                Console.WriteLine("Please enter a value from 1 to 3");
                var val = Console.ReadKey();
                switch (val.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Mediator.GetMediatorInstance().OnWorkChanged(new Work() { Name = ConsoleKey.D1.ToString() });
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Mediator.GetMediatorInstance().OnWorkChanged(new Work() { Name = ConsoleKey.D2.ToString() });
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Mediator.GetMediatorInstance().OnWorkChanged(new Work() { Name = ConsoleKey.D3.ToString() });
                        break;
                    default:
                        flag = false;
                        workWrap.PrintOut();
                        break;
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
