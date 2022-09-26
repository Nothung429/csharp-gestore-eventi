Console.WriteLine("Digita 1 per visualizzare la lista degli eventi");
Console.WriteLine("Digita 2 per aggiungere un evento");
Console.WriteLine("Digita 3 per aggiungere prenotazioni all'evento");
Console.WriteLine("Digita 4 per disdire prenotazioni all'evento");

int digit = Convert.ToInt32(Console.ReadLine());

switch (digit)
{
    case 1:

        break;
    case 2:
        Console.WriteLine("Inserisci il nome dell'evento");
        string title = Console.ReadLine();
        Console.WriteLine("Inserisci la data dell'evento (gg/mm/aaaa)");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Inserisci il numero massimo di posti dell'evento");
        int maxSeats = Console.Read();
        Console.WriteLine("Inserisci il numero di prenotazioni iniziali dell'evento");
        int reserveSeats = Console.Read();
        Event myEvent = new Event(title, date, maxSeats, reserveSeats, 0);
        Console.WriteLine(myEvent);
        break;
    case 3:

        break;
    case 4:

        break;
}

Console.WriteLine("Benvenuto al Gestore eventi di Peppone");

//Event myEvent = new Event("Libertà di Parola", new DateTime(2022, 7, 26), 150, 0, 0);

//Console.WriteLine(myEvent);
