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
                Console.WriteLine("\nChoose a gesture for the current fight to the death" +
                    "\n Pick 0 for Rock, 1 for Paper, 2 for Scissors, 3 for Lizard, and 4 for Spock");
               try
               {
                  numberChoice = Convert.ToInt32(Console.ReadLine());
                   
               }
               catch (FormatException) 
               {
                Console.WriteLine("\nYea....... I'm going to need you to not type anything other than a " + 
                    "POSITIVE NUMBER BETWEEN 0 - 4, capiche?");

               }
               catch (OverflowException)
               {

               }
                if(numberChoice < 0 || numberChoice > gestures.Count)
                {
                   Console.WriteLine("\nInvalid choice made! Please pick a POSTIVE NUMBER BETWEEN 0 and 4!");
  
                }
              
            }
            while(numberChoice < 0 || numberChoice > gestures.Count );
            gestureChoice = gestures[numberChoice]; 
            Console.WriteLine(gestureChoice);
        }
        public override void GiveName()
        {
            Console.WriteLine("\nGive me a name");
             name = Console.ReadLine();
            Console.WriteLine("\nI AM " + name);
          
        }
    }
}
