using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_scissors
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            string playerInput, cpu;
            bool playAgain = true;
            int rndm;
            while (playAgain = true)

            {

            
            int playerScore = 0;
            int cpuScore = 0;
                while (playerScore < 3 && cpuScore < 3)
                {


                    Console.WriteLine("please choose either of the following:- \n1.rock\n2.paper\n3.scissors\n");

                    playerInput = Console.ReadLine().ToLower();

                    Random rnd = new Random();
                    rndm = rnd.Next(1, 4);
                    switch (rndm)
                    {
                        case 1:
                            cpu = "rock";
                            Console.WriteLine("computer chose rock");
                            if (playerInput == "rock")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (playerInput == "paper")
                            {
                                Console.WriteLine("you win!\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "scissors")
                            {
                                Console.WriteLine("computer wins!\n\n");
                                cpuScore++;
                            }
                            break;
                        case 2:
                            cpu = "paper";
                            Console.WriteLine("computer chose paper");
                            if (playerInput == "paper")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (playerInput == "scissors")
                            {
                                Console.WriteLine("you win!\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "rock")
                            {
                                Console.WriteLine("computer wins!\n\n");
                                cpuScore++;
                            }

                            break;
                        case 3:
                            cpu = "scissors";
                            Console.WriteLine("computer chose scissors");
                            if (playerInput == "scissors")
                            {
                                Console.WriteLine("DRAW\n\n!");
                            }
                            else if (playerInput == "rock")
                            {
                                Console.WriteLine("you win!\n\n");
                                playerScore++;
                            }
                            else if (playerInput == "paper")
                            {
                                Console.WriteLine("computer wins!\n\n");
                                cpuScore++;
                            }

                            break;
                        default:
                            Console.WriteLine("pls type the valid option");
                            break;
                    }
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", playerScore, cpuScore);
                }
                    Console.WriteLine("want to play again?  Y/n");
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        playAgain = true;
                    Console.Clear();
                    }
                    else if (loop == "n")
                    {
                        playAgain = false;
                    }
                
            }
            
        }
    }
}
