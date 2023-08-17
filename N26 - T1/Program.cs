namespace N26___T1;

internal class Program
{
    static void Main(string[] args)
    {
        List<Meeting> meetingList = new List<Meeting>();

        Meeting meeting1 = new Meeting("Dars", new TimeSpan(2,30,0));
        Meeting meeting2 = new Meeting("Dars", new TimeSpan(3, 20, 0));
        Meeting meeting3 = new Meeting("Dars", new TimeSpan(5, 15, 0));
        Meeting meeting4 = new Meeting("Dars", new TimeSpan(4, 45, 0));
        Meeting meeting5 = new Meeting("Dars", new TimeSpan(1, 40, 0));
        

        meetingList.Add(meeting1);
        meetingList.Add(meeting2);
        meetingList.Add(meeting3);
        meetingList.Add(meeting4);
        meetingList.Add(meeting5);

        var sum = new TimeSpan();

        foreach (Meeting meeting in meetingList)
        {
            sum += meeting;
        }

        Console.WriteLine($"Jami davom etgan vaqt: {sum}");

    }
}
