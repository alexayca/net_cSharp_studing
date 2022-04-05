using System;

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
        static void bucleFor() {
            // un ciclo for puede tener una o mas variables de control
            for (int i = 0, j = 0;      i < 10 && j > -10;      i++, j--)
            {
                Console.WriteLine($"i: {0}  j: {1}" ,i ,j);
            }
        }


/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */
        static void bucleWhile() {
            bool continueSoftwareExecution = true;
            while (continueSoftwareExecution) {
                Console.WriteLine("Do you wish to keep the software running? Write 1 for yes or 0 for No");
                int keepGoing = Convert.ToInt32(Console.ReadLine());
                if (keepGoing == 1)
                {
                    Console.WriteLine("This software will keep running");
                }
                else if(keepGoing ==0){
                    Console.WriteLine("This is the last time the software is running");
                    continueSoftwareExecution = false;
                }
                else {
                    Console.WriteLine("You've enter an invalid input, try again.");
                }
                
            }
        }


/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - */

        static void Main(string[] args)
        {
            
            //Program.condicionalIF();
            //condicionalSwitch();
            //bucleFor();
            bucleWhile();

        }
    }
}
