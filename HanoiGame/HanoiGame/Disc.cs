using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiGame
{
    class Disc
    {
        
        int size, left, top;
        ConsoleColor color;
        // Constructor takes size, left, top and color.
        // size can be between 1 to 5
        public Disc(int size, int left, int top, ConsoleColor color)
        {
            this.size = size;
            this.left = left;
            this.top = top;
            this.color = color;
        }
               // Returns the size of the disc
               // this is a property with get method only
        public int Size
        {
            get
            {
                return this.size; 
            }
            
        }
     /*   private string Indent()
        {
            return "".PadLeft(2*size);
        }*/


        // Draws the disc by printing 2*size spaces starting
        // from position <left-size+1, top>, and then drawing
        // 2 two pipes (“||”) at position <left, top>
        public void Draw()
        {

            Console.BackgroundColor = this.color;
            Console.SetCursorPosition(this.left-this.size+1, this.top);
                
                for (int i = 0; i < (2 * this.size); i++)
                {
                    Console.Write(" ");
                }
                    //                Console.BackgroundColor = color;
                    //Console.Write(" ");
                    // Console.Write(Indent());

                    Console.SetCursorPosition(this.left, this.top);
                    Console.Write("||");
                    Console.ResetColor();
                
            
         }
               // Sets the coordinate of the disc to <left, top>
               // without actually drawing the disc on screen
     public void Move(int left, int top)
        {

            this.left=left;
            this.top=top;
        } 
    }
}
