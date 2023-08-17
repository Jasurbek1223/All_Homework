namespace N26___T1;
class Meeting
{
    public string Name { get; set; }
    public TimeSpan Duration { get; set; }

    public Meeting(string name, TimeSpan time)
    {
        Name = name;
        Duration = time;

    }

    public static TimeSpan operator +(TimeSpan timeSpan, Meeting meeting )
    {
        return timeSpan + meeting.Duration;
    }



}
