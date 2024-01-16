using MyPersonalAdditions;
namespace Teht2_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartFunc();

            // Create cars
            Car car1 = new();
            car1.AskData();

            Car car2 = new();
            car2.AskData();

            // Show car info
            Console.WriteLine("  Starting Car info:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();

            // Accelerate
            Console.WriteLine();
            car1.Accelerate(askSpeedDif(car1.brand));
            car2.Accelerate(askSpeedDif(car2.brand));
            Console.WriteLine("  Updated Car Info:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();

            // Brake
            Console.WriteLine("\n  Cars brake...");
            car1.Brake();
            car2.Brake();
            Console.WriteLine("\n  Updated Car Info:");
            car1.ShowCarInfo();
            car2.ShowCarInfo();


            PersonalFuncs.EndFunc();
        }
        public static double askSpeedDif(string brand)
        {
            double speedDif = 0;
            Console.WriteLine($"  Input how much faster '{brand}' is driving.");
            if (!double.TryParse(Console.ReadLine(), out speedDif))
            {
                Console.WriteLine("Invalid input, speed increase was set as 0");
            }
            return speedDif;
        }
    }
}