using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.FigureDrawers
{
    internal interface IFigureDrawer
    {
        bool TryDraw(string figure);
    }
}
