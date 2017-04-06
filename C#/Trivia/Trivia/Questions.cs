using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public class Questions
    {

        private readonly Dictionary<int, string> _categories = new Dictionary<int, string>() { { 0, "Pop" }, { 1, "Science" }, { 2, "Sports" }, { 3, "Rock" } };
        public LinkedList<string> popQuestions = new LinkedList<string>();
        public LinkedList<string> scienceQuestions = new LinkedList<string>();
        public LinkedList<string> sportsQuestions = new LinkedList<string>();
        public LinkedList<string> rockQuestions = new LinkedList<string>();

        public string CreateRockQuestion(int index)
        {
            return "Rock Question " + index;
        }

        public void AskQuestion(int currentPlayerPlace)
        {
            Console.WriteLine("The category is " + CurrentCategory(currentPlayerPlace));
            if (CurrentCategory(currentPlayerPlace) == "Pop")
            {
                Console.WriteLine(popQuestions.First());
                popQuestions.RemoveFirst();
            }
            if (CurrentCategory(currentPlayerPlace) == "Science")
            {
                Console.WriteLine(scienceQuestions.First());
                scienceQuestions.RemoveFirst();
            }
            if (CurrentCategory(currentPlayerPlace) == "Sports")
            {
                Console.WriteLine(sportsQuestions.First());
                sportsQuestions.RemoveFirst();
            }
            if (CurrentCategory(currentPlayerPlace) == "Rock")
            {
                Console.WriteLine(rockQuestions.First());
                rockQuestions.RemoveFirst();
            }
        }
        private string CurrentCategory(int currentPlayerPlace)
        {
            return _categories[currentPlayerPlace % 4];
        }
        public void GenerateQuestions()
        {
            for (var i = 0; i < 50; i++)
            {
                popQuestions.AddLast("Pop Question " + i);
                scienceQuestions.AddLast(("Science Question " + i));
                sportsQuestions.AddLast(("Sports Question " + i));
                rockQuestions.AddLast(CreateRockQuestion(i));
            }
        }
    }
}
