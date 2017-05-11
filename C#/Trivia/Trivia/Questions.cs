using System;
using System.Collections.Generic;

namespace Trivia
{
    public class Questions
    {

        private readonly List<QuestionStack> _categories = new List<QuestionStack>() { new QuestionStack("Pop"),  new QuestionStack("Science"), 
        new QuestionStack("Sports"), new QuestionStack("Rock") };

        
        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + _categories[currentPlayerPlace % _categories.Count].Category);
            
           _categories[currentPlayerPlace % _categories.Count].PickAQuestionAndAsk();
           
        }

        public void GenerateQuestions()
        {
            foreach (var variable in _categories)
            {
                for (var i = 0; i < 50; i++) 
                {
                    variable.Add(i);
                }

            }
        }
    }
}
