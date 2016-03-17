using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Input inp = new Input();
            // read the number of discs in the game (3, 4 or 5)
            int nDisc = inp.GetDiscCount();         //Introduce Explaining Variable
            // create a Tower of Hanoi game 
            Game game = new Game(nDisc);
            // Draw the game board
            
            game.Draw();        //Extract method            
            do
            {
                // Get source and destination pegs
                game.SrcPegPrompt();
                int src = inp.GetPosition();        //Introduce Explaining Variable
                if (src < 0)
                    break;
                game.DstPegPrompt();
                int dst = inp.GetPosition();        //Introduce Explaining Variable
                if (dst < 0)
                    break; 
                // Try to move a disc from src to dst
             bool success = game.Move(src, dst);
                // Redraw the game board
             game.Draw();        //Extract method 
                if (!success)
                {
                    game.Message("Invalid Move "+ (src+1) +" -> " + (dst+1));
                }
            } while (!game.Win());
            game.Message("Press any key to exit!");
            Console.ReadLine();
        }
    }
}
