namespace Trivia.Domain
{
    public class GetOutOfPenaltyBox
    {
        public string CurrentName { get; private set;  }

        public GetOutOfPenaltyBox(string currentName)
        {
            CurrentName = currentName; 
        }
    }

}