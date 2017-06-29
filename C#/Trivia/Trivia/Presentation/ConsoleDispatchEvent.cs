using System;
using Trivia.Domain;

namespace Trivia.Presentation
{
    public class ConsoleDispatchEvent : IDispatchEvent
    {
        public void Display(string display)
        {
            Console.WriteLine(display);
        }

        public void Dispatch<TEvent>(TEvent @event)
        {

            if (@event.GetType() ==typeof(PlayerRolledDice))
            {
                var playerRolledDice = @event as PlayerRolledDice;
                Console.WriteLine(playerRolledDice.CurrentName + " is the current player");
                Console.WriteLine("They have rolled a " + playerRolledDice.Roll);
            }
            else if (@event is GetOutOfPenaltyBox)
            {
                var getOutOfPenaltyBox = @event as GetOutOfPenaltyBox;
                Console.WriteLine(getOutOfPenaltyBox.CurrentName + " is getting out of the penalty box");
            }
            else if (@event is PlayerNewLocation)
            {
                var playerNewLocation = @event as PlayerNewLocation;
                Console.WriteLine(playerNewLocation.CurrentName
                 + "'s new location is "
                 + playerNewLocation.CurrentPlace);
            }
            else if (@event is GetInOfPenaltyBox)
            {
                var getInOfPenaltyBox = @event as GetInOfPenaltyBox;
                Console.WriteLine(getInOfPenaltyBox.CurrentName + " is not getting out of the penalty box");
            }
            else if (@event is AnswerCorrect)
            {
                Console.WriteLine("Answer was correct!!!!");
            }
            else if (@event is AnswerNotCorrect)
            {
                var answerNotCorrect = @event as AnswerNotCorrect;
                Console.WriteLine("Question was incorrectly answered");
                Console.WriteLine(answerNotCorrect.CurrentName + answerNotCorrect.WasSentToThePenaltyBox);
            }
        }
    }
}