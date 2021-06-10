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
            A.AnswerOptions.Add("Winfrey");
            A.AnswerOptions.Add("Fox");
            A.GameAnswer = ("Winfrey");

            B.GameQuestion = "how many hats does Oprah own?";
            B.AnswerOptions.Add("eight");
            B.AnswerOptions.Add("one");
            B.AnswerOptions.Add("twenty");
            B.GameAnswer = ("one");

              for(int i = 0; i < 3; i++)


            foreach (GameCard Card in GameCards)
            {
                Console.WriteLine(Card.GameQuestion);
                Console.WriteLine(Card.AnswerOptions);

            }

        }
    }
}
