using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    class Game
    {
        Peg[] Pegs;
        Disc[] Discs;
        int nDisc, count=0;
        int src, dst;

        // Constructor :
        // takes the number of discs ( nDisc ) in the game.
        // 1. Creates 3 pegs
        // 2. Creates n discs with size 1, 2, 3 etc. and pushes them to peg 0
        // 3. Sets Console size to Map.MaxLeft and Map.MaxTop
        public Game(int nDisc)
        {
            this.nDisc = nDisc;
            CreatePeg();        //Extract Method

            CreateDisc();       //Extract Method

            PushDisc();         //Extract Method
            
        }

        private void CreatePeg()
        {
            Pegs = new Peg[3];
            for (int i = 0; i < 3; i++)
            {
                Pegs[i] = new Peg(this.nDisc, Map.PegLeft[i], Map.PegTop, Map.PegBot);
            }
        }

        private void CreateDisc()
        {
            this.Discs = new Disc[nDisc];
            for (int i = 0; i < this.nDisc; i++)
            {
                Discs[i] = new Disc(i + 1, Map.PegLeft[0], Map.PegTop, Map.DiskColors[i]);
            }
        }

        private void PushDisc()
        {
            for (int i = nDisc - 1; i >= 0; i--)
            {
                this.Pegs[0].Push(this.Discs[i]);
            }
            Console.SetWindowSize(Map.MaxLeft, Map.MaxTop);
        }

        // Moves top disk of Pegs[src] to Pegs[dst] if …
        // IF src and dst are in [0...2] and 
        // Pegs[src] has a disc and 
        // (Pegs[dst] is empty or 
        // top disc in Pegs[dst] > top disc in Pegs[src])
        // returns true if the move was done 
        // Does not redraw the board
       public bool Move(int src, int dst)
        {
            this.src = src;
            this.dst = dst;
            if((this.src>=0 && this.src<=2) && (this.dst >= 0 && this.dst <= 2))
            {
                if(Pegs[this.src].Peek()!=null)
                {
                    if (Pegs[this.dst].Peek() == null || Pegs[this.dst].Peek().Size > Pegs[this.src].Peek().Size)
                    {
                        this.count++;
                        Pegs[this.dst].Push(Pegs[this.src].Pop());
                        return true;
                    }
                }
            }
            return false;
       }

        // Prints msg to Map.MsgLeft, Map.MsgTop location
        // in yellow text on dark red background
       public void Message(string msg)
        { 
            Console.SetCursorPosition(Map.MsgLeft, Map.MsgTop);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);    
       }   

        // Draws the followings:
        // 0. Clear the screen first
        // 1. Base line from <Map.Baseleft, Map.BaseTop> to
        // <Map.BaseRight, Map.BaseTop>
        // 2. Three pegs and the discs in them 
        // 3. Number of moves at <Map.MovesLeft, Map.MovesTop>
        public void Draw()
        {
            Console.Clear();
            Console.SetCursorPosition(Map.BaseLeft, Map.BaseTop);
            for (int i=Map.BaseLeft; i<=Map.BaseRight;i++)
            {
                
                Console.Write("=");
            }
            for (int i = 0; i < 3; i++)
            {   
                //Pegs[i] = new Peg(this.nDisc, Map.PegLeft[i], Map.PegTop, Map.PegBot);
                Pegs[i].Draw();
            }

            Console.SetCursorPosition(Map.MovesLeft, Map.MovesTop);
            Console.Write("Number of Moves:{0}", this.count);
        }
        // Checks if the game is over,
        // i.e. right peg has all the discs
        public bool Win()
        {
            if ((Pegs[2].DiscCount()) == this.nDisc-1)
            {
                return true;
            }
            return false;
        }
        // Prints source peg prompt "Src peg (1,2,3,q): "
        // at position <Map.SrcLeft, Map.SrcTop>
        public void SrcPegPrompt()
        {
            Console.SetCursorPosition(Map.SrcLeft, Map.SrcTop);
            Console.Write("Src peg (1,2,3,q):");
        }
        // Prints destination peg prompt "Dst peg (1,2,3,q): " 
        // at position <Map.DstLeft, Map.DstTop>
        public void DstPegPrompt()
        {
            Console.SetCursorPosition(Map.DstLeft, Map.DstTop);
            Console.Write("Dst peg (1,2,3,q):");
        }

    }
}
