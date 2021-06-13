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
            A.GameAnswer = (1);

            B.GameQuestion = "how many hats does Oprah own?";
            B.AnswerOptions.Add("eight");
            B.AnswerOptions.Add("one");
            B.AnswerOptions.Add("twenty");
            B.GameAnswer = (1);

            GameCards.Add(A);
            GameCards.Add(B);

     

            foreach (GameCard gc in GameCards) // i think i need to declar the var in gamecard
            {                             // i tried class, and List, and string though i didnt think it would work
                
                //print the question
                Console.WriteLine(gc.GameQuestion);


                // print all the answers

                //get user guess / input

                //check if its the right guess


            }
        }
    }
}
