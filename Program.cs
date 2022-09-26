Console.WriteLine("Benvenuto al Gestore eventi di Peppone");

Console.WriteLine("Digita 1 per visualizzare la lista degli eventi");
Console.WriteLine("Digita 2 per aggiungere un evento");
Console.WriteLine("Digita 3 per aggiungere prenotazioni all'evento");
Console.WriteLine("Digita 4 per disdire prenotazioni all'evento");

Event myEvent = new Event("Libertà di Parola", new DateTime(2023, 7, 26), 150, 45);

Console.WriteLine(myEvent);

int digit = Convert.ToInt32(Console.ReadLine());

switch (digit)
{
    case 1:

        break;

    case 2:
        myEvent.CreateEvent();
        break;

    case 3:
        Console.WriteLine("Vuoi aggiungere dei posti all'evento? \n si/no");
        if (Console.ReadLine() == "si")
        {
            myEvent.addReserved();
            Console.WriteLine(myEvent);
        }
        break;

    case 4:
        Console.WriteLine("Vuoi rimuovere dei posti all'evento? \n si/no");
        if (Console.ReadLine() == "si")
        {
            myEvent.removeReserved();
            Console.WriteLine(myEvent);
        }
        break;
}
