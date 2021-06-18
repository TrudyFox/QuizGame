using System;
using System.Collections.Generic;
using System.IO;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.ReadAllLines() <- google that yo
            //read a file 
            //put the informations that are in there into gamecard objects
           
            string[] readText = File.ReadAllLines(@"C:\Users\Trudy\Documents\QnA.txt");
            //foreach (string docLine in readText)
            
               // GameCard {docLine}
            List<GameCard> GameCards = new List<GameCard>();
            GameCard A = new GameCard();
            A.GameQuestion = readText[0];
            A.AnswerOptions.Add(readText[1]);
            A.AnswerOptions.Add(readText[2]);
            A.AnswerOptions.Add(readText[3]);

            GameCard B = new GameCard();


            int points = -1;
         
            A.CorrectAnswerNumber = 1;

            B.GameQuestion = "how many hats does Oprah own?";
            B.AnswerOptions.Add("eight");  // 0
            B.AnswerOptions.Add("one");    // 1
            B.AnswerOptions.Add("twenty"); // 2
            B.CorrectAnswerNumber = 0;

            GameCards.Add(A);
            GameCards.Add(B);

            foreach (GameCard gc in GameCards)
            {
                //print the question
                Console.WriteLine(gc.GameQuestion);
                Console.WriteLine("please enter the number of the answer you deem correct");

                // print all the answers and the coresponding numbers
                int number = 1;

                foreach (String Answer in gc.AnswerOptions)
                {
                    Console.WriteLine($"({number}) {Answer}");
                    number++;
                }
                //get user guess / input
                string userinput = Console.ReadLine();

                //example : user inputs 1
                // you want to subtract 1 from whatever the user entered
                int userInputInt = int.Parse(userinput) - 1;

                //check if its the right guess
                if (userInputInt == gc.CorrectAnswerNumber)
                {
                    points++;
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("nay");
                }

                Console.WriteLine($"Your Score is {points} Points");


            }
        }
    }
}
