using ConsoleFigurePrinter.Displayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.Figures
{
    internal class Triangle : IFigure
    {
        private float _firstX;
        private float _firstY;
        private float _secondX;
        private float _secondY;
        private float _thirdX;
        private float _thirdY;
        public Triangle(float fx, float fy, float sx, float sy, float tx, float ty)
        {
            _firstX = fx;
            _firstY = fy;
            _secondX = sx;
            _secondY = sy;
            _thirdX = tx;
            _thirdY = ty;
        }

        public void Draw(IDisplayer displayer)
        {
            throw new NotImplementedException();
        }
    }
}
