using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Trivia
{
    internal class QuestionStack
    {
        private readonly string _category;
        public LinkedList<string> Question = new LinkedList<string>();

        public QuestionStack(string category)
        {
            _category = category;
        }

        public void PickAQuestionAndAsk()
        {
            Console.WriteLine(Question.First());
            Question.RemoveFirst();
        }

        public void Add(int index)
        {
            Question.AddLast(_category + " Question " + index);
        }
    }
}