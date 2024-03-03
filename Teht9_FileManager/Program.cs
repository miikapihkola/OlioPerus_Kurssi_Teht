using MyPersonalAdditions;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
namespace Teht9_FileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartMeth();

            //Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);
            string fileName = "txt1.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);
            FileManager fm1 = new FileManager(path);
            FileManager fm2 = new FileManager();
            
            fm1.ReadWords();
            Console.WriteLine("\n---\n");
            fm2.ReadWords();
            Console.WriteLine();
            PersonalFuncs.PrintLine();

            // De serialisointi
            fileName = "events.json";
            path = Path.Combine(Environment.CurrentDirectory, fileName);
            List<Event> events = JsonConvert.DeserializeObject<List<Event>>(File.ReadAllText(path));

            // Testi tulostus
            foreach (Event @event in events)
                Console.WriteLine(@event.ToString());

            // Re serialisointi
            path = @"C:\temp\reSerEvents.json";
            if (!File.Exists(path))
                File.Create(path).Close();
            File.WriteAllText(path, JsonConvert.SerializeObject(events));

            PersonalFuncs.PrintLine();
            PersonalFuncs.EndMeth();
        }
    }
}
