internal class Program
{
    private static void Main(string[] args)
    {
       string sayi = "Deneme";
       bool sonuc = int.TryParse(sayi, out int outSayi);
       if (sonuc)
       {
           Console.WriteLine("Başarılı!");
           Console.WriteLine(outSayi);  
    }
         else
         {
              Console.WriteLine("Başarısız!");
         }

         Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplam);
            Console.WriteLine(toplam);
            instance.EkranaYazdir(Convert.ToString(toplam));

            

     }

     class Metotlar
     {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
            Console.WriteLine("Toplam: " + toplam);
        }
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
         
     }
}