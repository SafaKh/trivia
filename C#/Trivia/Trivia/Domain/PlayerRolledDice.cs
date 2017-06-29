namespace Trivia.Domain
{
    public class PlayerRolledDice
    {
        public string CurrentName { get; private set; }
        public int Roll { get; private set; }

        public PlayerRolledDice(string currentName, int roll)
        {
            CurrentName = currentName;
            Roll = roll;
            
        }

      
    }
}