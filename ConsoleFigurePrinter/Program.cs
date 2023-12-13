using ConsoleFigurePrinter.FigureDrawers;

namespace ConsoleFigurePrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the figure drawer application!");
            Console.WriteLine("Insert first letter of the figure, you want to draw");
            IFigureDrawer fd = new ConsoleFigureDrawer();
            while (true)
            {
                Console.WriteLine("circle -> c; ellipse -> e; quadrilateral -> q; square -> s; triangle -> t");
                Console.Write(" : ");
                string figureToDraw = Console.ReadLine();
                if (!fd.TryDraw(figureToDraw)) Console.WriteLine("Sorry, I can not handle your input, try another one!");
                Console.WriteLine();
            }


        }
    }
}