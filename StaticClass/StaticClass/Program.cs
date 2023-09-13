namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

            Calisan calisan = new Calisan("Onur", "Öner", "İK");
            Console.WriteLine($"Çalışan sayısı: {Calisan.CalisanSayisi}");

            Console.WriteLine(Islemler.Topla(500, 20));
            Console.WriteLine(Islemler.Cikar(500, 20));
        }
    }
}