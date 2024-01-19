namespace VrtTeht1_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartMeth();
            
            const int MaxEmployees = 10; 
            int idCounter = 0;

            // Generate employees
            Employee[] employees = new Employee[MaxEmployees];
            employees[idCounter] = new Employee(idCounter++) { name = "Aa Aa", position = "Project Manager"     , salary = 12500 }; // 1
            employees[idCounter] = new Employee(idCounter++) { name = "Bb Bb", position = "Lead Artist"         , salary = 4000 }; // 2
            employees[idCounter] = new Employee(idCounter++) { name = "Cc Cc", position = "Programer"           , salary = 2500 }; // 3
            employees[idCounter] = new Employee(idCounter++) { name = "Dd Dd", position = "Digital Artist"      , salary = 3000 }; // 4
            employees[idCounter] = new Employee(idCounter++) { name = "Ee Ee", position = "Community Manager"   , salary = 3000 }; // 5
            employees[idCounter] = new Employee(idCounter++) { name = "Ff Ff", position = "Digital Artist"      , salary = 3100 }; // 6
            employees[idCounter] = new Employee(idCounter++) { name = "Gg Gg", position = "Programer"           , salary = 3050 }; // 7
            employees[idCounter] = new Employee(idCounter++) { name = "Hh Hh", position = "Programer"           , salary = 3100 }; // 8
            employees[idCounter] = new Employee(idCounter++) { name = "Jj Jj", position = "Community Manager"   , salary = 2900 }; // 9
            employees[idCounter] = new Employee(idCounter++) { name = "Ii Ii", position = "Programer"           , salary = 2500 }; // 10

            // Info using Method
            PrintLine();
            Console.WriteLine("  EMPLOYEE INFO (using method)\n ");
            foreach (Employee employee in employees)
                employee.PrintEmployeeInfo();

            // Info using ToString
            PrintLine();
            Console.WriteLine("  EMPLOYEE INFO (using ToString)\n");
            foreach (Employee employee in employees)
                Console.WriteLine(employee.ToString());

            // Salary Comparison
            PrintLine();            
            Console.WriteLine("  SALARY COMPARISON\n");
            idCounter = 0;
            foreach (Employee employee in employees)
            {                
                if (employee == employees.Last())
                    employee.CompareSalary(employees[0]);
                else
                    employee.CompareSalary(employees[++idCounter]);
            }

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
