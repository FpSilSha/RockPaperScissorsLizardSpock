using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissorsLizardSpock
{
    class AIPlayer:Player
    {
        List<string> aiNamesFirstHalf = new List<string>() {"Dancing", "Fighting", "Laughing", "Writhing", "Prancing", "Frolicking", "GenericName" };
        List<string> aiNamesSecondHalf = new List<string>() {"Robot", "Enemy","IntelligenceThatIsBetterThanYou","A.I.", "CoolVersionOfYou","Winner","OutOfNames" };
        string nameFirstHalf;
        string nameSecondHalf;
        Random Rand = new Random();



        public AIPlayer()
	{
            GiveName();
	}


        public override void ChooseGesture()
        {
            gestureChoice = gestures[Rand.Next(0, gestures.Count)];
            
        }

        public override void GiveName()
        {
            nameFirstHalf = aiNamesFirstHalf[Rand.Next(0, aiNamesFirstHalf.Count)];
            nameSecondHalf = aiNamesSecondHalf[Rand.Next(0, aiNamesSecondHalf.Count)];
            name = nameFirstHalf + " " + nameSecondHalf;
            Console.WriteLine("The computer player " + name + " is ready to rumble!");
        }





    }







}
