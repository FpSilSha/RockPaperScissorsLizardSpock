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
            Console.WriteLine("Choose a gesture for the current fight to the death");
           
            Console.ReadLine();
        }

        public override void GiveName()
        {
            Console.WriteLine("Give me a name");
            name = Console.ReadLine();
        }
    }
}
