using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class Product//ürünü sepete eklicem-ürün bilgisi buradan geliyor
    {

        //property-özellik
        public int Id { get; set; }//ıd bir datayı diğerlerinden ayırt etmek için kullanılır.
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Açiklama { get; set; }//get,set bir operasyon tutuyor demektir.Ortak kodları gidip yine classlara yazarız.Sepeti gösterme ,sepeti listeleme,ürün işlemkeri

        public int StokAdedi { get; set; }
    }
}
