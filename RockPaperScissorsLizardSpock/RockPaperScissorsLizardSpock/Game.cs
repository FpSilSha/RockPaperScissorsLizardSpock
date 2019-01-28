using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
       Player playerOne = new HumanPlayer();
       Player playerTwo = new AIPlayer();

       
       public void RunGame()
        {
       
            playerOne.GiveName();
            playerTwo.GiveName();
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();



        }

        public void DisplayRules()
        {
            Console.WriteLine(" Welcome to Rock Paper Scissors Lizard Spock!" +
                "\n\n The Rules are simple and follow regular Rock Paper Scissors with two additions!" +
                "\n\n Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock," +
                "\n\n Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats paper, Paper disproves Spock,"+
                "\n\n Spock vaporizes Rock, ... And as it always has, Rock crushes Scissors. Easy, right?");


        }
        


    }

   
    
}
