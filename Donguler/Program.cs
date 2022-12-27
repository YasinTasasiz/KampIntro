using System;

class Program
{
    public static void Main(string[] args)
    {
        string kurs1 = "Kurs1";
        string kurs2 = "Kurs2";
        string kurs3 = "Kurs3";

        //array
        string[] kurslar = new string[] { "Kurs1", "Kurs2", "Kurs3", "Kurs1", "Kurs2", "Kurs3" };

        //for (int i = 0; i <= kurslar.Length; i++)
        //{
        //    Console.WriteLine(kurslar[i]);
        //}

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(kurs);
        }
        
    }
}


