using ConsoleFigurePrinter.Displayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.Figures
{
    internal class Square : IFigure
    {
        private float _leftTopX;
        private float _leftTopY;
        private float _side;
        public Square(float ltx, float lty, float side)
        {
            _leftTopX = ltx;
            _leftTopY = lty;
            _side = side;
        }

        public void Draw(IDisplayer displayer)
        {
            throw new NotImplementedException();
        }
    }
}
