using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
     class HumanPlayer:Player
    {

        public HumanPlayer()
        {
            
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a gesture for the current fight to the death" +
                "\n Pick 0 for Rock, 1 for Paper, 2 for Scissors, 3 for Lizard, and 4 for Spock");
           



            }
        }
        public override void GiveName()
        {
            Console.WriteLine("Give me a name");
             name = Console.ReadLine();
            Console.WriteLine(" I AM " + name);
          
        }
    }
}
