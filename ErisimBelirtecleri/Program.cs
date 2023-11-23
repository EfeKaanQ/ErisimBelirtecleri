using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirtecleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();

            ucgen.a = 8;
            ucgen.b = 9;
            ucgen.c = 10;
            int cevre = ucgen.a + ucgen.b + ucgen.c;
            Console.WriteLine("Üçgenimizin a={0},b={1},c={2} la sayılar bunlar la kardeş.",ucgen.a,ucgen.b,ucgen.c);
            Console.WriteLine("ücgenimizin cevresi :{0}", cevre);
        }   
    }
    public class Ucgen
    {
        public int a;
        public int b;
        public int c;
    }
}
