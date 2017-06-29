namespace Trivia.Domain
{
    public class AnswerNotCorrect
    {
        public AnswerNotCorrect(string currentName, string wasSentToThePenaltyBox)
        {
            CurrentName = currentName;
            WasSentToThePenaltyBox = wasSentToThePenaltyBox; 
        }

        public string WasSentToThePenaltyBox { get; set; }

        public string CurrentName { get; set; }
    }
}