using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            bool replay = true;
            Game nGame = new Game();
            nGame.DisplayRules();
            uint replayResponse = 3;
           do
            {            
             nGame.StartInstance();
             
                do
                {
                    try
                    {
                        Console.WriteLine("\n\n\nWould you like to play again? Enter 1 for yes and 2 for no.");
                        replayResponse = Convert.ToUInt16(Console.ReadLine());
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("You were given two options. How is it this hard? 1 OR 2 buddy. 1 OR 2.");
                    }
                    catch(OverflowException)
                    {
                        Console.WriteLine("1 or 2 will suffice. Not a negative. Not what you want your"
                            + " bank account to look like.");
                    }
                }
                while(replayResponse != 1 && replayResponse != 2);
                if(replayResponse == 2)
                {
                    replay = false;
                }

            }
           while(replay);
        



        }
    }
}
