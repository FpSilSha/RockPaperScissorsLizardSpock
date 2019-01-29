using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        Player playerOne;
        Player playerTwo;
        uint bestOfGames;
    
       public void StartInstance()
       {    
            
            int gameChoice = -1;
            do
            {
                Console.WriteLine("\nHow many human players will be playing? Please choose 1 or 2");

                try
                {
                  gameChoice = Convert.ToInt16(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("\nAnd here I thought the number system was universal to understand..."+
                    "\n Please choose a number that is 1 or 2 and input its Standard Form");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Bruh. If English isn't your main language, please get a translator. 1 OR 2.");
                }
                
                if(gameChoice < 0)
                {
                     Console.WriteLine("I get it. Positive numbers can be hard. All you need to do is not put the '-' in your input... ok?");
                }
                else if (gameChoice > 2)
                {
                     Console.WriteLine("Great input! Now pick a number close to what I am asking. Something between the range of 1 and... maybe... 2?");
                }

            }
            while (gameChoice < 1 || gameChoice > 2);

            
          do
          {
            Console.WriteLine("How many games to play to the best of? Default is 3 (best of 3). Enter an integer in Standard Form.");
            try
            {

               uint bestOfResponse =  Convert.ToUInt16(Console.ReadLine());
                bestOfGames = bestOfResponse / 2 + 1;
                Console.WriteLine("First to " + bestOfGames + " points wins the game!");
            }
            catch(FormatException)
            {
                Console.WriteLine("Send an email and explain to me how you do a 'best of' with the input you provided. Try Again.");

            }
            catch(OverflowException)
            {
                Console.WriteLine("I am not sure why you would want to sit through THAT MANY rounds. But I don't want to run THAT many rounds. \n" +
                    " Figure out your life. Hopefully by when you want to replay."
                    + "\n Unless you entered a negative... then stay positive");
            }
          }
          while(bestOfGames < 1 || bestOfGames > UInt32.MaxValue);

            if(bestOfGames >= 50)
            {
                Console.WriteLine("We are going to be here for a long time....");
            }
            

            if(gameChoice == 1)
            {
                playerOne = new HumanPlayer();
                playerTwo = new AIPlayer();
                RunGame1();
            }
            else
            {
                playerOne = new HumanPlayer();
                Console.WriteLine("\n\n NEXT PLAYER");
                playerTwo = new HumanPlayer();
                RunGame2();
            }

       }

       
       public void RunGame1()
        {
            
            do
            {
                Console.Clear();
                Console.WriteLine("\n\nNew Round!");
                playerOne.ChooseGesture();
                Console.Clear();
                playerTwo.ChooseGesture();
                CompareGesture();
                WinnerCheck();
                Console.WriteLine("\nPress any key (enter?) to continue.");
                Console.ReadKey();

            }
            while (playerOne.score < bestOfGames && playerTwo.score < bestOfGames);
        }

        public void RunGame2()
        {
           do
            {
                Console.Clear();
                Console.WriteLine("\n\nNew Round!");
                playerOne.ChooseGesture();
                Console.Clear();
                playerTwo.ChooseGesture();
                CompareGesture();
                WinnerCheck();
                Console.WriteLine("\nPress any key (enter?) to continue.");
                Console.ReadKey();
            }
            while (playerOne.score < bestOfGames && playerTwo.score < bestOfGames);

        }
        public void DisplayRules()
        {
            Console.WriteLine(" Welcome to Rock Paper Scissors Lizard Spock!" +
                "\n\n The Rules are simple and follow regular Rock Paper Scissors with two additions!" +
                "\n\n Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock," +
                "\n\n Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats paper, Paper disproves Spock,"+
                "\n\n Spock vaporizes Rock, ... And as it always has, Rock crushes Scissors. Easy, right?");


        }
        
        public void CompareGesture()
        {
            Console.WriteLine("\n" + playerOne.name + " chose " + playerOne.gestureChoice + "\n" +
                playerTwo.name + " chose " + playerTwo.gestureChoice);

            switch(playerOne.gestureChoice)
            {
            case("Rock"):
                    if(playerTwo.gestureChoice == playerOne.gestureChoice)
                    {
                        Console.WriteLine("Drat! It's a tie!");
                        break;
                    }
                    else if(playerTwo.gestureChoice == "Scissors" || playerTwo.gestureChoice == "Lizard")
                    {
                        Console.WriteLine(playerOne.name + " wins! Point for "+playerOne.name + "!");
                        playerOne.score++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(playerTwo.name + " wins! Point for "+playerTwo.name + "!" );
                        playerTwo.score++;
                        break;
                    }
            case("Paper"):
                    if(playerTwo.gestureChoice == playerOne.gestureChoice)
                    {
                        Console.WriteLine("Drat! It's a tie!");
                        break;
                    }
                    else if(playerTwo.gestureChoice == "Rock" || playerTwo.gestureChoice == "Spock")
                    {
                        Console.WriteLine(playerOne.name + " wins! Point for "+playerOne.name + "!");
                        playerOne.score++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(playerTwo.name + " wins! Point for "+playerTwo.name + "!" );
                        playerTwo.score++;
                        break;
                    }
            case("Scissors"):
                    if(playerTwo.gestureChoice == playerOne.gestureChoice)
                    {
                        Console.WriteLine("Drat! It's a tie!");
                        break;
                    }
                    else if(playerTwo.gestureChoice == "Paper" || playerTwo.gestureChoice == "Lizard")
                    {
                        Console.WriteLine(playerOne.name + " wins! Point for "+playerOne.name + "!");
                        playerOne.score++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(playerTwo.name + " wins! Point for "+playerTwo.name + "!" );
                        playerTwo.score++;
                        break;
                    }
            case("Lizard"):
                    if(playerTwo.gestureChoice == playerOne.gestureChoice)
                    {
                        Console.WriteLine("Drat! It's a tie!");
                        break;
                    }
                    else if(playerTwo.gestureChoice == "Paper" || playerTwo.gestureChoice == "Spock")
                    {
                        Console.WriteLine(playerOne.name + " wins! Point for "+playerOne.name + "!");
                        playerOne.score++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(playerTwo.name + " wins! Point for "+playerTwo.name + "!" );
                        playerTwo.score++;
                        break;
                    }
            case("Spock"):
                    if(playerTwo.gestureChoice == playerOne.gestureChoice)
                    {
                        Console.WriteLine("Drat! It's a tie!");
                        break;
                    }
                    else if(playerTwo.gestureChoice == "Rock" || playerTwo.gestureChoice == "Scissors")
                    {
                        Console.WriteLine(playerOne.name + " wins! Point for "+playerOne.name + "!");
                        playerOne.score++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(playerTwo.name + " wins! Point for "+playerTwo.name + "!" );
                        playerTwo.score++;
                        break;
                    }

            }
        }

        public void WinnerCheck()
        {
            if(playerOne.score == bestOfGames)
            {
                Console.WriteLine("\n\n\n" + playerOne.name + " Has won the game!!");
            }
            else if(playerTwo.score == bestOfGames)
            {
                Console.WriteLine("\n\n\n" + playerTwo.name + " Has won the game!!");

            }

        }



   
    }
}
