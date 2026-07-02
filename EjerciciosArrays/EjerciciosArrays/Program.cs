using System.Collections;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipelines;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjerciciosArrays
{
    internal class Program
    {
        static void Ejercicio1()
        {
            //Crea un array con los nombres de los meses.A continuación pide al usuario un número
            //del 1 al 12.Muéstrale el nombre del mes correspondiente sin usar estructuras
            //condicionales(es decir, a partir de los valores del array).

            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            Console.WriteLine("Dime un número entero del 1 al 12: ");
            int mes = Convert.ToInt32(Console.ReadLine()!);
            Console.WriteLine($"El mes {mes} es {meses[mes - 1]}");

        }

        static void Ejercicio2()
        {
            //Crea un array de enteros con 10 posiciones.A continuación pide al usuario que vaya
            //introduciendo uno a uno los 10 números por consola.Muestra lo siguiente: 
            //a.La lista de números introducidos
            //b.La suma de los números
            //c.La media de los números
            //d.El mayor y el menor de los números(crea un máximo y un mínimo provisional que
            //será igual al primer número del array, después vas comparando con el resto de
            //posiciones).

            int[] enteros = new int[10];
            int suma = 0, mayor = enteros[0], menor = enteros[0];
            double media = 0;

            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine($"Dime el entero de la posición {i}");
                enteros[i] = Convert.ToInt32(Console.ReadLine()!);
            }
            for (int i = 0; i < enteros.Length; i++)
            {
                Console.Write($"{enteros[i]}, ");
                suma += enteros[i];
                if (enteros[i] > mayor) mayor = enteros[i];
                if (enteros[i] < menor) menor = enteros[i];
            }
            Console.WriteLine();
            media = suma / (double)enteros.Length;
            Console.WriteLine($"La suma de los enteros es: {suma}");
            Console.WriteLine($"La media de los enteros es: {media}");
            Console.WriteLine($"El mayor valor es {mayor} y el menor {menor}.");
        }

        static void Ejercicio3()
        {
            //Pide al usuario 10 números con decimales(double).Usa un array para almacenarlos. 
            //Muestra la media y los números que están por encima de esa media.

            double[] decimales = new double[10];
            Console.WriteLine("Dime 10 números decimales: ");
            for (int i = 0; i < decimales.Length; i++)
                decimales[i] = Convert.ToDouble(Console.ReadLine()!);
            Console.WriteLine($"La media es {decimales.Average()}");
            for (int i = 0; i < decimales.Length; i++)
                Console.Write(decimales[i] > decimales.Average() ? $"{decimales[i]} " : "");
            Console.WriteLine("están por encima de la media.");
        }

        static void Ejercicio4()
        {
            //Crea un programa que almacene en una tabla el número de días que tiene cada mes
            //(de un año no bisiesto), pida al usuario que te indique un mes(ej. 2 para febrero) y
            //un día(ej.el día 15).Muéstrale qué número de día es dentro del año(por ejemplo, el
            //15 de febrero sería el día número 46, y el 31 de diciembre sería el día 365). 

            Console.WriteLine("Dime el mes en número: ");
            int numMes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime el dia del mes: ");
            int dia = Convert.ToInt32(Console.ReadLine());
            int diasTotales = 0;
            int[] diaMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < numMes - 1; i++)
                diasTotales += diaMes[i];
            Console.WriteLine($"El día escrito es el {diasTotales + dia} del año.");
        }

        static void Ejercicio5()
        {
            //Crea 2 arrays, uno para almacenar notas de alumnos y otro para almacenar sus
            //nombres.A continuación pregunta al usuario cuántos alumnos hay en total. En
            //función del número de alumnos pide sus nombres y sus notas y guárdalos en los
            //respectivos arrays. 
            //Recorre ambos arrays mostrando el nombre de cada alumno y su nota. 

            double[] notas;
            string[] nombres;
            Console.WriteLine("¿Cuál es el número de alumnos?");
            int numAlumnos = Convert.ToInt32(Console.ReadLine());
            notas = new double[numAlumnos];
            nombres = new string[numAlumnos];
            for (int i = 0; i < numAlumnos; i++)
            {
                Console.WriteLine($"Nombre del alumno {i + 1}: ");
                nombres[i] = Console.ReadLine()!;
                Console.WriteLine($"Nota del alumno {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < numAlumnos; i++)
            {
                Console.WriteLine($"{nombres[i]}: {notas[i]}");
            }


        }

        static void Ejercicio6()
        {
            //Crea un array de números enteros con 10 posiciones.Pregunta al usuario por un
            //número y guarda en el array la tabla de multiplicar de dicho número. A continuación,
            //recorre el array y muestra lo que tienes almacenado. Por ejemplo, si introducimos 6: 

            int[] tabla = new int[10];
            int num = 0;
            bool esNumero = false;
            while (num < 2 || num > 10 || !esNumero)
            {
                Console.WriteLine("Dime un numero entero entre 2 y 10: ");
                string numTexto = Console.ReadLine()!;
                esNumero = int.TryParse(numTexto, out num);
                if (num < 2 || num > 10 || !esNumero)
                    Console.WriteLine("El ancho debe ser mayor que 2");
            }
            for (int i = 0; i < 10; i++)
            {
                tabla[i] = num * (i + 1);
                Console.WriteLine($" {num} x {i + 1} = {tabla[i]}");
            }
        }

        static void Ejercicio7()
        {
            //Crea un programa con 2 arrays que almacenen 10 números cada uno(pon los valores
            //que quieras).Suma las posiciones de ambos arrays(usa un bucle) en un tercer array,
            //y al final muestra los resultados:

            double[] numeros1 = { 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            double[] numeros2 = { 3, 4, 8, 4, 6, 3, 2, 6, 234, 54 };
            double[] suma = new double[10];
            for (int i = 0; i < 10; i++) suma[i] = numeros1[i] + numeros2[i];
            int j = 0;
            foreach (double numero in suma)
            {
                Console.WriteLine($"{numero} = {numeros1[j]} + {numeros2[j]}");
                j++;
            }
            //Console.WriteLine(string.Join(", ", suma));
        }

        static void Ejercicio8()
        {
            //Pide al usuario una contraseña de 8 caracteres.Para leerla, utiliza Console.ReadKey, 
            //por lo que irás leyendo los caracteres uno a uno y guardándolos en un array(no
            //muestres el carácter escrito por la consola).
            //Crea una cadena vacía "" y concatena los caracteres de la contraseña del final al
            //principio(al revés).Finalmente muestra al usuario su contraseña al revés.

            //char[] contrasena = new char[8];
            string contrasena = "";
            Console.WriteLine("Escribe una contraseña de 8 caracteres: ");
            while (contrasena.Length != 8)
            {
                contrasena = Console.ReadLine()!;
                if (contrasena.Length != 8)
                    Console.WriteLine("La contraseña debe tener 8 caracteres: ");
            }
            Console.WriteLine();
            Console.Write("La contraseña invertida es: ");
            for (int i = contrasena.Length - 1; i >= 0; i--)
                Console.Write(contrasena[i]);
            //for(int i=0; i<8; i++)
            //    contrasena[i] = Console.ReadKey(true).KeyChar;
            //Array.Reverse(contrasena);
            //reves = string.Join("", contrasena);
            //Console.WriteLine(reves);
        }

        static void Ejercicio1_1()
        {
            //Crea un array de cadenas con 10 posiciones.Pide al usuario que introduzca 10
            //nombres.Por cada nombre introducido, debes comprobar que no existe ya en el array. 
            //Si existe, no lo guardes y vuelve a pedirle otro nombre. 

            string[] nombres = new string[3];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Introduce un nombre: ");
                string entrada = Console.ReadLine()!;
                while (Array.Exists(nombres, nombre => nombre == entrada))
                {
                    Console.WriteLine("Dime otro nombre que no hayas escrito ya");
                    entrada = Console.ReadLine()!;
                }
                nombres[i] = entrada;

            }
            Console.WriteLine("La lista de nombres es:");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }

        static void Ejercicio1_2()
        {
            //Pide al usuario que escriba un nombre y guárdalo.A continuación, muestra las vocales
            //que contiene ese nombre(debes recorrer la cadena y comparar sus caracteres).

            Console.WriteLine("Escribe un nombre:");
            string nombre = Console.ReadLine()!;
            for (int i = 0; i < nombre.Length; i++)
            {
                char c = nombre[i];
                string vocal = c switch
                {
                    'a' or 'A' => $"En la posición {i} hay una \'a\'",
                    'e' or 'E' => $"En la posición {i} hay una \'e\'",
                    'i' or 'I' => $"En la posición {i} hay una \'i\'",
                    'o' or 'O' => $"En la posición {i} hay una \'o\'",
                    'u' or 'U' => $"En la posición {i} hay una \'u\'",
                    _ => $"En la posición {i} hay una consonante",
                };
                Console.WriteLine(vocal);
            }
        }

        static void Ejercicio1_2b()
        {
            //Pide al usuario que escriba un nombre y guárdalo.A continuación, muestra las vocales
            //que contiene ese nombre(debes recorrer la cadena y comparar sus caracteres).

            Console.WriteLine("Escribe un nombre:");
            string nombre = Console.ReadLine()!;
            int a = 0, e = 0, i = 0, o = 0, u = 0;
            foreach (char c in nombre)
            {
                if (c.ToString().ToUpper() == "A") a++;
                else if (c.ToString().ToUpper() == "E") e++;
                else if (c.ToString().ToUpper() == "I") i++;
                else if (c.ToString().ToUpper() == "O") o++;
                else if (c.ToString().ToUpper() == "U") u++;
                //    if (c == 'a' || c == 'A') a++;
                //    else if (c == 'e' || c == 'E') e++;
                //    else if (c == 'i' || c == 'I') i++;
                //    else if (c == 'o' || c == 'O') o++;
                //    else if (c == 'u' || c == 'U') u++;
            }
            Console.WriteLine($"El nombre escrito tiene {a} \'a\', {e} \'e\', {i} \'i\', {o} \'o\', {u} \'u\', un total de {a + e + i + o + u} vocales.");
        }


        static void Ejercicio1_3(string[] args)
        {

            if (args.Length == 2)
            {
                bool esNumero1 = double.TryParse(args[0], out double n1);
                bool esNumero2 = double.TryParse(args[1], out double n2);
                if (!esNumero1 || !esNumero2) Console.WriteLine("Error: Uno de los parámetros no es un número");
                else
                    Console.WriteLine($"La suma de los dos parámetros es: {n1 + n2}");
            }
            else
                Console.WriteLine("Error: Debes introducir 2 parámetros.");
        }


        static void Ejercicio1_4()
        {
            //Crea un array de cadenas que almacenará nombres de alumnos, y crea otro array de
            //enteros de 2 dimensiones.La primera dimensión indicará el alumno(se corresponderá
            //con la posición del array de nombres) y la segunda sus notas.Crea 4 alumnos con 4
            //notas cada uno.A continuación muestra los nombres de lo alumnos y su nota media.

            double[] media= new double[4];
            string[] alumnos = { "Pedro", "María", "Paco", "Jose" };
            int[,] notas = { {9,5,6,7},{4,5,9,10},{9,1,2,5},{9,5,3,2}};
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for(int j = 0; j < notas.GetLength(1); j++)
                    media[i] += notas[i,j];
                Console.WriteLine($"La media de las notas de {alumnos[i]} es {media[i] / notas.GetLength(1)}");
            }
        }

        static void Ejercicio1_5()
        {
            //Haz lo mismo que en el ejercicio anterior pero pidiendo al usuario por consola cuantos
            //alumnos quiere almacenar. Por cada alumno pide su nombre y 4 notas.Muestra los
            //nombres y sus notas medias.
            Console.WriteLine("Número de alumnos: ");
            int numAlumnos = Convert.ToInt32(Console.ReadLine());
            string[] nombres = new string[numAlumnos];
            double[][] notas = new double[numAlumnos][];
            double[] media = new double[numAlumnos];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nombre del alumno {i + 1}: ");
                nombres[i] = Console.ReadLine()!;
                notas[i] = new double[4];
                for (int j = 0; j < notas[i].Length; j++)
                {
                    Console.WriteLine($"Nota {j + 1} del alumno {i + 1}: ");
                    notas[i][j] = Convert.ToDouble(Console.ReadLine());
                }
                media[i] = notas[i].Average();
            }
            for (int i = 0; i < notas.Length; i++)
                Console.WriteLine($"La media de las notas de {nombres[i]} es {media[i]:F2}");
        }

        static void Ejercicio1_6()
        {
            //Crea un array bidimensional de cadenas. En este array almacenaremos productos con
            //sus respectivos datos.La primera dimensión hará referencia a la posición de cada
            //producto.Y para cada producto(segunda dimensión), almacenaremos lo siguiente
            //(son cadenas todo): Nombre, precio y cantidad(3 campos).
            //Recorre los productos, y muéstralos en formato de tabla, con el nombre, precio,
            //cantidad y precio total.Ten en cuenta que los datos están almacenados como cadenas y
            //deberás convertir el precio a número decimal y la cantidad a número entero.Ejemplo de
            //tabla(formatea con longitud fija para cada campo): 

            Console.WriteLine("Numero de productos: ");
            int numProductos = Convert.ToInt32(Console.ReadLine());
            string[][] producto = new string[numProductos][];
            decimal[] total = new decimal[numProductos];
            for (int i = 0; i < producto.Length; i++)
            {
                producto[i] = new string[3];
                Console.WriteLine($"Nombre del producto {i + 1}: ");
                producto[i][0] = Console.ReadLine()!;
                Console.WriteLine($"Precio del producto {i + 1}: ");
                producto[i][1] = Convert.ToDouble(Console.ReadLine()!).ToString("0,00");
                Console.WriteLine($"Cantidad del producto {i + 1}: ");
                producto[i][2] = Console.ReadLine()!;
                total[i] = Convert.ToDecimal(producto[i][1]) * Convert.ToInt32(producto[i][2]);


            }
            Console.WriteLine("NOMBRE          PRECIO     CANT     TOTAL");
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < numProductos; i++)
            {
                Console.WriteLine(producto[i][0].PadRight(16) + producto[i][1].PadRight(11) + producto[i][2].PadRight(9) + total[i].ToString("0,00"));
            }


        }

        static void EjercicioExtra()
        {
            //Pedir al usuario 2 números enteros. Mostrar por pantalla:
            //-Todos los números que vayan desde el más pequeño al más grande
            //-Cantidad de pares/impares
            //-Positivos/negativos
            //-suma de todos

            Console.WriteLine("Dime el primer número entero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime el segundo número entero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int nmin, nmax;
            int par = 0, impar = 0, positivo = 0, negativo = 0, suma = 0;
            nmin = Math.Min(n1, n2);
            nmax = Math.Max(n1, n2);
            int[] serie = new int[nmax - nmin + 1];
            for (int i = nmin; i <= nmax; i++)
            {
                serie[i - nmin] = i;
                Console.Write(i < nmax ? $"{serie[i - nmin]}," : serie[nmax - nmin]);
                if (serie[i - nmin] % 2 == 0) par++;
                else impar++;
                if (serie[i - nmin] > 0) positivo++;
                else if (serie[i - nmin] < 0) negativo++;
                suma += serie[i - nmin];
            }
            Console.WriteLine();
            Console.WriteLine($"Número de pares: {par}");
            Console.WriteLine($"Número de impares: {impar}");
            Console.WriteLine($"Número de positivos: {positivo}");
            Console.WriteLine($"Número de negativos: {negativo}");
            Console.WriteLine($"{string.Join(" , ", serie)}");
            Console.WriteLine($"La suma de la serie es {suma}");
        }

        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            //Ejercicio8();
            //Ejercicio1_1();
            //Ejercicio1_2();
            //Ejercicio1_2b();
            //Ejercicio1_3(args);
            //Ejercicio1_4();
            Ejercicio1_5();
            //Ejercicio1_6();
            //EjercicioExtra();



        }
    }
}
