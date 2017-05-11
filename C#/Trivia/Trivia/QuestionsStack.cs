using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionsStack
    {
        private readonly LinkedList<string> _questions;

        public QuestionsStack(string category,IQuestionsRepository questions)
        {
            Category = category;
            _questions = questions.GetQuestions(Category);

        }

        public string Category { get; private set; }

        public void AskQuestionAndDiscard()
        {
            Console.WriteLine(_questions.First());
            _questions.RemoveFirst();
        }
    }
}