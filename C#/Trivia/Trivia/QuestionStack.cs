using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Trivia
{
    internal class QuestionStack
    {
        public LinkedList<string> Question = new LinkedList<string>();
        public void PickAQuestionAndAsk()
        {
            Console.WriteLine(Question.First());
            Question.RemoveFirst();
        }

        public void Add(string category, int index)
        {
            Question.AddLast(category + " Question " + index);
        }
    }
}