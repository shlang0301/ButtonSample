using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace ButtonSample
{
    class GameObject
    {
        private int speedX;
        private int speedY;
        private int ClientHeight;
        private int ClientWidth;
        private int _size;

        public GameObject(int size,int client)
        {

        }

        public void Render (ConsoleGraphics graphics)
        {
            graphics.FillRectangle();
        }
    }
}
