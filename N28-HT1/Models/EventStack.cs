using N28_HT1.Interfaces;

namespace N28_HT1.Models;

public class EventStack<T> where T : IEvent
{
    private Stack<T> events = new Stack<T>();

    public void Push(T item)
    {
        if (events.Count > 0 && events.Peek().Date > item.Date)
            throw new InvalidOperationException("Yangi tadbir vaqti bo'yicha oxirida bo'lishi kerak!");

        events.Push(item);
    }

    public T Peek()
    {
        if (events.Count == 0) throw new Exception("Stack is empty");
        return events.Peek();
    }

    public T Pop()
    {
        if (events.Count == 0) throw new Exception("Stack is empty");
        return events.Pop();
    }

}
