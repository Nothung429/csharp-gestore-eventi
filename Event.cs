using System.IO;

public class Event
{
    public string name { get; set; }
    public DateTime date { get; set; }
    public int maxCapacity { get; set; }
    public int reservedSeat { get; set; }
    public int freeSeat { get; set; }

    public Event(string name, DateTime date, int maxCapacity, int reservedSeat, int freeSeat)
    {
        this.name = name;
        this.date = date;
        this.maxCapacity = maxCapacity;
        this.reservedSeat = reservedSeat;
        this.freeSeat = freeSeat;
    }

    public void CheckName()
    {
        if(string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Aggiungi un name all'evento");
        }
    }

    public void CheckDate()
    {
        DateTime todaydate = DateTime.Now;
        var today = todaydate.Date;
        this.date = this.date.Date;
        if (this.date > today)
        {
            Console.WriteLine("Scegli una data");
        }
        else
        {
            Console.WriteLine("La data non può precedere quella odierna");
        }
    }

    public int CheckCapacity()
    {
        if(maxCapacity > 0)
        {
            return maxCapacity;
        }
        else
        {
            Console.WriteLine("Il numero dei posti non può essere negativo");
            return maxCapacity = 0;
        }
    }

    public int CheckReserved()
    {
        if(maxCapacity <= 150)
        {
            reservedSeat = 32;
            freeSeat = maxCapacity - reservedSeat;
        }
        return freeSeat;
    }

    public override string ToString()
    {
        string line = "\n//~~~~~~~~~~~~~~~~~Evento~~~~~~~~~~~~~~~~~//\n";
        line += "Titolo Evento: " + name + "\n";
        line += "Data: " + date + "\n";
        line += "Posti Totali: " + maxCapacity + "\n";
        line += "Posti Prenotati: " + reservedSeat + "\n";
        line += "Posti Disponibili: " + freeSeat + "\n";
        line += "//~~~~~~~~~~~~~~~~~#########~~~~~~~~~~~~~~~~~//\n";

        return line;
    }
}