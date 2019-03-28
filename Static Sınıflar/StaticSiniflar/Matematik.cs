using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSiniflar
{
    /*
     * Static Sınıflar
     * 
     * Oluşturduğumuz sınıf içerisinde sadece static metotlar ve değişkenler bulunuyorsa
     * sınıfı static olarak tanımlayabiliriz. Sınıfların static olarak tanımlanması zorunlu
     * değildir sadece okunabilirliği arttıran bir yaklaşımdır.
     * 
     * Matematik sınıfının üye elemanları (class member) "Topla ve Carp metotları" static olduğu
     * için sınıfı da static olarak bildirdik.
     * Matematik sınıfının static olduğunu gören programcı, sınıf içersinde sadece static
     * elemanların bulunduğunu anlayacaktır.
     */

    /*
     * Static Sınıflarla alakalı bilinmesi gerekenler
     * 
     * 1-Static sınıflardan nesne oluşturulamaz! (new Matematik; YANLIŞ)
     * 2-Static sınıf türünden referanslar oluşturulamaz! (Matematik m; YANLIŞ)
     * 3-Static sınıfların içinde static olmayan metot ya da değişken tanımlanamaz!
     * 4-Static sınıflarda Kalıtım yoktur!
     */
    static class Matematik //Static belirteci ekledim.
    {
            /*
             * Params Anahtar Sözcüğü
             * 
             * Bazı durumlarda metot yazılırken metodu çağıranın kaç adet parametre geçireceği
             * önceden belli olmayabilir. İşte bu durumda Params anahar kelimesi kullanılır.
             */
        public static double Topla(params double[] Sayilar)
        {
            double Toplam = 0;

            for (int i = 0; i < Sayilar.Length; i++)
            {
                Toplam = Toplam + Sayilar[i];
            }

            return Toplam;
        }
        public static double Carp(params double[] Sayilar)
        {
            double Carpim = 1;

            for (int i = 0; i < Sayilar.Length; i++) 
            {
                Carpim = Carpim * Sayilar[i];
            }

            return Carpim;
        }
    }
}
