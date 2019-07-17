using System;

namespace Lab4DiceRolling
{
    class Program
    {
        public static Random die = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino!");
            bool play = true;
            while (play)
            {
                Console.Write("Would you like to roll the dice? (y/n): ");
                string userRoll = Console.ReadLine().ToLower();

                if (userRoll == "y")
                {
                    bool isNumber = false;
                    while (!isNumber)
                    {
                        string userNumber = InputString("How many sides should each die have ? ");
                        int dieNumber;
                        if (int.TryParse(userNumber, out dieNumber))
                        {
                            int result1 = RollDice(dieNumber);
                            int result2 = RollDice(dieNumber);
                            Console.WriteLine(result1);
                            Console.WriteLine(result2);
                            isNumber = true;
                        }
                        else
                        {
                            Console.WriteLine("That was not a proper input. Please try again");
                        }
                    }
                   
                    
                }
                else if (userRoll == "n")
                {
                    Console.WriteLine("Thank you for visiting us here at Grand Circus Casino.\nPlease come visit us again.");
                    play = false;
                }
                else
                {
                    Console.WriteLine("That is not an option. Please try again.");
                }
            }
            
        }

        public static int RollDice(int side)
        {
            int rollResult = die.Next(1, (side+1));
            return rollResult;
        } 
        public static string InputString(string message)
        {
            Console.Write(message);
            // retrieve
            string input = Console.ReadLine();
            return input;
        }
        

    }
}
