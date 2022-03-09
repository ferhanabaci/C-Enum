using System;

namespace CsharpEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            // enum sıralama anlama gelir
            // ardısık indexlerde calısma sagladıgımız da cok kurtarıcı
            //birden fazla sabiti aynı anda ıhtıyacımız varsa ( yani degeri belli olan) kodun okunurlugunu artırmak icin enum kullanıyoruz 
            // cok fazla kullanılıyor

            //Nasıl Kullanıyorum
            Console.WriteLine(Gunler.Pazar);

            //ekrandan aldıgım bir sıcaklık deger oldugun dusunelim

            int sıcaklık=32;
            if(sıcaklık<=(int)HavaDurumu.Normal){
                Console.WriteLine("Dısarıya cıkmak icin havanın biraz daha ısınımasını bekleyelim");                
            }
            else if(sıcaklık >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Dısarıya cıkmak icin cok sıcak bir gün");

            }
            else if(sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hadi dısarıya cıkalım");
            }
        }
    enum Gunler{
        Pazartesi=1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu{
        Soguk = 5,

        Normal=20,
        Sicak=25,
        CokSicak=30
    }
}
}
