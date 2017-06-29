namespace Trivia.Domain
{
    public class GetInOfPenaltyBox
    {

        public GetInOfPenaltyBox(string currentName)
        {
            CurrentName = currentName; 
        }

        public string CurrentName { get; private set; }
    }
}