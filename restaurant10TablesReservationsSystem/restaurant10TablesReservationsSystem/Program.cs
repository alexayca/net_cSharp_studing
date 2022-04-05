using System;
namespace restaurant10TablesReservationsSystem
{
    class Program {
        static void Main(string[] args) {

            string[] userNames = new string[10] {"Mike", "", "", "", "", "", "", "", "", ""};
            int arrayCurrentIndex = 1;
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world!");

            while (true) {
                Console.WriteLine("Are you a register user? write true, or write false");
                userType = Convert.ToBoolean(Console.ReadLine());

                if (userType) { 
                    Console.WriteLine("Hello, you are a registered user, please enter your user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine($"The user you searched is {userToSearch}");
                }
            }
        }
    }
}