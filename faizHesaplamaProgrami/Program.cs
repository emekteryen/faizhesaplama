using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faizHesaplamaProgrami
{
    class Program
    {
        static void Main(string[] args)
        {

            float anapara, faiz, vade, sonuc;
            Console.WriteLine("Yillik faiz hesaplama programına hoşgeldiniz");

            Console.WriteLine("Anaparayı Gir:");
            anapara = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("faizi gir");
            faiz = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("vadeyi gir");
            vade = Convert.ToSingle(Console.ReadLine());

            sonuc = anapara * (faiz / 100) * vade + anapara;
            Console.WriteLine("sonuc= "+sonuc);
            Console.ReadLine();

            //vize-final hesaplama programı

            /*Console.WriteLine("vize notunuzu giriniz");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("final notunuzu giriniz");
            int final = Convert.ToInt32(Console.ReadLine());

            float a=Convert.ToSingle(vize);
            float b=Convert.ToSingle(final);

            //float sonuc = (1.0f*vize * 4 / 10) + (1.0f*final * 6 / 10);
            float sonuc = ( a * 4 / 10) + (b * 6 / 10);
            Console.WriteLine(sonuc);
            Console.ReadLine();*/




        }
    }
}
