using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_6_Prim_Hesapla_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir işyeri çalışanlarına maaşları dışında prim dağıtmaktadır. Prim hesabını aşağıdaki tabloya göre yapıldığı varsayılarak kullanıcıya aldığı maaş ve ürettiği ürün miktarını sorup alacağı toplam ücreti hesaplayan program.   1 – 10 parça        : Parça başı 5 TL 11 – 25 parça     : Parça başı 11 TL 26 – 40 parça     : Parça başı 17 TL 41 ve üzeri          : Parça başı 30 TL  

            int Maas, PA, Prim;


            Console.Write("Maaş Bilginizi Giriniz:");
            Maas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bu Ay ki Parça Adetinizi Giriniz:");
            PA = Convert.ToInt32(Console.ReadLine());

            if (PA>=1 && PA<=10)
            {
                Prim = PA * 5;
                Console.WriteLine("Bu Ayki Prim Hesabınız:Parça Adeti * 5= {0} * 5={1}",PA,Prim);
                Maas = Maas + Prim;
                //Console.WriteLine("Bu Ay ki Maaşınız:"+ Maas);

                Console.WriteLine("Bu Ay ki Maaşınız:{0}",Maas);
            }

            else if (PA>=11 && PA<=25)
            {
                Prim = PA * 11;
                Console.WriteLine("Bu Ayki Prim Hesabınız:Parça Adeti * 11= {0} * 11={1}", PA, Prim);
                Maas = Maas + Prim;
                Console.WriteLine("Bu Ay ki Maaşınız:{0}", Maas);
            }

            else if (PA >= 26 && PA <= 40)
            {
                Prim = PA * 17;
                Console.WriteLine("Bu Ayki Prim Hesabınız:Parça Adeti * 17= {0} * 17={1}", PA, Prim+Maas);
                Maas = Maas + Prim;
                Console.WriteLine("Bu Ay ki Maaşınız:{0}", Maas);
            }

            else if (PA >= 41)
            {
                Prim = PA * 30;
                Console.WriteLine("Bu Ayki Prim Hesabınız:Parça Adeti * 30= {0} * 30={1}", PA, Prim);
                Maas = Maas + Prim;
                Console.WriteLine("Bu Ay ki Maaşınız:{0}", Maas);
            }

            Console.ReadKey();
        }
    }
}
