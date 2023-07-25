using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess what my favorite number is!");
            int userGuess = int.Parse(Console.ReadLine());
            int favNumber = 13;
            {
                if (userGuess == favNumber)
                { Console.WriteLine("You guessed it!"); 
                
               }
                else if (userGuess > favNumber)
                    {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("Too low");
                }

                        }
        }
    }
}
