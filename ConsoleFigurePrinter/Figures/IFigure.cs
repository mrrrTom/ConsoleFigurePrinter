using ConsoleFigurePrinter.Displayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.Figures
{
    internal interface IFigure
    {
        void Draw(IDisplayer displayer);
    }
}
