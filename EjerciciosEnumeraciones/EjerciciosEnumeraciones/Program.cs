using System.Collections.Immutable;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace EjerciciosEnumeraciones
{
    internal class Program
    {
        static int maxEnteros(params int[] enteros)
        {
            if(enteros.Length != 0) return enteros.Max();
            else return 0;
        }

        static int encontrarRepetido(string texto, string buscar)
        {
            int repetido = 0;
            int i = 0;
            while ((i = texto.IndexOf(buscar, i)) != -1)
            {
                repetido++;
                i += buscar.Length;
            }
            return repetido;
        }

        static void ejercicio3(string texto, char separador, int n)
        {
            for(int i=n; i < texto.Length; i+=n)
            {
                    texto = texto.Insert(i, separador.ToString());
                    i++;     
            }
            Console.WriteLine(texto);
        }

        static double promedio(string numeros)
        {
            string[] numTexto = numeros.Split(';');
            double[] num = new double[numTexto.Length];
            for(int i=0; i < numTexto.Length; i++)
            {
                num[i] = Convert.ToDouble(numTexto[i]);
            }
            return num.Average();
        }

        static string[] ordenadas(string[] texto)
        {
            //char[] textoArray = texto.ToCharArray();
            Array.Sort(texto);
            Array.Reverse(texto);
            return texto;
        }

        static int numeroRepetido(int[] numeros, int num)
        { 
            int[] veces = Array.FindAll(numeros, n => n == num);
            return veces.Length;
        }

        static void fecha(DateTime fechaDada)
        {
            string[] dias = { "domingo", "lunes", "martes", "miércoles", "jueves", "viernes", "sábado" };
            string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };
            string diaHoy = dias[(int)fechaDada.DayOfWeek];
            string mesHoy = meses[fechaDada.Month - 1];
            Console.WriteLine($"Hoy es {diaHoy}, {fechaDada.Day:D2} de {mesHoy} de {fechaDada.Year}");
            //Console.WriteLine($"Hoy es {fechaDada:D}");
        }

        static void fecha2(string fecha)
        {
            int dia = Convert.ToInt32(fecha.Substring(0, 2));
            int mes = Convert.ToInt32(fecha.Substring(3, 2));
            int anyo = Convert.ToInt32(fecha.Substring(6, 4));

            DateTime fechaDate = new DateTime(anyo, mes, dia);
            DateTime fechaModificada = fechaDate.AddDays(10).AddMonths(3).AddYears(2);

            Console.WriteLine($"{fechaModificada:D}");
        }

        static void diferenciaDias(DateTime fecha)
        {
            TimeSpan diferencia = DateTime.Now - fecha;
            Console.WriteLine($"La diferencia de días es: {Math.Abs(diferencia.Days)}");
        }

        static void IncrementarDinero(ref double saldo, double ingreso)
        {
            saldo += ingreso;
        }

        static void ObtenerDimensiones(string mueble, out double ancho, out double alto)
        {
            if(mueble == "Mesa")
            {
                ancho = 1.5;
                alto = 0.75;
            }
            else
            {
                ancho = 0;
                alto = 0;
            }
        }


        static void Main(string[] args)
        {
            //Console.WriteLine($"El máximo valor de la serie de enteros es: {maxEnteros(3,5,7,4,8,9,453,5)}");

            //Console.WriteLine($"La palabra indicada se repite {encontrarRepetido("cocinando cocos con chocolate", "co")} veces.");

            //ejercicio3("Hay una mosca en mi sopa", '*', 3);

            //Console.WriteLine(promedio("4;5;7;8;9;10"));

            //string[] desordenado = { "a", "k", "s", "l" };
            //string[] reves = ordenadas(desordenado);
            //Console.WriteLine(string.Join("," , reves)); 

            //Console.WriteLine($"El número indicado se repite {numeroRepetido([1, 3, 4, 5, 6, 3, 3], 3)} veces");

            //fecha(new DateTime(2019,7,4));

            //fecha2("04-07-2019");

            //diferenciaDias(DateTime.Parse("01 / 07 / 2029"));

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //double saldo = 560;
            //Console.WriteLine($"Tengo {560}€ e ingreso {40}€");
            //IncrementarDinero(ref saldo, 40);
            //Console.WriteLine($"Mi nuevo saldo es {saldo}€");

            //ObtenerDimensiones("Mesa", out double ancho, out double alto);
            //Console.WriteLine($"{ancho},{alto}");

        }
    }
}
