using System;
namespace restaurant10TablesReservationsSystem
{
    class Program {
        static void Main(string[] args) {

            string[] userNames = new string[10] {"Mike", "", "", "", "", "", "", "", "", ""};
            int arrayCurrentIndex = 1;
            bool userType;

            Console.WriteLine("Welcome to the best restaurant in the world!");

            while (arrayCurrentIndex<10) {
                if (arrayCurrentIndex == 10) {
                    Console.WriteLine("The restaurant is full, try again next year");
                    Environment.Exit(0);
                }
                Console.WriteLine("\n\nAre you a register user? write true, or write false");
                userType = Convert.ToBoolean(Console.ReadLine());

                if (userType) {
                    Console.WriteLine("Hello, you are a registered user, please enter your user name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine($"The user you searched is {userToSearch}");
                    // Si regresa -1 no ha encontrado nada
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("User not found, try again or register");
                    }
                    else {
                        Console.WriteLine($"Welcome {userNames[index]}, it's a pleasure to give your food");
                    }
                }
                else if (userType ==false) {
                    Console.WriteLine("Please write and remember your user name.");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your user has been saved successfully\n" +
                        $"Your User Name is {userNames[arrayCurrentIndex]}");
                    arrayCurrentIndex++;
                }
            }
        }
    }
}
