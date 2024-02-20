using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t1 = new Telefono("i2", "iphone" );
            t1.CodigoOperador = 12;
            t1.NumeroTelefonico = "698981284";
            
            Console.WriteLine(t1.NumeroTelefonico + t1.CodigoOperador + t1.Llamar("Tato"));
            Console.ReadKey();
            
        }
    }
}
