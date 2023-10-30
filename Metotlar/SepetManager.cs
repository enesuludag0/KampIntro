using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager //Manager,Service,Dal,DataAccess,Controller adlı classlarda operasyonlar yani metotlar tutulur
    {
        public void Ekle(Urun urun) //Ne ekliyorsun veya Neye ihtiyacın var = Urun
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        // Alternatif ama Kullanılmaz
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
