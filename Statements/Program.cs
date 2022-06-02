using System;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 100");
            var r = new Random();
            var favNumber = r.Next(1, 100);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else 
            {
                Console.WriteLine("You guessed it!!!");
            }





            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch(favSubject.ToLower())
            {
                case "english":
                    Console.WriteLine("Wow!English is not my favorite subject.");
                    break;

                case "math":
                    Console.WriteLine("Math is my favorite subject too!!!");
                    break;
                case "science":
                    Console.WriteLine("I also love science!!!");
                        break;
                case "pe":
                    Console.WriteLine("I love PE too!!");
                    break;
                    
                case "art":
                    Console.WriteLine("That cool, art is my favorite subject too");
                    break;
                default:
                    Console.WriteLine("Idk what sunject that is.");
                    break;
                    

            }

        }
    }
}

