using ConsoleFigurePrinter.Displayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.Figures
{
    internal class Quadrilateral : IFigure
    {
        private float _leftTopX;
        private float _leftTopY;
        private float _rightBottomX;
        private float _rightBottomY;
        public Quadrilateral(float ltx, float lty, float rbx, float rby) 
        {
            _leftTopX = ltx;
            _leftTopY = lty;
            _rightBottomX = rbx;
            _rightBottomY = rby;
        }

        public void Draw(IDisplayer displayer)
        {
            throw new NotImplementedException();
        }
    }
}
