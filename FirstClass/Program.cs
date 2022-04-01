using System;

namespace FirstClass
/* https://platzi.com/blog/namespace-en-c-sharp/
 * Namespace abarca de forma global
 * Contiene las clases
 * El namespace es el entorno de trabajo actual, y siempre se nombra
 * con el nombre del proyecto utilizando PascalCase
 * 
 * Los namespaces són útiles para hacernos escribir menos código, ya que cuando declaramos el:
 *          using system
 * cuando invoquemos la sentencia de imprimir en consola lo podremos hacer de esta manera:
 *          Console.WriteLine("Hola Mundo");
 * En vez de esta:
 *          System.Console.WriteLine("");
 * 
 * 
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? Please write your full name ");
            String fullUserName = Console.ReadLine();
                        
            int height = 175;
            int age = 22;
            
            string placeholderText = "The information you requested is: ";
            string information = placeholderText + "\n User name: " +fullUserName + "\n User age: " +age +"\n User height: " +height ;     // Concatenacion

            Console.WriteLine("Hello " +fullUserName + ", Welcome to course");
            Console.WriteLine(information);

        }
    }
}
