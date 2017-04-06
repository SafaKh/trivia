using System;
using System.Collections.Generic;
using System.Linq;

namespace Trivia
{
    internal class QuestionStack
    {
        public readonly string Category;
        public LinkedList<string> Question = new LinkedList<string>();

        public QuestionStack(string category)
        {
            Category = category;
        }

        public void PickAQuestionAndAsk()
        {
            Console.WriteLine(Question.First());
            Question.RemoveFirst();
        }

        public void Add(int index)
        {
            Question.AddLast(Category + " Question " + index);
        }
    }
}