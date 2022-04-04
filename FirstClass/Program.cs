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
        // Los metodos de la clase se indican antes del metodo main()
        // En este caso retorna un valor tipo int
        public int launchIntegerMultiplication(int a, int b){
            int multiplication = a * b;
            return multiplication;
        }
        static void Main(string[] args)
        {
            /* Se pueden invocar los metodos dentro de la misma clase
             * instanciado el propio objeto
             */
            Program objectProgram = new Program();
            int resultadoMultiplicacion = objectProgram.launchIntegerMultiplication(7,8);

            /* Un metodo estatico pertenece a la clase, no al objeto
                accediendo directamente con el nombre de la clase
                sin necesidad de crear un objeto
            */
            FigureArea.calculateRectangleArea();
            LogicalOperators.example();
            LogicalOperators.operadorRelacional();
            EjemploMethods.muestraEjemplo();
            EjemploMethods.metodosStrings();

            /* Para llamar a los metodos es necesario crear una referencia creando una instancia
            */
            ArrayExample myTestArrayObject = new ArrayExample();
            myTestArrayObject.cafeArray();

            ListExample listExample = new ListExample();
            listExample.listTacos();

            CapturaDatos capturaDatos = new CapturaDatos();
            capturaDatos.muestraPersonales();



        }
    }
}
