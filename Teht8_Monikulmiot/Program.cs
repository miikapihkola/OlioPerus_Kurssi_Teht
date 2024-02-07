using Microsoft.VisualBasic;
using MyPersonalAdditions;
namespace Teht8_Monikulmiot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalFuncs.StartMeth();

            // Generating shapes

            List<Shape> shapes = new()
            {
                new Circle("Black", 11),
                new Circle("Blue", 22),
                new Circle("Pink", 33),
                new Rectangle("Black", 11, 22),
                new Rectangle("Blue", 22, 33),
                new Rectangle("Pink", 33, 44),
                new Triangle("Black", 11, 11),
                new Triangle("Blue", 22, 22),
                new Triangle("Pink", 33, 33)
            };

            // GetInfo using foreach

            foreach (Shape shape in shapes)
                Console.WriteLine(shape.GetInfo());

            // Only 1 shape (as Triangle)

            PersonalFuncs.PrintLine();
            foreach (Shape shape in shapes)
                if (shape is Triangle) Console.WriteLine(shape.GetInfo());

            // Sort and Test

            shapes.Sort();

            PersonalFuncs.PrintLine();
            foreach (Shape shape in shapes)
                Console.WriteLine(shape.GetInfo());

            


            PersonalFuncs.PrintLine();
            PersonalFuncs.EndMeth();
        }
    }
}
