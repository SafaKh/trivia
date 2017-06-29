using System;
using System.Collections.Generic;
using Trivia.DataAccess;

namespace Trivia.Domain
{
    public class Questions
    {
        private readonly List<QuestionsStack> _categories = new List<QuestionsStack>();

        public Questions() : this(new [] { "Pop", "Science", "Sports", "Rock" }, new QuestionGenerator())
        {
        }

        public Questions(IEnumerable<string> categories, IQuestionsRepository questions)
        {
            foreach (var category in categories)
            {
                var questionsStack = new QuestionsStack(category, questions);
                _categories.Add(questionsStack);
            }
        }

        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + _categories[currentPlayerPlace % _categories.Count].Category);
            _categories[currentPlayerPlace % _categories.Count].AskQuestionAndDiscard();
        }
    }
}