using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention//isimlendirme kuralı
        public void Ekle(Product product)//parametre ne eklemem gerektiğini belirtmem gerek. //normal parantez görürsen orada metod çalışıyordur.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!" + " : " + product.Adi);// değiştirmek istediğimde buraya yani sepet manageri yazarsam program csdeki yazı değişiyor
            
         


        }

        public void Ekle2(string productAdi, string açıklama, double fiyat,int StokAdedi)//böylede yazabiliriz,ama yazmamlıyız
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!" + " : " + productAdi);
        }
    }
}







