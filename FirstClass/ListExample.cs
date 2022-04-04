using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class ListExample
    {
        internal void listTacos() 
        {
            // Definimos la lista
            List<string> tacoShoppingList = new List<string>();

            tacoShoppingList.Add("5 Taco de suadero");
            tacoShoppingList.Add("4 Taco de tripa");
            tacoShoppingList.Add("8 Taco de pastor");
            tacoShoppingList.Add("4 Jarritos");

            tacoShoppingList.Remove("5 Taco de suadero");   // La comparacion de string es caseSensitive
            tacoShoppingList.RemoveAt(1);

            for (int i = 0; i < tacoShoppingList.Count; i++)
            {
                Console.WriteLine(tacoShoppingList[i]);
            }

        }
    }
}
