using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace metotlat_ve_eklemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SaatKac();
            Console.ReadKey();
        }
        public static void SaatKac()                                    // yordam ekliyoruz SaatKac komutunu ekledik ve fonksiyonlandırdık
        {
            Console.WriteLine(DateTime.Now);                            // bilgisayardaki tarih ve saati yazacak 
        }

        public static void metnimiyaz(string mesaj, int adet)
        {
            for (int i = 0; i<adet; i++) ;                              // metnimi yaz fonksiyonu konulduğunda mesajı kaç adet yazılacağını yazar
           Console.WriteLine(mesaj);    
        }

        }
}


class Program
{
    static void Main(string[] args)
    {
    Baslangic:
        Console.WriteLine("Başlayalım mı (E/H)?");
        char cevap = Convert.ToChar(Console.ReadLine());
        switch (cevap)
        {
            case 'E':
                // char tanımlar iken tek tırnak kullanılır
                MetnimiYaz("Özür Dilerim", 100);
                break;
            case 'H':
                Console.WriteLine("Program Sizin İsteğiniz Nedeni İle Sonlandırıldı");
                break;
            default:
                Console.WriteLine("Yanlış Bir Giriş Yaptınız, Programı Tekrar Başlatılıyor, Cevabınızı Girin");
                goto Baslangic;
        }
        Console.ReadKey();
    }

    static void MetnimiYaz(string metin, int adet)                                                                                //yukarıda kullanılmıştır metni 100 kere yazdırma kodu 
    {
        for (int i = 0; i < adet; i++)
        {
            Console.WriteLine(i + 1 + " : " + metin);
        }
    }
}


class Program1
{
    static void Main(string[] args)
    {
        int a = Topla(8, 12);
        Console.WriteLine(a);
        Console.ReadKey();

        sıfredene(5);                                              //yazıp üzerine tıkladığımızda kendisi otomatik metot oluşturdu
    }

    private static void sıfredene(int v)
    {
        throw new NotImplementedException();
    }

    static public int Topla(int v1, int v2)            //içerisine girilen değerleri toplayan bir kod fonksiiyonu tanımladık
    {
        int v = v1+v2;
        return v;
    }
    
}








