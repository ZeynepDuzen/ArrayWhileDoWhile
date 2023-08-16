using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Kullanicidan alinan 2 adet sayiyi birbiri ile toplayan ve
            //bu sayilari birbirinden cikaran while dongusunu olusturun ***

            Console.WriteLine("birinci sayiyi girin : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ikinci sayiyi girin : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int top = 0;
            int fark = 0;
            
            while ((sayi2 > 0) && (sayi1 > sayi2))
            {
                top += sayi1 + sayi2;
                fark = sayi1 - sayi2;
                break;
            }
            Console.WriteLine("Toplam : " + top);
            Console.WriteLine();
            Console.WriteLine("Fark : " + fark);

            











            Console.Read();
        }
    }
}
