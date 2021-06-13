using System;
using System.Collections.Generic;

namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCard> GameCards = new List<GameCard>();
            GameCard A = new GameCard();
            GameCard B = new GameCard();

            A.GameQuestion = "whats Oprahs last name?";
            A.AnswerOptions.Add("Barney");
            A.AnswerOptions.Add("Wnfrey");
            A.AnswerOptions.Add("Fox");
            A.CorrectAnswerNumber = (1);

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

                // print all the answers
                foreach (String Answer in gc.AnswerOptions)
                {
                    Console.WriteLine(Answer);
                }
                //get user guess / input
                string userinput = Console.ReadLine();

                //example : user inputs 1
                // you want to subtract 1 from whatever the user entered

                int userInputInt = int.Parse(userinput) - 1;

                //check if its the right guess

                if (userInputInt == gc.CorrectAnswerNumber)
                {
                    Console.WriteLine("yay");
                }
                else
                {
                    Console.WriteLine("nay");
                }


            }
        }
    }
}
