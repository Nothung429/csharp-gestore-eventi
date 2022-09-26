public class ListEvent
{
    public string title { get; set; }

    List<Event> eventList { get; }

    public ListEvent(string title)
    {
        this.title = title;
        eventList = new List<Event>();
    }

    public void addEvent(Event @event)
    {
        this.eventList.Add(@event);
    }
}