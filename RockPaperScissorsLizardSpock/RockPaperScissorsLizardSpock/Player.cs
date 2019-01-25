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
        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

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
