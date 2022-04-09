using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        { 
            //while
            // 1 den başlayarak konsoldan girilen sayıya kadar sayı dahil ortalama hesaplayıp konsola yazdıran program
        //     Console.Write("lütfen bir sayı giriniz: ");
        //     int sayi = int.Parse(Console.ReadLine());
        //     int sayac = 1;
        //     int toplam =0;
        //     while(sayac<=sayi)
        //     {
        //         toplam += sayac;
        //         sayac ++;
        //     }
        //     Console.WriteLine("değeriniz: " + toplam/sayi);

        //     //a dan z ye kadar tüm harfleri konsola yazdır.
        
        // char character = 'a';
        // while(character<'z')
        // {

        // Console.Write(character);
        // character ++;
        // }
            //foreach

        string[] arabalar = {"bmw","ford","toyota","nissan"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);

        }

        }
    }
}
