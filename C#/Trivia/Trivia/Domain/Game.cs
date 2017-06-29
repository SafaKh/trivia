namespace Trivia.Domain
{
    public class Game
    {   
        private readonly Players _players;

        private readonly Questions _questions;
        private readonly IDispatchEvent _eventDispatcher; 
        
        bool _isGettingOutOfPenaltyBox;


        public Game(Players players, Questions questions, IDispatchEvent eventDispatcher)
        {
            _players = players;
            _questions = questions;
            _eventDispatcher = eventDispatcher;
        }

        public void Roll(int roll)
        {
            _eventDispatcher.Dispatch(new PlayerRolledDice(_players.Current.Name, roll));


            if (_players.Current.InPenaltyBox)
            {
                if (roll % 2 != 0)
                {
                    _isGettingOutOfPenaltyBox = true;

                    _eventDispatcher.Dispatch(new GetOutOfPenaltyBox(_players.Current.Name));

                    _players.Current.Move(roll);

                    _eventDispatcher.Dispatch(new PlayerNewLocation(_players.Current.Name, _players.Current.Place));
                    _questions.AskQuestion(_players.Current.Place);
                }
                else
                {
                    _eventDispatcher.Dispatch(new GetInOfPenaltyBox(_players.Current.Name));
                    _isGettingOutOfPenaltyBox = false;
                }

            }
            else
            {
                _players.Current.Move(roll);

                _eventDispatcher.Dispatch(new PlayerNewLocation(_players.Current.Name, _players.Current.Place));
                _questions.AskQuestion(_players.Current.Place);
            }

        }

        public bool WasCorrectlyAnswered()
        {
            bool winner;
            if (_players.Current.InPenaltyBox)
            {
                if (_isGettingOutOfPenaltyBox)
                {
                    _eventDispatcher.Dispatch(new AnswerCorrect());
                    _players.Current.WinAGoldCoin();

                    winner = _players.Current.IsWinner();
                    _players.NextPlayer();

                    return winner;
                }

                _players.NextPlayer();
                return false;
            }

            _eventDispatcher.Dispatch(new AnswerCorrect());
            _players.Current.WinAGoldCoin();

            winner = _players.Current.IsWinner();
            _players.NextPlayer();

            return winner;
        }

        public bool WrongAnswer()
        {
            _eventDispatcher.Dispatch(new AnswerNotCorrect(_players.Current.Name , " was sent to the penalty box"));
            _players.Current.GoToPenaltyBox();

            _players.NextPlayer();
            return false;
        }
    }

}
