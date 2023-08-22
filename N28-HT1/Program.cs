using N28_HT1.Interfaces;
using N28_HT1.Models;

namespace N28_HT1;

class Program
{
    static void Main(string[] args)
    {
        // EventSatack dan foydalanish
        var eventStack = new EventStack<IEvent>();

        // Event yaratish
        var event1 = new Event { Id = 1, Name = "Imtihon", Date = DateTime.Now.AddHours(3) };
        var event2 = new Event { Id = 2, Name = "MasterClass", Date = DateTime.Now.AddHours(8) };

        
        // Eventlarni eventstackga qoshamiz
        eventStack.Push(event1);
        eventStack.Push(event2);

        //var event3 = new Event { Id = 3, Name = "Bayram", Date = DateTime.Now.AddHours(2) };
        //eventStack.Push(event3);


        // oxirgi tadbir
        var lastEvent = eventStack.Peek();
        Console.WriteLine($"Oxirgi Event : {lastEvent.Name}, {lastEvent.Date}"); 

        // Hama tadbirlarni chiqaramiz
        while ( eventStack.Peek != null )
        {
            var upcomingEvent = eventStack.Pop();
            Console.WriteLine($"{upcomingEvent.Id}. {upcomingEvent.Name}, {upcomingEvent.Date}");
        }

    }
}