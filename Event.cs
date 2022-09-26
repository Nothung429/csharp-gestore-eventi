public class Event
{
    public string name { get; set; }
    public DateTime date { get; set; }
    public int maxCapacity { get; }
    public int reservedSeat { get; set; }

    public Event(string name, DateTime date, int maxCapacity, int reservedSeat)
    {
        this.name = name;
        this.date = date;
        this.maxCapacity = maxCapacity;
        this.reservedSeat = reservedSeat;
    }

    public void CreateEvent()
    {
        Console.WriteLine("Inserisci il nome dell'evento");
        string name = Console.ReadLine();
        Console.WriteLine("Inserisci la data dell'evento (gg/mm/aaaa)");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il numero massimo di posti dell'evento");
        int maxCapacity = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il numero di prenotazioni iniziali dell'evento");
        int reservedSeat = Convert.ToInt32(Console.ReadLine());
        Event myEvent = new Event(name, date, maxCapacity, reservedSeat);
        Console.WriteLine(myEvent);
    }

    public void CheckName()
    {
        if(string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Aggiungi un name all'evento");
        }
    }

    public DateTime CheckDate()
    {
        DateTime todaydate = DateTime.Now;
        var today = todaydate.Date;
        this.date = this.date.Date;
        if (this.date > today)
        {
            Console.WriteLine("La data é disponibile");
        }
        else
        {
            Console.WriteLine("La data non può precedere quella odierna");
        }
        return date;
    }

    public int CheckCapacity()
    {
        if(maxCapacity < 0)
        {
            Console.WriteLine("Il numero dei posti non può essere negativo");
        }
        return maxCapacity;
    }

    public int CheckFree()
    {
        int freeSeat = 0;
        if (reservedSeat < maxCapacity)
        {
            freeSeat = maxCapacity - reservedSeat;
            return freeSeat;
        } else
        {
            Console.WriteLine("Il numero di posti prenotati non può superare il numero di posti massimo");
        }
        return freeSeat = 0;
    }

    public int addReserved()
    {
        reservedSeat += Convert.ToInt32(Console.ReadLine());
        return reservedSeat;
    }

    public int removeReserved()
    {
        reservedSeat -= Convert.ToInt32(Console.ReadLine());
        return reservedSeat;
    }

    public override string ToString()
    {
        string line = $"\n//~~~~~~~~~~~~~~~~~Evento~~~~~~~~~~~~~~~~~//\n";
        line += $"Titolo Evento: {name} \n";
        line += $"Data: {CheckDate()} \n";
        line += $"Posti Totali: {CheckCapacity()} \n";
        line += $"Posti Prenotati: {reservedSeat} \n";
        line += $"Posti Disponibili: {CheckFree()} \n";
        line += $"//~~~~~~~~~~~~~~~~~#########~~~~~~~~~~~~~~~~~//\n";

        return line;
    }
}