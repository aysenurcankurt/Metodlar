using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //metotlar: tekrar tekrar kullanılabilirliği sağlayan kodları ortaya sunar
            //Dont repeat yourself:Kendini tekrar etme-clean code:temiz kod yazmayı sağlıcak-best practice:doğru,en iyi uygulama trknikleri

            
            //classlar özellik tutar

            //string urunAdi1= "elma";
            //double fiyati1 = 15;
            //string açiklama1 = "amasya elması";

            //string urunAdi2= "elma";
            //double fiyati2= 15;
            //string açiklama2="amasya elması";

            //string[] meyveler = new string[]{ };

            //Product product1 = new Product();//clasın örneği demek, gelen tanımlardan örnek oluşturuyoruz.

            Product product1 = new Product();//manav uygulaması
            product1.Adi = "elma";
            product1.Fiyati = 20;
            product1.Açiklama = "Amasya Elması";

            Product product2 = new Product();//manav uygulaması
            product2.Adi = "kavun";
            product2.Fiyati = 40;
            product2.Açiklama = "Adana Kavunu";

            Product[] products = new Product[] {product1,product2 };

            //type save--tip güvenliği, çalışıcağım veri tipini bileceğim diyor.Var da yazsak olur
            foreach (Product product in products)//tek tek gez ürünlerimi, tek tek ekrana basıyor.
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Açiklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("----------------------------Metodlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);//metodumu çağırmış oldum
            sepetManager.Ekle(product2);
            //metod sayesinde 5 farklı sayfada aynı sonucu aldık.

            //encapsulation denir buna; kapsülleme
            sepetManager.Ekle2("armut", "yeşil", 12,5);//bu kod sepet managere gider ve cw içinde ne varsa onu karşıma getirir.
            sepetManager.Ekle2("karpuz", "koyu yeşil", 40,40);
            sepetManager.Ekle2("kavun", "sarı", 50,50);//bunu kullanırsam farklı bir özellik ekelme gerekirse her yeri değiştirmem lazım. O uüzden pek tercih edilmiyor.Classla yapmak daha sağlıklı.
        }
    }
}
