namespace Trivia.Domain
{
    public class PlayerNewLocation
    {
        public PlayerNewLocation(string currentName, int currentPlace)
        {
            CurrentName = currentName;
            CurrentPlace = currentPlace;
        }

        public string CurrentName { get; private set; }

        public int CurrentPlace { get; private set; }
    }
}