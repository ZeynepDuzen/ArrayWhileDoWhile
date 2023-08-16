using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Kullanici tarafindan girilen 10 adet sayidan 3 basamakli olanları dowhile ile yazdirin ***

            int[] sayilar = new int[10];

            for (int  i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Lutfen bir sayi girin : ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
                
            int index = 0; 
            do
            {

                if (sayilar[index] >= 100 && sayilar[index] <= 999)
                {
                    Console.WriteLine(sayilar[index]);
                }
                
                index++;


            } while (index < sayilar.Length);
           



            Console.Read();
        }
    }
}
