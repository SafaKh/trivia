using System.Collections.Generic;

namespace Trivia.Domain
{
    public interface IQuestionsRepository
    {
        LinkedList<string> GetQuestions(string category); 
    }
}
