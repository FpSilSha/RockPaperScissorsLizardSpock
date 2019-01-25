using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {

        public string name;
        public string gestureChoice;
        public int score;


        public Player()
        {
            
        }
        public virtual void GiveName()
        {
            
           
        }

        public virtual void ChooseGesture()
        {



        }






    }
}
