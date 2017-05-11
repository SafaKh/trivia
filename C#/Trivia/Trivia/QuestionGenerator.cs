using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class QuestionGenerator : IQuestionsRepository
    {

        public LinkedList<string> GetQuestions(string category)
        {
            LinkedList<string> questionsGenerate = new LinkedList<string>();
            for (var i = 0; i < 50; i++)
            {
                questionsGenerate.AddLast(category + " Question " + i);
            }

            return questionsGenerate;
        }

    }
}
