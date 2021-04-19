using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero num = new Numero("-6");
            Numero num2 = new Numero("5");
            string binario = num.BinarioDecimal("10101000");
            Console.WriteLine(binario);
            Console.ReadKey();
        }
    }
}
