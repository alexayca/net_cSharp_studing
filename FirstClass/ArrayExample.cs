using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class ArrayExample
    {
        static void cafeArray() 
        {
            /* ejemplo de uso de arrays.
             * Como estructura seria mejor un objeto cafe,
             * y hacer un arreglo de objetos cafe
            */

            // declaracion de variables
            string[] coffeTypes;
            float[] coffePrices;

            // inicializacion
            coffeTypes = new string[] {"Expresso", "Filtrado", "Latte", "Capuchino" };
            coffePrices = new float[] {1.2f, 1.5f, 5.0f, 5.5f };

            coffeTypes[1] = "Lungo";

            for (int i = 0; i < 4; i++)
                Console.WriteLine(coffeTypes[i] + " coffe - $" +coffePrices[i]);

        }
    }

}
