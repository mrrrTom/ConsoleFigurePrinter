using ConsoleFigurePrinter.Displayers;
using ConsoleFigurePrinter.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.FigureDrawers
{
    internal class ConsoleFigureDrawer : IFigureDrawer
    {
        private IDisplayer _displayer;
        public ConsoleFigureDrawer() 
        {
            _displayer = new ConsoleDisplayer();
        }

        public bool TryDraw(string figure)
        {
            if (string.IsNullOrEmpty(figure)) return false;
            FigureType type = ResolveType(figure);
            if (type == FigureType.Undefined) return false;
            Draw(type);
            return true;
        }

        private void Draw(FigureType type) 
        {
            if (FigureType.Undefined == type)
            {
                throw new ArgumentException("Undefined figure type");
            }

            IFigure figure = CreateFigure(type);
            if (figure == null)
            {
                throw new Exception("Figure was not created");
            }

            figure.Draw(_displayer);
        }

        private IFigure CreateFigure(FigureType type)
        {
            IFigure result = null;
            switch (type)
            {
                // insert test values, or add coordinates insertion from console
                case FigureType.Square:
                    //result = new Square();
                    break;
                case FigureType.Circle:
                    //result = new Circle();
                    break;
                case FigureType.Quadrilateral:
                   //result = new Quadrilateral();
                    break;
                case FigureType.Triangle:
                    //result = new Triangle();
                    break;
                case FigureType.Ellipse:
                   // result = new Ellipse();
                    break;
            }

            return result;
        }

        private FigureType ResolveType(string figure)
        {
            switch (figure)
            {
                case "c":
                    return FigureType.Circle;
                case "e":
                    return FigureType.Ellipse;
                case "q":
                    return FigureType.Quadrilateral;
                case "s":
                    return FigureType.Square;
                case "t":
                    return FigureType.Triangle;
                default:
                    return FigureType.Undefined;
            }
        }
    }
}
