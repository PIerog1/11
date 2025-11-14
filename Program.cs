using System;

public class Produkt
{
    private string nazwa;
    private decimal cena;
    private int iloscNaMagazynie;

    public string Nazwa
    {
        get => nazwa;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Nazwa produktu nie może być pusta ani null.");
            nazwa = value;
        }
    }

    public decimal Cena
    {
        get => cena;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Cena musi być większa niż 0.");
            cena = value;
        }
    }

    public int IloscNaMagazynie
    {
        get => iloscNaMagazynie;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Ilość na magazynie nie może być ujemna.");
            iloscNaMagazynie = value;
        }
    }

    public Produkt(string nazwa, decimal cena, int iloscNaMagazynie)
    {
        Nazwa = nazwa;
        Cena = cena;
        IloscNaMagazynie = iloscNaMagazynie;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"Produkt: {Nazwa}");
        Console.WriteLine($"Cena: {Cena} zł");
        Console.WriteLine($"Ilość na magazynie: {IloscNaMagazynie}");
    }
}

public class Program
{
    public static void Main()
    {
        Produkt produkt = new Produkt("Laptop", 3499.99m, 15);
        produkt.WyswietlInformacje();

        Console.ReadKey(); // żeby okno konsoli się nie zamknęło
    }
}