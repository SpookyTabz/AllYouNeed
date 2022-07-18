using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllYouNeed.Hardware.IO
{
    public static class MousePS2
    {
        // position
        public static int X
        {
            get
            {
                return (int)Cosmos.System.MouseManager.X;
            }
            set
            {
                Cosmos.System.MouseManager.X = (uint)value;
            }
        }
        public static int Y
        {
            get
            {
                return (int)Cosmos.System.MouseManager.Y;
            }
            set
            {
                Cosmos.System.MouseManager.Y = (uint)value;
            }
        }
        public static Cosmos.System.MouseState State
        {
            get
            {
                return Cosmos.System.MouseManager.MouseState;
            }

            set
            {
                Cosmos.System.MouseManager.MouseState = value;
            }
        }

        // initialization
        public static void Initialize(uint w, uint h)
        {
            Cosmos.System.MouseManager.ScreenWidth = w;
            Cosmos.System.MouseManager.ScreenHeight = h;
        }
    }
}
