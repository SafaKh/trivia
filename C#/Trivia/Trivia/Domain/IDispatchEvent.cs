namespace Trivia.Domain
{
    public interface IDispatchEvent
    {
        void Display(string diplay);
        void Dispatch<TEvent>(TEvent @event);
    }
}