using ConsoleFigurePrinter.Displayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.Figures
{
    internal class Circle : IFigure
    {
        private float _radius;
        private float _x;
        private float _y;
        public Circle(float x, float y, float r) 
        {
            _radius = r;
            _x = x;
            _y = y;
        }

        public void Draw(IDisplayer displayer)
        {
            throw new NotImplementedException();
        }
    }
}
