namespace MyPersonalAdditions
{
    public class PersonalFuncs
    {
        static void Main(string[] args) 
        {
            
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
