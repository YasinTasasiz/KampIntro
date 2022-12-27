using System;

class Program
{
    public static void Main(string[] args)
    {
        string kategoryEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOrani = 1.45;
        bool sistemeGirisYapmisMi = true;

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanici ayarlari butonu");
        }
        else
        {
            Console.WriteLine("Giris yap butonu");
        }
        Console.WriteLine(kategoryEtiketi);
    }
}

