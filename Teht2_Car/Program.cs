namespace Teht2_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            winSize();
            Console.OutputEncoding = System.Text.Encoding.UTF8;

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


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
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
#pragma warning disable CA1416 // Validate platform compatibility 
        private static void winSize()
        {
            try { Console.SetWindowSize(75, 50); }
            catch { Console.WriteLine("\nCould not automatically resize console window.\n\nPress any key to continue..."); Console.ReadLine(); Console.Clear(); }
        }
#pragma warning restore CA1416 // Validate platform compatibility
    }
}