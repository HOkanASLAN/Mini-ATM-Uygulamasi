using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders7_mini_atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıya nasıl bir işlem yapmak istediğini soracağız
            //1- bakiye görüntüleme
            //2- para çekme
            //3- para yatırma
            //q'ya basarsa çıkış yaptıracağız.
            int bakiye = 1000;

            Console.WriteLine("ATM'ye hoşgeldiniz.");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1-Bakiyemi göster");
            Console.WriteLine("2-Para çek");
            Console.WriteLine("3-Para yatır");
            Console.WriteLine("q-Çıkış yap");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki bakiyeniz=" + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz=");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar <= bakiye)
                {
                    Console.WriteLine("Kalan tutar:" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("yavaşşş");
                    Console.ReadLine();

                }
            }
            else if (secim == "3")
            {
                Console.WriteLine("yatırmak istediğiniz tutarı giriniz=");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatirilacak_tutar));
                Console.ReadLine();
            }
            else if (secim == "q")
            {
                Console.WriteLine("ATM'den çıkış yapılıyor");
                Console.WriteLine("Çıkış yapıldı iyi günler");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli değer giriniz.");
                Console.ReadLine();
            }

        }
    }
}
