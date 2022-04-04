// https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/
/*
  Convert VS. Parse 🥊
    Ambas se pueden usar para convertir datos de un tipo a otro.
    Convert pude manejar valores NULL retornando un 0.
    Parse no puede manejar valores NULL y muestra un error (ArgumentNullException).
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class FigureArea
    {
        public static void calculateRectangleArea()
        {
            Console.WriteLine("Please enter the side A of the rectangle, you can use decimals.");
            float sideA = float.Parse(Console.ReadLine());
            float sideB = 20.6f;

            float rectangleArea = sideA * sideB;
            Console.WriteLine("The rectangle area is: " +rectangleArea);


            float number1 = 10.555f;
            float number2 = Convert.ToSingle(null);
            float result = number1 * number2;

            Console.WriteLine($"El resultado es igual a {result}");
        }
    }
}
