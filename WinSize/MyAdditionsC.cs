namespace MyAdditions
{
    public class MyAdditionsC
    {
        static void Main(string[] args) { }
        public void winSize()
        {
#pragma warning disable CA1416 // Validate platform compatibility            
            try { Console.SetWindowSize(75, 50); }
            catch { Console.SetWindowSize(70, 40); Console.WriteLine("\nCould not automatically resize console window to optimal size.\n\nPress [Enter] to continue."); Console.ReadLine(); Console.Clear(); }
#pragma warning restore CA1416 // Validate platform compatibility
        }
    }
}