using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigurePrinter.Displayers
{
    internal class ConsoleDisplayer : IDisplayer
    {
        public bool TryDrawPoint(float x, float y)
        {
            int cursorX = 0;
            int cursorY = 0;
            try
            {
                cursorX = (int)x;
                cursorY = (int)y;
            }
            catch 
            {
                return false;
            }

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("0");
            return true;
        }
    }
}
