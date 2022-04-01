// https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/operators/

using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class FigureArea
    {
        static void calculateRectangleArea()
        {
            float sideA = 10.1f;
            float sideB = 20;

            float rectangleArea = sideA * sideB;
            Console.WriteLine("Tha rectangle area is: " +rectangleArea);
        }
    }
}
