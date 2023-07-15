using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir,ilce;
            Console.WriteLine("Lütfen sehrinizi giriniz : ");
            sehir = Console.ReadLine();
            Console.WriteLine("Lütfen ilcenizi giriniz : ");
            ilce = Console.ReadLine();
            Console.WriteLine("Girmis oldugunuz sehir ve ilce : " + sehir + "/" + ilce);
            

            Console.Read();
        }
    }
}
