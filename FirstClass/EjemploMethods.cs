using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class EjemploMethods
    {
        static void muestraEjemplo()
        {
            Random rnd = new Random();
            Console.WriteLine($"Random value betwent 1 - 10: ${rnd.Next(1,10)}");
        }


    }
}
