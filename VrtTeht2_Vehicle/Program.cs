using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace VrtTeht2_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartMeth();

            int counter = 0;            
            const int maxCars = 3;
            //const int maxVehicles = 2;
            const int maxTrucks = 2;


            // ----- Generate vehicles, cars & trucks -----

            /*
            Vehicle[] vehicles = new Vehicle[maxVehicles];
            vehicles[counter++] = new Vehicle("make1", "model1", 2001, 12345.67);
            vehicles[counter++] = new Vehicle("make2", "model2", 2002, 23456.78);
            */
            counter = 0;
            Car[] cars = new Car[maxCars];
            cars[counter++] = new Car("eng1", "type1", 4, "make3", "model3", 2003, 34567.89);
            cars[counter++] = new Car("eng2", "type2", 2, "make4", "model4", 2004, 45678.90);
            cars[counter++] = new Car("eng2", "type2", 2, "make4", "model4", 2004, 45678.90);

            counter = 0;
            Truck[] trucks = new Truck[maxTrucks];
            trucks[counter++] = new Truck(10000, 1.1, "eng3", "type3", 5, "make5", "model5", 2005, 56789.01);
            trucks[counter++] = new Truck(22000, 2.2, "eng4", "type4", 6, "make6", "model6", 2006, 67890.12);


            // ----- PrintInfos -----

            /*
            PrintLine();
            Console.WriteLine("  Vehicle - PrintInfo\n");
            foreach(Vehicle vehicle in vehicles) 
                vehicle.PrintInformation();
            */
            PrintLine();
            Console.WriteLine("  Car - PrintInfo\n");
            foreach (Car car in cars)
                car.PrintInformation();

            PrintLine();
            Console.WriteLine("  Truck - PrintInfo\n");
            foreach (Truck truck in trucks)
                truck.PrintInformation();


            // ----- ToStrings -----

            /*
            PrintLine();
            Console.WriteLine("  Vehicle - ToString\n");
            foreach (Vehicle vehicle in vehicles)
                Console.WriteLine(vehicle.ToString());
            */
            PrintLine();
            Console.WriteLine("  Car - ToString\n");
            foreach (Car car in cars)
                Console.WriteLine(car.ToString());

            PrintLine();
            Console.WriteLine("  Truck - ToString\n");
            foreach (Truck truck in trucks)
                Console.WriteLine(truck.ToString());


            // ----- Equals(obj) -----

            PrintLine();
            Console.WriteLine("  Car - Equals(obj)\n");
            CompareCars(cars[0], cars[1]);
            CompareCars(cars[1], cars[2]);


            // ----- Consumption Method -----

            PrintLine();
            Console.WriteLine("  Truck - Consumption Method\n");
            Console.WriteLine($"  Truck 0 has consumption: {trucks[0].CalculateConsumption():F2}");
            Console.WriteLine($"  Truck 1 has consumption: {trucks[1].CalculateConsumption():F2}\n");


            // ----- Type Casting -----

            PrintLine();
            Console.WriteLine("  Car to Truck");
            Truck? carToTruck = cars[0] as Truck;
            Console.WriteLine($"  Trying to print:\n{carToTruck?.ToString()}\n");

            Console.WriteLine("  Truck to Car");
            Car truckToCar = trucks[0] as Car;
            Console.WriteLine($"  Trying to print:\n{truckToCar?.ToString()}\n");



            PrintLine();
            EndMeth();
        }

        // Methods

        public static void CompareCars(Car car1, Car car2)
        {
            if (car1.Equals(car2))
                Console.WriteLine("  These cars are similar\n");
            else
                Console.WriteLine("  These cars are different\n");
        }

#pragma warning disable CA1416 // Validate platform compatibility 
        public static void StartMeth()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string couldNot = "\nCould not automatically resize console window.\n";
            string cont = "\nPress any key to continue...";
            try
            {
                // To make this work in Win11 go to:
                // Settings -> System -> For Developers -> Terminal -> Windows Console Host
                // Asetukset -> Järjestelmä -> Kehittäjille -> Pääte -> Windows-konsolin isäntä
                // However even if this does not work, this does not trigger exception when using Windows Terminal.
                Console.SetWindowSize(75, 55);
            }
            catch (PlatformNotSupportedException) { Console.WriteLine($"{couldNot}PlatformNotSupportedException\n{cont}"); Console.ReadLine(); Console.Clear(); }
            catch (System.ArgumentOutOfRangeException) { Console.WriteLine($"{couldNot}Screen is too small and/or console font is too large for set parameters.\nArgumentOutOfRangeException\n{cont}"); Console.ReadLine(); Console.Clear(); }
            catch { Console.WriteLine($"{couldNot}{cont}"); Console.ReadLine(); Console.Clear(); }
            Console.WriteLine();
        }

        public static void EndMeth()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void PrintLine()
        {
            for (int i = 0; i < 75; i++) Console.Write("#");
            Console.Write("\n\n");
        }
#pragma warning restore CA1416 // Validate platform compatibility
    }
}
