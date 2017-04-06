using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Questions
    {
        public LinkedList<string> popQuestions = new LinkedList<string>();
        public LinkedList<string> scienceQuestions = new LinkedList<string>();
        public LinkedList<string> sportsQuestions = new LinkedList<string>();
        public LinkedList<string> rockQuestions = new LinkedList<string>();

        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }

        public  void AskQuestion(string currentCategory)
        {
            if (currentCategory == "Pop")
            {
                Console.WriteLine(popQuestions.First());
                popQuestions.RemoveFirst();
            }
            if (currentCategory == "Science")
            {
                Console.WriteLine(scienceQuestions.First());
                scienceQuestions.RemoveFirst();
            }
            if (currentCategory == "Sports")
            {
                Console.WriteLine(sportsQuestions.First());
                sportsQuestions.RemoveFirst();
            }
            if (currentCategory == "Rock")
            {
                Console.WriteLine(rockQuestions.First());
                rockQuestions.RemoveFirst();
            }
        }
    }
}
