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

            string[] textFileLines = File.ReadAllLines(@"C:\Users\Trudy\Documents\QnA.txt");
            List<GameCard> GameCards = new List<GameCard>();
            int numberOfGameCardsInTextFile = textFileLines.Length / 6;

            for (int i = 0; i < numberOfGameCardsInTextFile; i++)
            {
                int firstLineNumber = i * 6;
                GameCard A = new GameCard();
                A.GameQuestion = textFileLines[firstLineNumber];
                A.AnswerOptions.Add(textFileLines[firstLineNumber + 1]);
                A.AnswerOptions.Add(textFileLines[firstLineNumber + 2]);
                A.AnswerOptions.Add(textFileLines[firstLineNumber + 3]);
                A.AnswerOptions.Add(textFileLines[firstLineNumber + 4]);
                A.CorrectAnswerNumber = int.Parse(textFileLines[firstLineNumber + 5]);

                GameCards.Add(A);
            }

            int points = -1;
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
