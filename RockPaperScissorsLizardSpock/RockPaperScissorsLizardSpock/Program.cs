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
            uint replayResponse;
           do
            {            
            nGame.StartInstance();
            Console.WriteLine("\n\n\nWould you like to play again? Enter 1 for yes and 2 for no.");
                do
                {
                    try
                    {
                        replayResponse = Convert.ToUInt32(Console.ReadLine());
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("You were given two options. How is it this hard? 1 OR 2 buddy. 1 OR 2.");
                    }
                }
                while(!replayResponse == 1 || !replayResponse == 2);
                if(replayResponse == 2)
                {
                    replay = false;
                }

            }
           while(replay);
        



        }
    }
}
