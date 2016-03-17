using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{

    class Peg
    {
        int sp;
        int left,top,bot;
        Disc[] Discs;

        // Create a peg with the following parameters:
        // maxDisc: the maximum number of discs in the game
        // left, top, bot:
        // the peg is draw as a line of two pipes (||)
        // from <left, top> to <left, bot>
        public Peg(int maxDisc, int left, int top, int bot)
        {
            this.Discs = new Disc[maxDisc];
            
            this.left = left;
            this.top = top;
            this.bot = bot;
            this.sp = -1;
            
            
        }

        // Pushes dsc into the peg
        // if the peg is empty
        // or dsc.Size < size of the top disc in peg
       public bool Push(Disc dsc)
        {
            this.sp++;
            this.Discs[this.sp] = dsc;
            
            dsc.Move(this.left, this.bot - this.sp);
                return true;
            
        }

        // Pops a Disc from the peg and return
      public Disc Pop()
        {
            if (sp >= 0)
            {
                Disc removeDisc =this.Discs[sp];
                //Console.SetCursorPosition(i, Map.BaseTop);
                this.sp--;
                removeDisc.Move(-1, -1);
                return removeDisc;
            }
            return null;
        }

        // Returns the top most Disc without popping
        public Disc Peek()
        {
            if(this.sp>=0)
            {
                return this.Discs[sp];
            }
            return null;
        }

        // Draw the peg and all the discs in it.
        public void Draw()
        {
            
            for (int i = this.top; i <= this.bot; i++)
            {
                Console.SetCursorPosition(this.left, i);
                Console.WriteLine("||");   
            }
                for (int i = 0; i <=this.sp; i++)
                {

                    //Discs[i] = new Disc(i, Map.PegLeft[0], this.bot-i, Map.DiskColors[i]);
                    this.Discs[i].Draw(); 
                }
            
        }

        // Returns the number of discs in the peg
      public int DiscCount()
        {
            return sp;
        }
    }
}
