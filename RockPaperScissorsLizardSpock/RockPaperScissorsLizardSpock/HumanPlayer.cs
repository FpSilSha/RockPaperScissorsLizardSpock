using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissorsLizardSpock
{
     class HumanPlayer:Player
    {
        int numberChoice = 5;

        public HumanPlayer()
        {
         GiveName();
        }

        public override void ChooseGesture()
        {
            do {
                Console.WriteLine("\nChoose a gesture for the current fight to the death, " + this.name +
                    "\n Pick 0 for Rock, 1 for Paper, 2 for Scissors, 3 for Lizard, and 4 for Spock");
               try
               {
                  numberChoice = Convert.ToInt16(Console.ReadLine());
                  gestureChoice = gestures[numberChoice]; 
                  
               }
               catch (FormatException) 
               {
                Console.WriteLine("\nYea....... I'm going to need you to not type anything other than a " + 
                    "POSITIVE NUMBER BETWEEN 0 - 4, capiche?");

               }
               catch (OverflowException)
               {
                    Console.WriteLine("Wow... You couldn't have been more off...unless you kept adding digits. Please comply? Wont continue otherwise..");
               }
               catch (ArgumentOutOfRangeException)
               {
                Console.WriteLine("You 'almost' did it. But.. Almost doing something, isn't doing it. Try again");
               }

                if(numberChoice < 0 || numberChoice >= gestures.Count)
                {
                   Console.WriteLine("\nInvalid choice made!");
  
                }
              


            }
            while(numberChoice < 0 || numberChoice >= gestures.Count );

        }
        public override void GiveName()
        {
            Console.WriteLine("\nGive you...me? a name");
             name = Console.ReadLine();
            Console.WriteLine("\nI AM " + name);
          
        }
    }
}
