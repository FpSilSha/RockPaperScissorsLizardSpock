using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
       public void StartInstance()
       {  
            int gameChoice = -1;
            do
          {
            
            Console.WriteLine("\nHow many human players will be playing? Please choose 1 or 2");
            try
            {
               gameChoice = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("\nAnd here I thought the number system was universal to understand..."+
                    "\n Please choose a number that is 1 or 2 and input its Standard Form");
            }
          }
            while (gameChoice < 1 || gameChoice > 2);

            if(gameChoice == 1)
            {
                RunGame1();
            }
            else
            {
                RunGame2();
            }

       }

       
       public void RunGame1()
        {
            Player playerOne = new HumanPlayer();
            Player playerTwo = new AIPlayer();
            
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();



        }

        public void RunGame2()
        {
            Player playerOne = new HumanPlayer();
            Player playerTwo = new HumanPlayer();
            
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
        
       // public void 

    

   
    }
}
