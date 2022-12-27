using System;

class Program
{
    public static void Main(string[] args)
    {
        Kurs kurs1 = new Kurs();
        kurs1.KursAdi = "C#";
        kurs1.Egitmen = "Engin";
        kurs1.IzlenmeOrani = 68;
        
        
        Kurs kurs2 = new Kurs();
        kurs2.KursAdi = "C#";
        kurs2.Egitmen = "Engin";
        kurs2.IzlenmeOrani = 68;

        Kurs kurs3 = new Kurs();
        kurs3.KursAdi = "C#";
        kurs3.Egitmen = "Engin";
        kurs3.IzlenmeOrani = 68;

        Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

        foreach (var kurs in kurslar)
        {
            Console.WriteLine(kurs.KursAdi + "  :  " + kurs.Egitmen);
        }

        Console.WriteLine(kurs1.KursAdi + "  :  " + kurs1.Egitmen);

        int i = 5;
        string result = (i == 10) ? "i 10'dur" : "i 10 degildir";
        Console.WriteLine(result);


        switch (i)
        {
            case 1:
                Console.WriteLine("1. secenek"); 
                break;
            default:
                Console.WriteLine("2. secenek");
                break;
        }

        int c = 2;
        while (c < 5)
        {
            Console.WriteLine(c);
            c++;
        }

        int d = 3;
        if (d == 3)
        {
            Console.WriteLine("d");
        }
        else
        {
            Console.WriteLine("degil");

        };
        


    }
}

class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}


