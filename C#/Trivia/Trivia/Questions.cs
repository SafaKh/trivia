using System;
using System.Collections.Generic;

namespace Trivia
{
    public class Questions
    {

        private readonly Dictionary<int, QuestionStack> _categories = new Dictionary<int, QuestionStack>() { { 0, new QuestionStack("Pop") }, { 1, new QuestionStack("Science") }, 
        { 2, new QuestionStack("Sports") }, { 3, new QuestionStack("Rock")} };

        
        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + _categories[currentPlayerPlace % (_categories.Count)].Category);
            
           _categories[currentPlayerPlace % (_categories.Count)].PickAQuestionAndAsk();
           
        }

        public void GenerateQuestions()
        {
            for (var i = 0; i < 50; i++)
            {
                foreach (KeyValuePair<int, QuestionStack> variable in _categories)
                {
                    variable.Value.Add(i);
                }

            }
        }
    }
}
