using System;

namespace FirstClass
/* https://platzi.com/blog/namespace-en-c-sharp/
 * Namespace abarca de forma global
 * Contiene las clases
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
            Console.WriteLine("Hello World!");
        }
    }
}
