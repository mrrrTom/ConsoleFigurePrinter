using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.Displayers
{
    internal interface IDisplayer
    {
        bool TryDrawPoint(float x, float y);
    }
}
