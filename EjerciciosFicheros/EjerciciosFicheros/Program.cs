using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EjerciciosFicheros
{
    internal class Program
    {
        static void ejercicio1()
        {
            string[] lineas = System.IO.File.ReadAllLines("ejercicio1.txt");
            int suma = 0;
            foreach (string linea in lineas)
            {
                suma += Convert.ToInt32(linea);
            }
            Console.WriteLine($"{String.Join(" + ", lineas)} = {suma}");
        }

        static void ejercicio2()
        {
            string entrada = "";
            System.IO.StreamWriter writer = new System.IO.StreamWriter("ejercicio2.txt");
            Console.WriteLine("Dime lineas del .txt, escribe FIN para terminar:");
            while (entrada != "FIN")
            {
                entrada = Console.ReadLine()!;
                if (entrada != "FIN")
                    writer.WriteLine(entrada);
            }
            writer.Close();
        }

        static void ejercicio3()
        {
            string[] alumnos = System.IO.File.ReadAllLines("ejercicio3.txt");
            string[] nombres = new string[alumnos.Length];
            double[] notas = new double[alumnos.Length];

            for (int i = 0; i < alumnos.Length; i++)
            {
                string[] partes = alumnos[i].Split(';');
                nombres[i] = partes[0];
                notas[i] = Convert.ToDouble(partes[1]);
            }
            Console.WriteLine($"La media es {notas.Average()}");
            Console.WriteLine($"La nota más alta es {notas.Max()} de {nombres[Array.IndexOf(notas, notas.Max())]}");
            Console.WriteLine($"La nota más baja es {notas.Min()} de {nombres[Array.IndexOf(notas, notas.Min())]}");
        }

        static void ejercicio41()
        {
            string[] productos = System.IO.File.ReadAllLines("ejercicio4.txt");
            string[] nombre = new string[productos.Length];
            double[] precio = new double[productos.Length];
            for (int i = 0; i < productos.Length; i++)
            {
                string[] partes = productos[i].Split(";");
                nombre[i] = partes[0];
                precio[i] = Convert.ToDouble(partes[1]);
                Console.WriteLine($"{nombre[i],-20}   {precio[i],10:f2}");
            }
        }

        static void ejercicio42()
        {
            Console.WriteLine("Dime el nombre del producto a añadir: ");
            string producto = Console.ReadLine()!;
            Console.WriteLine("Dime el precio del producto a añadir: ");
            double precio = Double.Parse(Console.ReadLine()!);
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("ejercicio4.txt", true))
            {
                writer.WriteLine($"{producto};{precio}");
            }
        }

        static void ejercicio40()
        {
            Console.WriteLine("Saliendo del programa.");
        }

        static void ejercicio5()
        {
            string[] palabras = System.IO.File.ReadAllLines("ejercicio5.txt");
            int intentos = 3;
            int aleatorio = new Random().Next(0, palabras.Length);
            Console.WriteLine("Adivina la palabra elegida: ");
            for(int i = 0; i < intentos; i++)
            {
                if (palabras[aleatorio] == Console.ReadLine())
                {
                    Console.WriteLine("Enhorabuena, has acertado!") ;
                    return;
                }
                else
                    Console.WriteLine($"Incorrecto. Te quedan {intentos-i-1} intentos.");
            }
            Console.WriteLine($"La palabra escogida era {palabras[aleatorio]}");
        }

        static void ejercicio6()
        {
            string[] palabras = System.IO.File.ReadAllLines("ejercicio6.txt");
            int intentos = 7;
            int aleatorio = new Random().Next(0, palabras.Length);
            string palabraAleatoria = palabras[aleatorio];
            char[] palabraAst = new string('*',palabraAleatoria.Length).ToCharArray();
            Console.WriteLine("Adivina la palabra elegida: ");
            Console.WriteLine(new string(palabraAst));
            while (intentos > 0)
            {
                bool acierto = false;
                Console.WriteLine("Dime una letra: ");
                char entrada = Convert.ToChar(Console.ReadLine()!);
                for(int j=0; j < palabraAleatoria.Length; j++)
                {
                    if(palabraAleatoria[j] == char.ToLower(entrada) || palabraAleatoria[j] == char.ToUpper(entrada))
                    {
                        palabraAst[j] = char.ToLower(entrada);
                        acierto = true;
                    }
                }
                Console.WriteLine(new string(palabraAst));
                if (!new string(palabraAst).Contains('*'))
                {
                    Console.WriteLine("Enhorabuena. Has acertado la palabra.");
                    return;
                }
                if (!acierto)
                {
                    intentos--;
                    if (intentos == 0) Console.WriteLine($"La palabra escogida era: {palabraAleatoria}");
                    if (intentos > 0) Console.WriteLine($"Error. Te quedan {intentos} intentos.");
                }
            }
        }

        static void ejercicio7()
        {
            string[] palabras = System.IO.File.ReadAllLines("ejercicio6.txt");
            int intentos = 7;
            char[] utilizadas = new char[34];
            int numUtilizadas = 0;
            int aleatorio = new Random().Next(0, palabras.Length);
            string palabraAleatoria = palabras[aleatorio];
            char[] palabraAst = new string('*', palabraAleatoria.Length).ToCharArray();
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
            int filaEntrada = 10;
            Console.SetCursorPosition(0, filaAst);
            Console.WriteLine(new string(palabraAst));
            Console.SetCursorPosition(12, 1);
            if (intentos > 0) Console.WriteLine($"{intentos} intentos restantes.");
            while (intentos > 0)
            {
                Console.SetCursorPosition(0, filaEntrada);
                Console.Write(new string(' ', 35));
                Console.SetCursorPosition(0, filaEntrada);
                Console.Write("Dime una letra: ");
                bool acierto = false;
                char entrada = Convert.ToChar(Console.ReadLine()!);
                utilizadas[numUtilizadas] = entrada;
                numUtilizadas++;
                Console.SetCursorPosition(12, 2);
                Console.Write(new string(' ', 30));
                Console.SetCursorPosition(12, 2);
                string letrasUsadas = string.Join(", ", utilizadas.Take(numUtilizadas)).ToLower();
                Console.WriteLine($"Usadas: {letrasUsadas}");

                for (int j = 0; j < palabraAleatoria.Length; j++)
                {
                    if (palabraAleatoria[j] == char.ToLower(entrada) || palabraAleatoria[j] == char.ToUpper(entrada))
                    {
                        palabraAst[j] = char.ToLower(entrada);
                        acierto = true;
                    }                }
                if (acierto)
                {
                    Console.SetCursorPosition(0, filaAst);
                    Console.WriteLine(new string(palabraAst));
                    if (!new string(palabraAst).Contains('*'))
                    {
                        Console.SetCursorPosition(0, filaEntrada + 2);
                        Console.WriteLine("Enhorabuena. Has acertado la palabra.");
                        return;
                    }
                }
                else
                {
                    intentos--;
                    Console.SetCursorPosition(12, 1);
                    Console.Write(new string(' ', 25));
                    Console.SetCursorPosition(12, 1);
                    if (intentos > 0) Console.WriteLine($"{intentos} intentos restantes.");
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
                            Console.SetCursorPosition(5, 4);
                            Console.WriteLine("/");
                            break;
                        case 2:
                            Console.SetCursorPosition(7, 4);
                            Console.WriteLine("\\");
                            break;
                       
                        case 1:
                            Console.SetCursorPosition(5, 5);
                            Console.WriteLine("/");
                            break;
                        case 0:
                            Console.SetCursorPosition(7, 5);
                            Console.WriteLine("\\");
                            Console.SetCursorPosition(0, filaEntrada + 2);
                            Console.WriteLine($"Perdiste. La palabra escogida era {palabraAleatoria}");
                            break;
                    }
                }

            } 
        }

        static void ejercicio8()
        {
            Console.WriteLine("Nombre del fichero: ");
            string entradaFichero = Console.ReadLine()!;
            try
            {
                string[] lineas = System.IO.File.ReadAllLines(entradaFichero);
            } 
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine($"Se ha producido un error: {e.Message}");
            }
        }

       



        static void Main(string[] args)
        {
            //ejercicio1();
            //ejercicio2();
            //ejercicio3();

            //int entrada = -1;
            //while (entrada != 0)
            //{
            //    Console.WriteLine($"1) Mostrar producto\n2) Añadir producto\n0) Salir");
            //    entrada = Convert.ToInt32(Console.ReadLine()!);
            //    switch (entrada)
            //    {
            //        case 0: ejercicio40(); break;
            //        case 1: ejercicio41(); break;
            //        case 2: ejercicio42(); break;
            //    }
            //}

            //ejercicio5();

            ejercicio6();
            //ejercicio7();
            //ejercicio8();



        }
    }
}
