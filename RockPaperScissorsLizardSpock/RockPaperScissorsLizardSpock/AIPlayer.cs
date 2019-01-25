using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class AIPlayer:Player
    {
        List<string> aiNamesFirstHalf = new List<string>() {"Dancing", "Fighting", "Laughing", "Writhing", "Prancing", "frolicking", "GenericName" };
        List<string> aiNamesSecondHalf = new List<string>() {"Robot", "Enemy","IntelligenceThatIsBetterThanYou","A.I.", "CoolVersionOfYou","Winner","OutOfThings" };
        string nameFirstHalf;
        string nameSecondHalf;
        Random Rand = new Random();
        public override void ChooseGesture()
        {
            gestureChoice = gestures[Rand.Next(0, gestures.Count)];
            Console.WriteLine(gestureChoice);
        }

        public override void GiveName()
        {
            nameFirstHalf = aiNamesFirstHalf[Rand.Next(0, aiNamesFirstHalf.Count)];
            nameSecondHalf = aiNamesSecondHalf[Rand.Next(0, aiNamesSecondHalf.Count)];
            name = nameFirstHalf + " " + nameSecondHalf;
            Console.WriteLine(name + " is ready to rumble!");
        }





    }







}
