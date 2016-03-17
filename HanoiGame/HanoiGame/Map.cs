using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    class Map
    {
        public const int MaxTop = 30;       //Extract Constant
        public const int MaxLeft = 100;     //Extract Constant
        public const int BaseLeft = 5;      //Extract Constant
        public const int BaseRight = 95;    //Extract Constant
        public const int BaseTop = 18;      //Extract Constant
        public const int PegTop = 10;       //Extract Constant
        public const int PegBot = 17;       //Extract Constant
        public static int[] PegLeft = { 20, 50, 80 };
        public const int SrcLeft = 5;       //Extract Constant
        public const int SrcTop = 23;       //Extract Constant
        public const int DstLeft = 35;      //Extract Constant
        public const int DstTop = 23;       //Extract Constant
        public const int MsgLeft = 5;       //Extract Constant
        public const int MsgTop = 25;       //Extract Constant
        public const int MovesLeft = 5;     //Extract Constant
        public const int MovesTop = 2;      //Extract Constant
        public static ConsoleColor[] DiskColors =
            {
            ConsoleColor.Red,       // Disk 1 color
            ConsoleColor.Green,     // Disk 2 color
            ConsoleColor.Yellow,   // Disk 3 color
            ConsoleColor.Cyan,     // Disk 4 color
            ConsoleColor.Blue     // Disk 5 color 
        };
    }
}
