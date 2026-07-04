using System.Drawing;
using System.IO.Pipelines;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EjerciciosFicheros
{
    internal class Program
    {

        static void ejercicio4_0()
        {
            Console.WriteLine("Saliendo del programa...");
        }

        static void ejercicio4_1(string[] lines, string[] producto, double[] precio)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                producto[i] = lines[i].Split(';')[0];
                precio[i] = Convert.ToDouble(lines[i].Split(';')[1]);
                Console.WriteLine($"Producto: {producto[i]}, Precio: {precio[i]:f2}");
            }
        }

        static void ejercicio4_2()
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("ejercicio4.txt", true);
            Console.WriteLine("Nombre del producto: ");
            string productoAnadir = Console.ReadLine()!;
            Console.WriteLine("Precio del producto: ");
            double precioAnadir = Convert.ToDouble(Console.ReadLine());
            writer.WriteLine($"{productoAnadir};{precioAnadir}");
            writer.Close();
        }

        static void ejercicio5()
        {
            string[] palabras = System.IO.File.ReadAllLines("ejercicio5.txt");
            int intentos = 3;
            int aleatorio = new Random().Next(0, palabras.Length);
            Console.WriteLine("Adivina la palabra elegida al azar. Tienes 3 intentos.");
            for (int i = 0; i < intentos; i++)
            {
                if (palabras[aleatorio] == Console.ReadLine()!)
                {
                    Console.WriteLine("Enhorabuena!");
                    return;
                }
                else
                {
                    Console.WriteLine($"Incorrecto. Te quedan {intentos - i - 1} intentos.");
                }
            }
            Console.WriteLine("La palabra escogida era: " + palabras[aleatorio]);
        }

        static void ejercicio6()
        {
            string[] palabras = System.IO.File.ReadAllLines("ejercicio5.txt");
            int intentos = 7;
            int aleatorio = new Random().Next(0, palabras.Length);
            string palabraElegida = palabras[aleatorio];
            char[] palabraAst = new string('*', palabras[aleatorio].Length).ToCharArray();
            Console.WriteLine($"Adivina la palabra elegida al azar. Tienes {intentos} intentos.");
            Console.WriteLine($"{new string(palabraAst)}");
            while (intentos > 0)
            {
                bool acierto = false;
                Console.WriteLine($"Dime una letra: ");
                char letra = Convert.ToChar(Console.ReadLine()!);
                for (int j = 0; j < palabraElegida.Length; j++)
                {
                    if (palabraElegida[j] == char.ToLower(letra) || palabraElegida[j] == char.ToUpper(letra))
                    {
                        palabraAst[j] = char.ToLower(letra);
                        acierto = true;
                    }
                }
                Console.WriteLine($"Palabra: {new string(palabraAst)}");
                foreach (char c in palabraAst)
                {
                    if (c == '*')
                        break;
                    else
                    {
                        Console.WriteLine("Enhorabuena!, has acertado");
                        return;
                    }
                }
                if (!acierto)
                {
                    intentos--;
                    Console.WriteLine($"Incorrecto. Te quedan {intentos} intentos.");
                }
                if (intentos == 0) Console.WriteLine($"La palabra era: {palabraElegida}");
            }


        }


        static void ejercicio7()
        {

            string[] palabras = System.IO.File.ReadAllLines("ejercicio5.txt");
            int intentos = 7;
            int aleatorio = new Random().Next(0, palabras.Length);
            string palabraElegida = palabras[aleatorio];
            char[] palabraAst = new string('*', palabras[aleatorio].Length).ToCharArray();

            Console.Clear();
            Console.WriteLine(@"
------
|    
|    
|   
|    
|");
            Console.WriteLine();


            int filaAst = 8;
            int filaInput = 10;

            Console.SetCursorPosition(0, filaAst);
            Console.WriteLine(new string(palabraAst));

            while (intentos > 0)
            {
                Console.SetCursorPosition(0, filaInput);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, filaInput);

                bool acierto = false;
                char letra = Convert.ToChar(Console.ReadLine()!);
                for (int j = 0; j < palabraElegida.Length; j++)
                {
                    if (palabraElegida[j] == char.ToLower(letra) || palabraElegida[j] == char.ToUpper(letra))
                    {
                        palabraAst[j] = char.ToLower(letra);
                        acierto = true;
                    }
                }
                    if (acierto)
                    {
                        Console.SetCursorPosition(0, filaAst);
                        Console.WriteLine(new string(palabraAst));

                        if (!new string(palabraAst).Contains('*'))
                        {
                            Console.SetCursorPosition(0, filaInput + 2);
                            Console.WriteLine("¡Enhorabuena!, has acertado la palabra.");
                            return;
                        }
                    }
                    else
                    {
                        intentos--;
                        switch (intentos)
                        {
                            case 6:
                                Console.SetCursorPosition(6, 2);
                                Console.WriteLine("|");
                                break;
                            case 5:
                                Console.SetCursorPosition(6, 3);
                                Console.WriteLine("0");
                                break;
                            case 4:
                                Console.SetCursorPosition(6, 4);
                                Console.WriteLine("|");
                                break;
                            case 3:
                                Console.SetCursorPosition(7, 4);
                                Console.WriteLine("\\");
                                break;
                            case 2:
                                Console.SetCursorPosition(5, 4);
                                Console.WriteLine("/");
                                break;
                            case 1:
                                Console.SetCursorPosition(7, 5);
                                Console.WriteLine("\\");
                                break;
                            case 0:
                                Console.SetCursorPosition(5, 5);
                                Console.WriteLine("/");
                                Console.SetCursorPosition(0, filaInput + 2);
                                Console.WriteLine($"¡Perdiste! La palabra era: {palabraElegida}");
                                break;
                        }
                    }
                
            }
        }









            static void Main(string[] args)
            {
                //    int opcion = 0;
                //    do
                //    {
                //        Console.WriteLine("1) Mostrar productos\n2) Añadir producto\n0) Salir");
                //        opcion = Convert.ToInt32(Console.ReadLine());
                //        string[] lines = System.IO.File.ReadAllLines("ejercicio4.txt");
                //        string[] producto = new string[lines.Length];
                //        double[] precio = new double[lines.Length];
                //        switch (opcion)
                //        {
                //            case 0:
                //                ejercicio4_0();
                //                break;
                //            case 1:
                //                ejercicio4_1(lines, producto, precio);
                //                break;
                //            case 2:
                //                ejercicio4_2();
                //                break;
                //        }
                //        Console.WriteLine();
                //    } while (opcion != 0);

                //ejercicio5();

                //ejercicio6();

                ejercicio7();
            }
        


    }
}



