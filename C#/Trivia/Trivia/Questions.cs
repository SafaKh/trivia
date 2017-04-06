using System;
using System.Collections.Generic;

namespace Trivia
{
    public class Questions
    {

        private readonly Dictionary<int, string> _categories = new Dictionary<int, string>() { { 0, "Pop" }, { 1, "Science" }, { 2, "Sports" }, { 3, "Rock" } };
        QuestionStack popQuestions = new QuestionStack();
        QuestionStack scienceQuestions = new QuestionStack();
        QuestionStack sportsQuestions = new QuestionStack();
        QuestionStack rockQuestions = new QuestionStack();


        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }

        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + CurrentCategory(currentPlayerPlace));
            
           
            if (CurrentCategory(currentPlayerPlace) == "Pop")
            {
                popQuestions.PickAQuestionAndAsk();
            }
            if (CurrentCategory(currentPlayerPlace) == "Science")
            {
                scienceQuestions.PickAQuestionAndAsk();
            }
            if (CurrentCategory(currentPlayerPlace) == "Sports")
            {
               
                sportsQuestions.PickAQuestionAndAsk();
            }
            if (CurrentCategory(currentPlayerPlace) == "Rock")
            {
                rockQuestions.PickAQuestionAndAsk();
            }
        }
        private string CurrentCategory(int currentPlayerPlace)
        {
            return _categories[currentPlayerPlace % 4];
        }
        public void GenerateQuestions()
        {
            for (var i = 0; i < 50; i++)
            {
                popQuestions.Add("Pop",i);
                scienceQuestions.Add("Science", i);
                sportsQuestions.Add("Sports", i);
                rockQuestions.Add("Rock", i);
            }
        }
    }
}
