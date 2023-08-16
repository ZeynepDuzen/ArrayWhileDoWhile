using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Kullanicidan alinan 5 adet sayiyi bir diziye ekleyin ve hiçbir hazir yapi kullanmadan bu sayilari kucukten buyuge siralayin ***

            int[] sayilar = new int[5];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Lutfen bir sayi girin : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(sayilar);

            for (int j = 0; j < sayilar.Length; j++)
            {
                Console.WriteLine();
                Console.WriteLine("Sayilar dizisinin " + (j+1) + " .elemani : " + sayilar[j]);
            }

            


            Console.Read();
        }
    }
}
