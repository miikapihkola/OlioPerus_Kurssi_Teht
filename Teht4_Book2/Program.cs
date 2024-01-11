namespace Teht4_Book2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            winSize();
            Console.OutputEncoding = System.Text.Encoding.UTF8;




            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
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