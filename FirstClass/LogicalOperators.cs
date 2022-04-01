using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class LogicalOperators
    {
        static void example() 
        {
            bool valueOne = true;
            bool valueTwo = false;

            bool result = valueOne && valueTwo;
            Console.WriteLine("Tre result of the logical AND is: " + result);

            Console.WriteLine("Tre result of the logical OR is: " + (valueOne || valueTwo));

            Console.WriteLine("Tre result of the logical NOTresult is: " + (!result));
        }


        static void operadorRelacional() 
        {
            int valueOne = 3;
            int valueTwo = 18;
            int valueThree = -18;

            Console.WriteLine("The result of (valueOne == valueTwo) is: " + (valueOne == valueTwo));
            Console.WriteLine("The result of (valueOne != valueTwo) is: " + (valueOne != valueTwo) );
            Console.WriteLine("The result of (valueOne > valueTwo) is: " + (valueOne > valueTwo) );
            Console.WriteLine("The result of (valueOne < valueTwo) is: " + (valueOne < valueTwo) );
            Console.WriteLine("The result of (valueOne >= valueTwo) is: " + (valueOne >= valueTwo) );
            Console.WriteLine("The result of (valueOne <= valueTwo) is: " + (valueOne <= valueTwo) );

        }

    }
}
