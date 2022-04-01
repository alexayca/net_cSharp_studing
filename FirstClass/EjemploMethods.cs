using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClass
{
    class EjemploMethods
    {
        static void muestraEjemplo()
        {
            Random rnd = new Random();
            Console.WriteLine($"Random value betwent 1 - 10: ${rnd.Next(1,10)}");
        }

        static void metodosStrings()
        {
            // https://platzi.com/clases/2198-introduccion-csharp/36839-metodos-de-strings/

            string ClassTopic = "Métodos de strings";
            string School = "All internet";
            Console.WriteLine("Estoy aprendiendo de " + ClassTopic + " en " + School + ".");

            /* Clone()
                El método Clone() crea un clon exacto de un string en una variable de tipo objeto.
                Por ello es necesario convertirlo a string utilizando ToString().
            */
            string SchoolClone = School.Clone().ToString();
            Console.WriteLine(SchoolClone);

            /* CompareTo()
                Sirve para comparar el contenido de dos strings. Si son iguales devuelve 0 para true 
                y si son diferentes retorna 1 para false.En este caso como School y SchoolClone 
                son strings idénticos devolverá un 0
            */
            Console.WriteLine(ClassTopic.CompareTo(School));
            Console.WriteLine(School.CompareTo(SchoolClone));

            /* Contains()
                Retorna True si el string contiene los caracteres que se pongan en los argumentos del método.
            */
            Console.WriteLine(School.Contains("inter"));

            /* EndsWith()
                Similar a Contains(), pero para comparar si los caracteres están al final del string.
            */
            Console.WriteLine(School.EndsWith("net"));

            /* StartsWith()
                Funciona de la misma manera que EndsWith(), pero en este caso comprueba 
                si empieza con una serie de caracteres indicados.
            */
            Console.WriteLine(School.StartsWith("All"));

            /* Equals()
                Funciona de forma parecida a CompareTo(), 
                pero para indicar si el contenido de ambos strings retorna True o False.
            */
            Console.WriteLine(School.Equals(SchoolClone));

            /* IndexOf()
                Regresa la posición dentro del string del carácter indicado en el argumento.
            */
            Console.WriteLine(School.IndexOf("a"));

            /* ToLower() y ToUpper()
                Convierten el string en todas letras minúsculas o mayúsculas.
            */
            Console.WriteLine(ClassTopic.ToLower());
            Console.WriteLine(ClassTopic.ToUpper());

            /* Insert()
            Inserta un nuevo string dentro de otro en la posición indicada dentro de los argumentos. 
                En este caso es en 6 que es la posición después de la última letra de “posicion”.
            */
            Console.WriteLine(School.Insert(6, " es aprendizaje online autodidacta"));

            /* LastIndexOf()
                Regresa la posición de la última vez que aparece el carácter.
                En este caso la letra “s” aparece varias veces en el string y así podemos notar 
                cómo devuelve la última posición en la que aparece.
            */
            Console.WriteLine(ClassTopic.LastIndexOf("s"));

            /* Remove()
                Elimina los caracteres del string a partir de la posición 
                que le indiquemos hasta el final.
            */
            Console.WriteLine(ClassTopic.Remove(6));

            /* Replace()
                Reemplaza todos los caracteres por otro indicado.
                En este caso todas las “s” serán cambiadas por “z”.
            */
            Console.WriteLine(ClassTopic.Replace("s", "z"));

            /* Split()
                Este es un caso especial donde creamos un nuevo string 
                donde guardamos el string separado en trozos por la letra indicada 
                en los argumentos del método. Para este caso se separa por la letra “s” 
                en 3 trozos que son los que imprimimos.
            */
            string[] split = ClassTopic.Split(new char[] { 's' });
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            /* Dada una fecha como un string, y tomando en cuenta el símbolo “/”, 
             * se obtienen el día, el mes y el año, de la siguiente forma:
             */

            string fecha = "27/12/2021";
            string[] splitDate = fecha.Split(new char[] { '/' });

            Console.WriteLine($"Día: { splitDate[0]}");
            Console.WriteLine($"Mes: { splitDate[1]}");
            Console.WriteLine($"Año: { splitDate[2]}");

            /* Substring()
                Devuelve un substring o trozo de string de acuerdo a 
                las posiciones indicadas en los argumentos.
            */
            Console.WriteLine(ClassTopic.Substring(2, 10));

            /* ToCharArray()
                Convierte el string en un arreglo de caracteres.
            */
            School.ToCharArray();

            /*
            Trim()
                Elimina espacios al principio y al final de un string.
            */
            string TextWithSpaces = "  hola, había espacios al principio y al final ";
            Console.WriteLine(TextWithSpaces.Trim());

        }
    }
}
