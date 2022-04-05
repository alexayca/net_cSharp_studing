﻿using System;

namespace EstructurasControl
{
    class Program
    {
/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
        static void condicionalIF() {
            int anyValue = 7;
            string message = "";

            Console.WriteLine("The answer is: ");

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

/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
        static void condicionalSwitch() {
            Console.WriteLine("Enter the selected soda: ");
            string caseSwitch = Console.ReadLine();

            switch (caseSwitch)
            {
                case "cola":
                    Console.WriteLine("Cola soda - $2 USD");
                    break;
                case "lime":
                    Console.WriteLine("Lime soda - $1 USD");
                    break;
                case "orange":
                    Console.WriteLine("Orange soda - $1.5 USD");
                    break;
                case "apple":
                    Console.WriteLine("Apple soda - $1 USD");
                    break;
                default:
                    Console.WriteLine("ERROR: You did not select a soda or you entered an incorrect value.");
                    break;
            }
        }

/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
        static void Main(string[] args)
        {
            
            //Program.condicionalIF();
            condicionalSwitch();
        }
    }
}
