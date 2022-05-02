using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 ile 10(dahil) arasındaki sayıların toplamı
            int i;
            int toplam = 0; // toplamada 0 etkisiz eleman
            for (i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("Toplam:"+toplam);
            Console.ReadKey();
        }
    }
}
