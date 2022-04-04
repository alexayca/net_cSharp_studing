using System;

namespace EstructurasControl
{
    class Program
    {

        static void condicionalIF() {
            int anyValue = 7;
            string message = "";

            if (anyValue == 7) {
                message = "OMG, it's a miracle any Value is 7";
            }
            else if (anyValue ==14) {
                message = "OMG, it's a double miracle any Value is 7";
            }
            else {
                message = "puff, the value wasn't 7";
            }
            Console.WriteLine($"{message}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("The answer is: ");
            Program.condicionalIF();
        }
    }
}
