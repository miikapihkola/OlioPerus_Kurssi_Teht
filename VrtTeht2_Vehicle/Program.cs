﻿using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace VrtTeht2_Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartMeth();

            int counter = 0;            
            const int maxCars = 2;
            const int maxVehicles = 2;


            Vehicle[] vehicles = new Vehicle[maxVehicles];
            vehicles[counter++] = new Vehicle("make1", "model1", 2001, 12345.67);
            vehicles[counter++] = new Vehicle("make2", "model2", 2002, 23456.78);


            counter = 0;
            Car[] cars = new Car[maxCars];
            cars[counter++] = new Car("eng1", "type1", 4, "make3", "model3", 2003, 34567.89);
            cars[counter++] = new Car("eng2", "type2", 2, "make4", "model4", 2004, 45678.90);

            PrintLine();
            foreach(Vehicle vehicle in vehicles) 
                vehicle.PrintInformation();

            PrintLine();
            foreach (Car car in cars)
                car.PrintInformation();

            PrintLine();

            EndMeth();
        }

        // Methods

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
