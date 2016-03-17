using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    class Input
    {
        // Reads a position from the user as follows:
        // -- valid inputs are 1, 2, 3 or q with return values 0, 1, 2 or -1, respectively.
        // -- typed characters are not display on screen until the user types a valid character
        public int GetPosition()
        {
            while (true)
            {
                ConsoleKeyInfo k = Console.ReadKey(true);
                int value=0;
                if (k.KeyChar > '0' && k.KeyChar <= '3' || k.KeyChar == 'q')
                {
                    switch (k.KeyChar)
                    {
                        case '1':
                            Console.Write(1);
                            value = 0;
                            break;
                        case '2':
                            value = 1;
                            Console.Write(2);
                            break;
                        case '3':
                            Console.Write(3);
                            value = 2;
                            break;
                        case 'q':
                        case 'Q':
                            Console.Write("q");
                            value = -1;
                            break;
                    }
                    return value;
                }
            }
            
        }
        // Reads the number of discs as follows:
        // -- Prompt with "How many discs (3...5)?"
        // -- Valid input is between 3 to 5
        // -- Should take care of invalid input
        public int GetDiscCount()
        {
            int noOfDiscs = 0;
        Again:
            Console.Write("How many discs(3...5)?");
            try
            {
                noOfDiscs = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
            if (noOfDiscs >= 3 && noOfDiscs <= 5)
            {
                return noOfDiscs;
            }
            else
            {
                Console.WriteLine("Error: Input string was not in a correct format.");
                goto Again;
            }
        }
    }
}
