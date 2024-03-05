namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(  "\n  AL00CM20-3003 Olio-ohjelmoinnin perusteet 8.1.2024-8.3.2024 - Tentti\n" +
                                "  Pvm: 5.3.2024\n" +
                                "  Miika Pihkola\n");
            PrintDoubleLine();

            // Alustetaan tankit
            Console.WriteLine("  --- Säiliöiden luominen ---\n");

            List<Tank> tanks = new()
            {
                new("VESI", 100),
                new("RYPSIÖLJY", 100),
                new("OLIIVIÖLJY", 150)
            };
            
            PrintLine();

            // Tulostetaan lähtötilanne
            Console.WriteLine("  --- Tulostetaan säiliöiden lähtötilanne ---\n");

            foreach (Tank tank in tanks)
                Console.WriteLine(tank.ToString());
            
            PrintLine();

            // Lisätään nestettä
            Console.WriteLine("  --- Säiliöihin lisääminen ---\n");

            Console.WriteLine(tanks[0].AddToTank(110));
            Console.WriteLine(tanks[1].AddToTank(70));
            Console.WriteLine(tanks[2].AddToTank(-50));
            
            Console.WriteLine();
            PrintLine();

            // Poistetaan nestettä
            Console.WriteLine("  --- Säiliöistä poistaminen ---\n");

            foreach (Tank tank in tanks)
                Console.WriteLine(tank.RemoveFromTank(80));
            Console.WriteLine();

            Console.WriteLine();
            PrintLine();

            // Tyhjennetään säiliöt
            Console.WriteLine("  --- Säiliöiden tyhjennys ---\n");

            foreach (Tank tank in tanks)
                tank.ClearTank();

            Console.WriteLine();
            PrintLine();

            // Tulostetaan lopputilanne
            Console.WriteLine("  --- Tulostetaan säiliöiden lopputilanne ---\n");

            foreach (Tank tank in tanks)
                Console.WriteLine(tank.ToString());
            
            PrintDoubleLine();

            // Siisti lopetus
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        public static void PrintLine()
        {
            Console.WriteLine();
            for (int i = 0; i < 70; i++) Console.Write("#");
            Console.Write("\n\n");
        }
        public static void PrintDoubleLine()
        {
            Console.WriteLine();
            for (int i = 0; i < 70; i++) Console.Write("#");
            Console.Write("\n");
            for (int i = 0; i < 70; i++) Console.Write("#");
            Console.Write("\n\n");
        }
    }
}
