namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.Pazar);

            int sicaklik = 32;
            if (sicaklik < (int)HavaDurumu.Normal)
                Console.WriteLine("D1Şarıya çıkmak için havanın biraz daha 1s1nmasını bekleyelim.");
            else if (sicaklik >= (int)HavaDurumu.Sicak)
                Console.WriteLine("DıŞarıya çıkmak için çok sıcak bir gün");
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi dışarıya çıkalım!");
        }

        enum Gunler
        {
            Pazartesi = 1,
            Sali,
            Carsamba,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar
        }
        enum HavaDurumu
        {
            Soguk = 5,
            Normal = 20,
            Sicak = 25,
            CokSicak = 30
        }
    }
}