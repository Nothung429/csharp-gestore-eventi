public class ListEvent
{
    public string title { get; set; }

    List<Event> eventList { get; }

    public ListEvent(string title)
    {
        this.title = title;
        eventList = new List<Event>();
    }

    public void AddEvent(Event @event)
    {
        this.eventList.Add(@event);
    }
    public void FilterEvent(DateTime date)
    {
        foreach (Event @event in eventList)
        {
            if (@event.date == date)
            {
                Console.WriteLine(@event.name);
            }
            else
            {
                Console.WriteLine("Nessun evento disponibile");
            }
        }
    }
    public int PrintList()
    {
        return eventList.Count;
    }
    public void ClearEvent()
    {
        eventList.Clear();
    }
}