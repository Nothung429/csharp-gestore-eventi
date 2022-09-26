Console.WriteLine("Benvenuto al Gestore eventi di Peppone");

Console.WriteLine("Digita 1 per visualizzare la lista degli eventi");
Console.WriteLine("Digita 2 per aggiungere un evento");
Console.WriteLine("Digita 3 per aggiungere prenotazioni all'evento");
Console.WriteLine("Digita 4 per disdire prenotazioni all'evento");

Event myEvent = new Event("Libertà di Parola", new DateTime(2023, 7, 26), 150, 45);

Console.WriteLine(myEvent);

List<Event> myList = new List<Event>();
myList.Add(new Event("Sagra della porchetta", new DateTime(2023, 7, 26), 1000, 65));
myList.Add(new Event("Raduno dei testimoni di Geova", new DateTime(2023, 7, 26), 850, 780));
myList.Add(new Event("Riunione dei liberali di destra", new DateTime(2023, 7, 26), 125, 12));
myList.Add(new Event("Assemblea dei macellai vegani", new DateTime(2023, 7, 26), 475, 325));

int digit = Convert.ToInt32(Console.ReadLine());

switch (digit)
{
    case 1:
        foreach(var item in myList)
        {
            Console.WriteLine("Nome evento: {0}, \nData evento: {1}, \nPosti massimi: {2}, \nPosti prenotati: {3}\n", item.name, item.date, item.maxCapacity, item.reservedSeat);
        }        
        break;

    case 2:
        myEvent.CreateEvent();
        break;

    case 3:
        Console.WriteLine("Vuoi aggiungere dei posti all'evento? \n si/no");
        if (Console.ReadLine() == "si")
        {
            myEvent.AddReserved();
            Console.WriteLine(myEvent);
        }
        break;

    case 4:
        Console.WriteLine("Vuoi rimuovere dei posti all'evento? \n si/no");
        if (Console.ReadLine() == "si")
        {
            myEvent.RemoveReserved();
            Console.WriteLine(myEvent);
        }
        break;
}
