namespace prov1;

public class Bokregister
{
    public string? titel, forfatt;
    public int sidAntal;

    public Bokregister(string? _titel, string? _forfatt, int _sidAntal)
    {
        titel = _titel;
        forfatt = _forfatt;
        sidAntal = _sidAntal;
    }

    public static string FunkBok()
    {
        string? bokAlternativ;
    
        Bokregister minBok = new("Ingen", "Ingen", 0);
    
        WriteLine("Välkommen till bokregistret!");
    
        while (true)
        {
            WriteLine("\n1 för att se den listade boken.");
            WriteLine("2 för att byta den listade boken.");
            WriteLine("3 för att avsluta programmet.");
            Write("\nVälj ett alternativ och tryck 'Enter': ");
    
            bokAlternativ = ReadLine();
    
            switch (bokAlternativ)
            {
                case "1":
                    WriteLine("\nTitel: " + minBok.titel);
                    WriteLine("Författare: " + minBok.forfatt);
                    WriteLine("Antal sidor: " + minBok.sidAntal);
                    WriteLine("\n-----");
                    break;
                case "2":
                    Write("\nVälj en ny titel: ");
                    minBok.titel = ReadLine();
                    Write("Välj en ny författare: ");
                    minBok.forfatt = ReadLine();
                    Write("Välj ett nytt sidantal: ");
                    sidAntalVal:
                    if (int.TryParse(ReadLine(), out int nyttSidAntal))
                    {
                        minBok.sidAntal = nyttSidAntal;
                    }
                    else
                    {
                        Write("\nFelaktigt sidantal. Ange en giltig siffra: ");
                        goto sidAntalVal;
                    }
                    WriteLine("\nNy bok registrerad!");
                    WriteLine("\nTitel: " + minBok.titel);
                    WriteLine("Författare: " + minBok.forfatt);
                    WriteLine("Antal sidor: " + minBok.sidAntal);
                    break;
                case "3":
                    Write("\nAvslutar");
                    for (int i = 0; i < 5; i++)
                    {
                        Write(".");
                        Thread.Sleep(100);
                    }
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("\nOgiltigt alternativ. Försök igen.");
                    break;
            }
        }
    }
}