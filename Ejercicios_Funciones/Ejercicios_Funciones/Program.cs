using System.ComponentModel.Design;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicios_Funciones
{
    
    internal class Program
    {
        static void ejercicio1()
        {
            for (int i = 0; i < 20; i++) Console.Write("*");
        }  

        static void ejercicio2(string texto, int min, int max)
        {
            Console.WriteLine(min <= texto.Length && texto.Length <= max ? $"La cadena de texto tiene una longitud entre {min} y {max}" : "La longitud de la cadena de texto no se encuentra entre los valores indicados.");
        }

        static void ejercicio3(int min=0, int max=20)
        {
            if (min > max) Console.WriteLine("Error: el valor mínimo debe ser mayor que el máximo.");
            else
            {
                for (int i = min; i <= max; i++)
                    Console.Write($"{i}  ");
                Console.WriteLine();
            }
        }

        static void ejercicio4(char c='*', int lado=5)
        {
            for(int i = 1; i <= lado; i++)
            {
                for (int j = 1; j <= lado; j++)
                    Console.Write(i == 1 || i == lado || j == 1 || j == lado ? c : " ");
                Console.WriteLine();
            }
        }

        static void ejercicio5(string nombre, params string[] trabajos)
        {
            if (trabajos.Length != 0) {
                Console.Write($"{nombre} ha trabajado de ");
                for (int i = 0; i < trabajos.Length; i++)
                    Console.Write(i < trabajos.Length - 1 ? $"{trabajos[i]}, " : $"y {trabajos[i]}.");
            }
            else Console.WriteLine($"{nombre} no ha trabajado nunca.");
            Console.WriteLine();
        }

        static bool ejercicio6(int num)
        {
            if (num < 2) return false;
            else if (num == 2) return true;
            else
            {
                for (int i = 3; i <= num; i++)
                    if (num % (i - 1) == 0 || num % 2 ==0) return false;
                return true;

            }
        }

        static double ejercicio7( params double[] numeros)
        {
            return numeros.Average();
        }

        static void ejercicio8(params string[] textos)
        {
           int aleatorio = new Random().Next(0,textos.Length);
            Console.Write("¿Cuál es la palabra elegida al azar?\nPista: las tres primeras letras de la palabra son: ");
            for (int i = 0; i < 3; i++)
                Console.Write(textos[aleatorio][i]);
            Console.WriteLine();
            for (int i=0; i < 3; i++)
            {
                if (textos[aleatorio] == Console.ReadLine())
                {
                    Console.WriteLine("Enhorabuena!");
                    return;
                }
                else Console.WriteLine($"Incorrecto. Intentalo de nuevo.");
            }
            Console.WriteLine($"La palabra escogida era {textos[aleatorio]}");
        }

        static void Main(string[] args)
        {

            //for(int i = 0; i < 3; i++)
            //    ejercicio1();


            //ejercicio2("Pablo", 8, 10);
            //ejercicio2("Pablo", 2, 10);

            //ejercicio3();
            //ejercicio3(3, 9);
            //ejercicio3(3);
            //ejercicio3(max: 9);
            //ejercicio3(7, 3);


            //ejercicio4('&',6);

            //ejercicio5("Pablo", "bombero", "fontanero", "peluquero");
            //ejercicio5("Pablo");

            //bool esPrimo = ejercicio6(10);
            //if(esPrimo) Console.WriteLine("El número es primo.");
            //else Console.WriteLine("El número no es primo.");

            //Console.WriteLine($"La media es: {ejercicio7(5, 6, 7, 3, 9)}");

            ejercicio8("Perro", "Gato", "Ratón", "Pájaro", "Tortuga");
        }
    }
}
