Console.WriteLine("Benvenuto al Gestore eventi di Peppone");

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
        CreateEvent();
        break;
    case 3:

        break;
    case 4:

        break;
}


//Event myEvent = new Event("Libertà di Parola", new DateTime(2022, 7, 26), 150, 0, 0);

//Console.WriteLine(myEvent);
