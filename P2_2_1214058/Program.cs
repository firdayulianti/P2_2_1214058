using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello!!");
            Console.Write("Silahkan berhitung");

            int gajipokok = int.Parse(Console.ReadLine());
            int tunjangan = (gajipokok * 20) / 100;
            int bonus = (gajipokok * 15) / 100;
            double pph = (gajipokok * 3.5) / 100;
            double totalgaji = (gajipokok + tunjangan + bonus);
            double gajibersih = (gajipokok + tunjangan + bonus) - pph;

            Console.Write("Gaji pokok = " + gajipokok);
            Console.Write("Tunjangan = " + tunjangan);
            Console.Write("Bonus = " + bonus);
            Console.Write(" PPH + = " + pph);
            Console.Write("Total gaji = " + totalgaji);
            Console.Write("Gaji bersih = " + gajibersih);
        }
    }
}
