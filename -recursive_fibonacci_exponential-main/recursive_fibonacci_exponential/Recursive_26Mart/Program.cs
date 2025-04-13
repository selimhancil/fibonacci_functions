using System;

class Program
{
    // Üs alma fonksiyonu
    static int UsAl(int taban, int us)
    {
        if (us == 0)
            return 1;
        return taban * UsAl(taban, us - 1);
    }

    // Faktöriyel fonksiyonu
    static int Faktoriyel(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * Faktoriyel(n - 1);
    }

    // Fibonacci fonksiyonu
    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.WriteLine("1 - Üs Alma");
        Console.WriteLine("2 - Faktöriyel Hesaplama");
        Console.WriteLine("3 - Fibonacci Serisi");
        Console.Write("Bir seçenek girin: ");

        int secim = int.Parse(Console.ReadLine());

        switch (secim)
        {
            case 1:
                Console.Write("Taban değerini girin: ");
                int taban = int.Parse(Console.ReadLine());
                Console.Write("Üs değerini girin: ");
                int us = int.Parse(Console.ReadLine());
                Console.WriteLine($"{taban}^{us} = {UsAl(taban, us)}");
                break;

            case 2:
                Console.Write("Faktöriyel hesaplamak için bir sayı girin: ");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine($"{sayi}! = {Faktoriyel(sayi)}");
                break;

            case 3:
                Console.Write("Kaçıncı Fibonacci sayısını görmek istiyorsunuz? ");
                int fibSayi = int.Parse(Console.ReadLine());
                Console.WriteLine($"Fibonacci({fibSayi}) = {Fibonacci(fibSayi)}");
                break;

            default:
                Console.WriteLine("Geçersiz seçenek!");
                break;
        }

        Console.WriteLine("\nOyunu kapatmak için bir tuşa basın...");
        Console.ReadKey();
    }
}
