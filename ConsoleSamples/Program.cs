using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NotHesaplamasi


            //int not;
            //Console.Write("Notunuzu Giriniz : ");
            //not = Convert.ToInt32(Console.ReadLine());

            //if (not < 0 || not > 100)
            //    Console.WriteLine("Yanlış Bir Not Girdiniz");
            //else if (not >= 90)
            //    Console.WriteLine("AA");
            //else if (not >= 80)
            //    Console.WriteLine("BB");
            //else if (not >= 70)
            //    Console.WriteLine("CC");
            //else if (not >= 60)
            //    Console.WriteLine("DD");
            //else
            //    Console.WriteLine("Kaldınız");
            //Console.ReadKey();
            #endregion
            #region ToplamaCikarma
            //int sayi1, sayi2;
            //string islem;
            //Console.Write("Birinci Sayıyı Giriniz : ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci Sayıyı Giriniz : ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nToplama ---> t");
            //Console.WriteLine("\nÇıkarma ---> c");
            //Console.WriteLine("\nÇarpma  ---> m");
            //Console.WriteLine("\nbölme   ---> b");

            //Console.Write("Bir İşlem Seçiniz :");
            //islem = Console.ReadLine();

            //if (islem == "b")
            //    if (sayi2 != 0)
            //    {
            //        float sonuc = (float)sayi1 / (float)sayi2;
            //        Console.WriteLine("sonuç : {0}", sonuc);
            //    }
            //    else
            //        Console.WriteLine("Bölen 0 olamaz!");
            //else if (islem == "t")
            //    Console.WriteLine("Sonuç : {0}", sayi1 + sayi2);
            //else if (islem == "c")
            //    Console.WriteLine("Sonuç : {0}", sayi1 - sayi2);
            //else
            //    Console.WriteLine("Sonuç : {0}", sayi1 * sayi2);
            //Console.ReadKey();
            #endregion
            #region ToplamaCikarma(switchCase)
            
            //int sayi1, sayi2;
            //string islem;

            //Console.Write("birinci Sayıyı Giriniz : ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci Sayıyı Giriniz : ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("\nToplama ---> t");
            //Console.WriteLine("\nÇıkarma ---> c");
            //Console.WriteLine("\nÇarpma  ---> m");
            //Console.WriteLine("\nbölme   ---> b");

            //Console.Write("Bir İşlem Seçiniz : ");
            //islem = Console.ReadLine();

            //switch (islem)
            //{
            //    case "t":
            //        Console.WriteLine("Sonuç : {0}", sayi1 + sayi2);
            //        break;
            //    case "c":
            //        Console.WriteLine("sonuç : {0}", sayi1 - sayi2);
            //        break;
            //    case "m":
            //        Console.WriteLine("Sonuç : {0}", sayi1 * sayi2);
            //        break;
            //    case "b":
            //        switch (sayi2)
            //        {
            //            case 0:
            //                Console.WriteLine("Bölüm 0 Olamaz!");
            //                break;
            //            default:
            //                float sonuc = (float)sayi1 / (float)sayi2;
            //                break;

            //        }
            //        break;
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
