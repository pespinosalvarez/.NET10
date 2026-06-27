using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace EjerciciosBucles
{
    internal class Program
    {
        static void Ejercicio1()
        {
            //Muestra por pantalla los números de 20 al 1 usando un bucle while, y después hazlo
            //otra vez usando un bucle for. 

            int i = 20;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }

            for (int j = 20; j >= 1; j--)
            {
                Console.WriteLine(j);
            }

        }

        static void Ejercicio2()
        {
            //Inicializa una variable entera a 0.Después, pregunta al usuario por un número y
            //súmaselo a la variable inicial. Repite esto hasta que el usuario introduzca el número
            //cero.Utiliza el bucle do ..while.

            int total = 0;
            int anadido = 0;
            do
            {
                Console.WriteLine("Indica el número que quieras sumar al total (añade 0 para terminar):");
                anadido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Total acumulado: {total += anadido}");
            } while (anadido != 0);

        }

        static void Ejercicio3()
        {
            //Pide al usuario un número y calcula cuantas cifras tiene dicho número. Para ello
            //puedes dividir el número entre 10 hasta que el resultado sea cero.

            Console.WriteLine("Da un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int cifras = 0;

            while (num != 0)
            {
                num /= 10;
                cifras++;
            }

            Console.WriteLine($"El número tiene {cifras} cifras.");
        }

        static void Ejercicio4()
        {
            //Pide al usuario un número y dibuja una línea con tantos asteriscos como el número
            //introducido.

            Console.WriteLine("Da un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < num; i++) Console.Write("*");

        }

        static void Ejercicio5()
        {
            //Muestra los números del 1 al 30 menos los divisibles entre 3(resto da cero).

            for (int i = 1; i <= 30; i++) Console.Write((i % 3 != 0 ? $"{i}," : ""));

        }

        static void Ejercicio6()
        {
            //Muestra de 5 en 5, los números del 0 al 100.

            for (int i = 0; i <= 100; i += 5) 
                Console.Write(i < 100 ? $"{i}," : i);
            
        }

        static void Ejercicio7()
        {
            //Pregunta al usuario un número y muestra del 1 hasta ese número, en una misma línea,
            //separados por comas(debes comprobar cuando es el último y no poner una coma en
            //ese caso). 

            Console.WriteLine("Dime un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++) Console.Write(i < num ? $"{i}," : i);

        }

        static void Ejercicio8()
        {
            //Repite el ejercicio 2 pero con un bucle infinito(la condición nunca será falsa).En este
            //caso tendrás que comprobar dentro del bucle cuando el usuario ha introducido un
            //cero para salir(break). Si el usuario introduce un número negativo no lo sumes(usa
            //continue para saltarte la suma). 

            int total = 0;
            int anadido = 0;
            while(true)
            {
                Console.WriteLine("Indica el número que quieras sumar al total (añade 0 para terminar):");
                anadido = Convert.ToInt32(Console.ReadLine());
                if( anadido == 0) break;
                else if( anadido < 0) continue;
                else Console.WriteLine($"Total acumulado: {total += anadido}");
            }

        }

        static void Ejercicio9()
        {
            //Pide al usuario un número y dile los divisores de dicho número (resto da cero).

            Console.WriteLine("Dime un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Los divisores de {num} son: ");
            for(int i = 1; i < num; i++) Console.Write(num % i == 0 ? $"{i}," : "");
            Console.WriteLine(num);
        }

        static void Ejercicio10()
        {
            //Escribe en una misma línea los números del 1 al 9, 5 veces:
            //123456789123456789123456789123456789123456789

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write(j);
                }
            }
        }

        static void Ejercicio11()
        {
            //Escribe los números del 1 al 9, después del 1 al 8, del 1 al 7, y así sucesivamente en
            //líneas diferentes. 
            //123456789
            //12345678
            //1234567
            //123456
            //12345
            //1234
            //123
            //12
            //1

            for (int i = 9; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++) Console.Write(j);

                Console.WriteLine();
            }
        }

        static void Ejercicio12()
        {
            //Pide al usuario un número y dibuja un cuadrado(mismo alto que ancho) con asteriscos
            //según el número recibido. 
            //Dime un número: 4
            //****
            //****
            //****
            //****

            Console.WriteLine("Dime un número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int fila = 0; fila < num; fila++)
            {
                for (int columna = 0; columna < num; columna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        static void Ejercicio13()
        {
            //Pide al usuario un número y dibuja una escalera de bajada con asteriscos.La base será
            //igual al número recibido.
            //Dime un número: 4
            //*
            //**
            //***
            //****

            Console.WriteLine("Da un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }

        static void Ejercicio14()
        {
            // Haz lo mismo pero con una escalera de subida(para generar los huecos debes escribir
            // el carácter de espacio).
            //Dime un número: 4
            //   *
            //   **
            //   ***
            //  ****

            Console.WriteLine("Da un número entero: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num - i; j++) Console.Write(" ");
                for (int k = 1; k <= i; k++) Console.Write("*");
                Console.WriteLine();
            }
        }

        static void Ejercicio14b()
        {
            // Haz lo mismo pero con una escalera de subida(para generar los huecos debes escribir
            // el carácter de espacio).
            //Dime un número: 4
            //     *
            //    **
            //   ***
            //  ****

            Console.WriteLine("Da un número entero para la altura: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++) Console.Write(j <= num - i ? " " : "*");
                Console.WriteLine();
            }
        }

        static void Ejercicio15()
        {
            //Pide al usuario un ancho y un alto y dibuja un rectángulo vacío.
            //Dime un ancho: 5
            //Dime un alto: 4
            //*****
            //*   *
            //*   *
            //*****

            Console.WriteLine("Dime el ancho: ");
            int ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dime el alto: ");
            int alto = Convert.ToInt32(Console.ReadLine());

            for (int fila = 1; fila <= alto; fila++)
            {
                if (fila == 1 || fila == alto)
                {
                    for (int columna = 1; columna <= ancho; columna++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int columna = 2; columna < ancho; columna++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Ejercicio16()
        {
            //Pide al usuario un número que será la altura de una pirámide. Dibuja una pirámide
            //con asteriscos con dicha altura
            //Pista: El ancho(base) de la pirámide será: (altura * 2 – 1), y la posición del primer
            //asterisco será el mismo que la altura si empiezas el bucle en 1(o una menos si lo quieres
            //empezar en 0).Crea 2 variables auxiliares con la posición del primer asterisco, una la irás
            //decrementando y otra incrementando. Si la posición actual está entre esas 2 variables dibujas
            //un asterisco, y si no, un espacio.

            Console.WriteLine("Indica la altura de la pirámide: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            int ancho = altura * 2 - 1;
            int crec = altura;
            int decrec = altura;

            for(int i = 1; i <= altura; i++)
            {
                for(int j = 1; j <= ancho; j++)
                    Console.Write(crec > j && decrec < j ? "*" : " ");
                Console.WriteLine();
                crec++;
                decrec--;
            }
        }

        static void Ejercicio17()
        {
            // Dibuja ahora una pirámide hueca

            Console.WriteLine("Indica la altura de la pirámide: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            int ancho = altura * 2 - 1;
            int crec = altura;
            int decrec = altura;

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= ancho; j++)
                    Console.Write(crec == j || decrec == j || i == altura ? "*" : " ");
                Console.WriteLine();
                crec++;
                decrec--;
            }
        }

        static void Ejercicio18()
        {
            // Dibuja ahora una pirámide invertida

            Console.WriteLine("Indica la altura de la pirámide: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            int ancho = altura * 2 - 1;
            int crec = 1;
            int decrec = ancho;

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= ancho; j++)
                    Console.Write(crec <= j && decrec >= j ? "*" : " ");
                Console.WriteLine();
                crec++;
                decrec--;
            }
        }

        static void Ejercicio19()
        {
            //    Ahora dibuja un rombo(puedes dibujar una pirámide y posteriormente una pirámide
            //    invertida). Pide al usuario el ancho del rombo, que deberá ser un número impar(sigue
            //    pidiéndole un número hasta que introduzca uno impar). 
            //    Si quieres hacerlo con 2 pirámides, la altura de la primera sería(ancho +1) / 2

            Console.WriteLine("Indica el ancho del rombo (número entero impar): ");
            int ancho = Convert.ToInt32(Console.ReadLine());
            int altura = (ancho + 1) / 2;
            int crec1 = altura;
            int decrec1 = altura;
            int crec2 = 1;
            int decrec2 = ancho;

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= ancho; j++)
                    Console.Write(crec1 > j && decrec1 < j ? "*" : " ");
                Console.WriteLine();
                crec1++;
                decrec1--;
            }

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= ancho; j++)
                    Console.Write(crec2 <= j && decrec2 >= j ? "*" : " ");
                Console.WriteLine();
                crec2++;
                decrec2--;
            }


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
            //Ejercicio9();
            //Ejercicio10();
            //Ejercicio11();
            //Ejercicio12();
            //Ejercicio13();
            //Ejercicio14();
            Ejercicio14b();
            //Ejercicio15();
            //Ejercicio16();
            //Ejercicio17();
            //Ejercicio18();
            //Ejercicio19();
        }
    }
}