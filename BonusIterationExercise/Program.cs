using System;

namespace BonusIterationExercise
{
    class Program
    {
        public static void NumberCall()
        {

            for (int num = -1000; num >= -1000 && num <= 1000; num++)
            {
                Console.WriteLine(num);
            }


        }

        public static void FunkyCall()
        {
            var i = 0;
            while (i <= 999)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

        }

        public static void Comparison()
        {
            bool condition = true;

            while (condition)
            {
                Console.WriteLine("What is your first number?");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("What is your second number?");
                int secondNumber = int.Parse(Console.ReadLine());

                if (firstNumber == secondNumber)
                {
                    Console.WriteLine("The two numbers are equivalent to each other!");
                    condition = false;
                }
                else
                {
                    Console.WriteLine("The two numbers are not equivalent, please try again.");
                    Console.WriteLine();
                    condition = true;
                }

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the lottery! To begin, please type the same two numbers to prove your verification.");
            Comparison();

            Console.WriteLine("Please choose one of the following numbers from the list and type your chosen number.");
            NumberCall();

            var officialAnswer = int.Parse(Console.ReadLine());

            Console.WriteLine("We shall begin the lottery selection phase.");
            
            if (officialAnswer > 0)
            {
                Console.WriteLine("After evaluating your number, it has been determined that your number is positive. Therefore, you will move on to the next stage.");
                Console.WriteLine();
                Console.WriteLine("We will now begin the next phase. Is your number listed here?");
                FunkyCall();
                  
                string answerOne = Console.ReadLine().ToLower();

                if (answerOne == "yes")
                {
                Console.WriteLine("Congratulations! You have passed the third phase.");
                Console.WriteLine();
                Console.WriteLine("Please enter your number.");
                         
                int numberAnswer = int.Parse(Console.ReadLine());

                bool typeCondition = true;
                    while (typeCondition)
                    {
                        if (numberAnswer % 2 == 0)
                        {
                            Console.WriteLine($"The number {numberAnswer} is even. You move onto the final stage!");
                            typeCondition = true;

                            Console.WriteLine();
                            Console.WriteLine("Evaluating..");

                            if (officialAnswer >= 0 && officialAnswer <= 10)
                            {

                                switch (officialAnswer)
                                {
                                    case 0:
                                        {
                                            Console.WriteLine("Unlucky! This is not the right number. Thanks for playing!");
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.WriteLine("Unlucky! This is not the right number. Thanks for playing!");
                                            break;
                                        }
                                    case 4:
                                        {
                                            Console.WriteLine("Unlucky! This is not the right number. Thanks for playing!");
                                            break;
                                        }
                                    case 6:
                                        {
                                            Console.WriteLine("Unlucky! This is not the right number. Thanks for playing!");
                                            break;
                                        }
                                    case 8:
                                        {
                                            Console.WriteLine("Congratulations! This is the right number! You win $1,000,000!");
                                            break;
                                        }
                                    case 10:
                                        {
                                            Console.WriteLine("Unlucky! This is not the right number. Thanks for playing!");
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("There has been an error.");
                                            break;
                                        }
                                }
                                   
                            }
                            else
                            {
                                Console.WriteLine("Unfortunate! You barely missed out. Your number is not the winning number.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"The number {numberAnswer} is odd. I am sorry, you do not pass.");
                            typeCondition = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Unfortunately, your number is not the winning number. Thanks for playing!");
                }
                       
            }
            else
            {
                Console.WriteLine("After evaluating your number, it has been determined that your number is negative. Therefore, you will not move on.");
            }
            
        }
    }
}

