using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class CapturaDatos
    {
        static void muestraPersonales() 
        {
            Console.WriteLine("What's your name? Please write your full name ");
            String fullUserName = Console.ReadLine();

            int height = 175;
            int age = 22;

            string placeholderText = "The information you requested is: ";
            string information = placeholderText + "\n User name: " + fullUserName + "\n User age: " + age + "\n User height: " + height;     // Concatenacion

            Console.WriteLine("Hello " + fullUserName + ", Welcome to course");
            Console.WriteLine(information);
        }

    }
}
