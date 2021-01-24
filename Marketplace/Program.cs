using System;

namespace Marketplace
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "HP Laptop";
            urun1.Fiyati = 5000;
            urun1.Aciklama = "i5 9.Nesil 240GB SSD 15.6 inç ";

            Urun urun2 = new Urun();
            urun2.Adi = "Asus Laptop";
            urun2.Fiyati = 9000;
            urun2.Aciklama = "i7 9.Nesil 240GB SSD 15.6 inç ";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı :" + urun.Adi);
                Console.WriteLine("Ürün Fiyatı :" + urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması :" + urun.Aciklama);
            }

            Console.WriteLine("------------------Foreach Bitti---------------");


            Urun[] var = new Urun[] { urun1, urun2, };

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün Adı" +  " : " + urunler[i].Adi );
                Console.WriteLine("Ürün Açıklaması" + " : " + urunler[i].Aciklama);
                Console.WriteLine("Ürün Fiyatı " + " : " + urunler[i].Fiyati);

            }

            Console.WriteLine("------------------For Bitti---------------");


            int j = 0;
            while (j<urunler.Length)

            {
                Console.WriteLine("Ürün Adı" + " : " + urunler[j].Adi);
                Console.WriteLine("Ürün Açıklaması" + " : " + urunler[j].Aciklama);
                Console.WriteLine("Ürün Fiyatı " + " : " + urunler[j].Fiyati);
                j++;
            }


            Console.WriteLine("------------------While Bitti---------------");

        }
    }
}
