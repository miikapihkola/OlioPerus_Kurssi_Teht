namespace VrtTeht1_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartFunc();

            int idCounter = 0;
            const int MaxEmployees = 10;

            Employee[] employees = new Employee[MaxEmployees];
            employees[idCounter] = new Employee(idCounter++) { name = "Aa Aa", position = "Project Manager", salary = 5000 };   // 1
            employees[idCounter] = new Employee(idCounter++) { name = "Bb Bb", position = "Lead Artist", salary = 4000 };       // 2
            employees[idCounter] = new Employee(idCounter++) { name = "Cc Cc", position = "Programmer", salary = 2500 };        // 3
            employees[idCounter] = new Employee(idCounter++) { name = "Dd Dd", position = "Digital Artist", salary = 3000 };    // 4
            employees[idCounter] = new Employee(idCounter++) { name = "Ee Ee", position = "Community Manager", salary = 3000 }; // 5
            employees[idCounter] = new Employee(idCounter++) { name = "Ff Ff", position = "Digital Artist", salary = 3100 };    // 6
            employees[idCounter] = new Employee(idCounter++) { name = "Gg Gg", position = "Programmer", salary = 2700 };        // 7
            employees[idCounter] = new Employee(idCounter++) { name = "Hh Hh", position = "Programmer", salary = 3100 };        // 8
            employees[idCounter] = new Employee(idCounter++) { name = "Jj Jj", position = "Community Manager", salary = 2900 }; // 9
            employees[idCounter] = new Employee(idCounter++) { name = "Ii Ii", position = "Programmer", salary = 2900 };        // 10

            Console.WriteLine("  EMPLOYEE INFO (using method)\n ");
            foreach (Employee employee in employees)
                employee.PrintEmployeeInfo();

            Console.WriteLine("  EMPLOYEE INFO (using ToString)\n");
            foreach (Employee employee in employees)
                Console.WriteLine(employee.ToString());

            idCounter = 0;
            Console.WriteLine("  SALARY COMPARISON\n");
            foreach (Employee employee in employees)
            {                
                if (employee == employees.Last())
                { employee.CompareSalary(employees[0]); }
                else
                    employee.CompareSalary(employees[++idCounter]);
            }

            EndFunc();
        }
#pragma warning disable CA1416 // Validate platform compatibility 
        public static void StartFunc()
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
                Console.SetWindowSize(75, 50);
            }
            catch (PlatformNotSupportedException) { Console.WriteLine($"{couldNot}PlatformNotSupportedException\n{cont}"); Console.ReadLine(); Console.Clear(); }
            catch (System.ArgumentOutOfRangeException) { Console.WriteLine($"{couldNot}Screen is too small and/or console font is too large for set parameters.\nArgumentOutOfRangeException\n{cont}"); Console.ReadLine(); Console.Clear(); }
            catch { Console.WriteLine($"{couldNot}{cont}"); Console.ReadLine(); Console.Clear(); }
            Console.WriteLine();
        }
        public static void EndFunc()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
#pragma warning restore CA1416 // Validate platform compatibility
    }
}
