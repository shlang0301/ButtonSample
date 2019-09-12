using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace ButtonSample
{
    class Canvas
    {
        private readonly uint _color;
        public int ClientWidht { get; }
        public int ClientHeight { get; }

        public Canvas(uint color, int widht, int height)
        {
            _color = color;
            ClientHeight = height;
            ClientWidht = widht;
        }

        public void Render(ConsoleGraphics graphics)
        {
            graphics.FillRectangle(_color, 0, 0, ClientWidht, ClientHeight);
        }
    }
}
