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

            Console.WriteLine("Tre result of the logical NOT valueOne is: " + (!valueOne));
        }
    }
}
