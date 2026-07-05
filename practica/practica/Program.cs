using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace practica
{
    internal class Program
    {

        static void EliminaDuplicados()
        {
            int[] numeros = { 1, 2, 3, 2, 4, 3, 5, 1, 6 };
            Console.WriteLine(string.Join(", ", numeros.Distinct().ToArray()));
            string[] palabras = { "perro", "gato", "perro", "gato", "perro", "pajaro" };
            Console.WriteLine(string.Join(", ", palabras.Distinct().ToArray()));

        }

        static void EliminaDuplicadosb()
        {
            int[] numeros = { 1, 2, 3, 2, 4, 3, 5, 1, 6 };
            List<int> listaUnicos = new List<int>();

            foreach(int numero in numeros)
                if (!listaUnicos.Contains(numero)) listaUnicos.Add(numero);
            Console.WriteLine(string.Join(", ", listaUnicos.ToArray()));

        }

        static void Polindromo()
        {
            Console.WriteLine("Escribe una palabra: ");
            string palabra = Console.ReadLine()!.ToLower();
            bool esPolindromo = palabra.SequenceEqual(palabra.Reverse());
            Console.WriteLine(esPolindromo ? "La palabra es polindromo" : "No es un polindromo");
        }
        
        static void ValidarContrasenya()
        {
            Console.WriteLine("Escribe una contraseña (8 caracteres, una mayúscula, una minúscula, un número y un carácter especial): ");
            string contrasenya = Console.ReadLine() ?? "";
            string especiales = "!@#$%^&*";
            bool largo = contrasenya.Length >= 8;
            bool mayuscula = contrasenya.Any(c => char.IsUpper(c));
            bool minuscula = contrasenya.Any(c => char.IsLower(c));
            bool numero = contrasenya.Any(c => char.IsDigit(c));
            bool especial = contrasenya.Any(c => especiales.Contains(c));
            if(largo && mayuscula && minuscula && numero && especial)
                Console.WriteLine("Contraseña válida.");
            else
            {
                Console.WriteLine("Contraseña inválida.");
                Console.WriteLine(!largo ? "La contraseña debe tener al menos 8 caracters." : "");
                Console.WriteLine(!mayuscula ? "La contraseña debe tener una mayuscula" : "");
                Console.WriteLine(!minuscula ? "La contraseña debe una minuscula" : "");
                Console.WriteLine(!numero ? "La contraseña debe tener un numero." : "");
                Console.WriteLine(!especial ? "La contraseña debe tener un carácter especial." : "");
            }
        }

        static void ValidarContrasenyab()
        {
            Console.WriteLine("Escribe una contraseña (8 caracteres, una mayúscula, una minúscula, un número y un carácter especial): ");
            string contrasenya = Console.ReadLine() ?? "";
            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*]).{8,}$";
            bool valida = Regex.IsMatch(contrasenya, patron);
            Console.WriteLine(valida ? "Contraseña válida." : "Contraseña invalida.");
        }

        static void AnalizarTexto()
        {
            Console.WriteLine("Escribe un texto: ");
            string texto = Console.ReadLine() ?? "";
            int numCaracteres = texto.Length;
            int numFrases = Regex.Split(texto, @"[.!?]").Where(f=> !string.IsNullOrWhiteSpace(f)).Count();
            var palabras = Regex.Matches(texto.ToLower(), @"\b\w+\b").Select(m => m.Value).ToList();
            // .Select(m => m.Value) extrae el texto puro de cada coincidencia encontrada
            // .ToList() guarda todas las palabras en una lista indexada
            int numPalabras = palabras.Count();
            string masLarga = palabras.OrderByDescending(p=>p.Length).FirstOrDefault() ?? "N/A";
            string masFrecuente = palabras.GroupBy(p => p) //Agrupas todos los elementos iguales en cajitas
                                           .OrderByDescending(g => g.Count()) //Ordenas las cajitas por número de integrantes
                                           .Select(p => p.Key)  //Selecciona el nombre de la palabra
                                           .FirstOrDefault() ?? "N/A";

            Console.WriteLine($"Numero de caracteres: {numCaracteres}\nNumeros de frases: {numFrases}\nNumero de palabras: {numPalabras
            }\nPalabras más larga: {masLarga}\nPalabra más frecuente: {masFrecuente}");
        }

        static bool EsNumeroPrimo(int n)
        {
            if (n < 2) return false;

            // Función local: solo existe dentro de EsNumeroPrimo
            bool TieneDivisor(int limite)
            {
                for (int i = 2; i <= limite; i++)
                {
                    if (n % i == 0) return true;
                }
                return false;
            }

            return !TieneDivisor((int)Math.Sqrt(n));
        }

        static int GenerarNumero() => Random.Shared.Next(1, 101);

        static int PedirIntento() 
        {
            bool esNumero = false;
            int num = 0;
            while (!esNumero || num < 1 || num>100)
            {
                Console.WriteLine("Dime un número entero del 1 al 100: ");
                string entrada = Console.ReadLine()!;
                esNumero = int.TryParse(entrada, out num);
                if(!esNumero || num < 1 || num > 100)
                    Console.WriteLine("Error: La entrada debe ser un número entero entre 1 y 100.");
            }
            return num;
        }
           
        static (bool acierto, string pista) ComprobarIntento(int secreto, int intento)
        {
            return (secreto - intento) switch
            {
                0 => (true, "Has acertado el número."),
                >0 => (false, "El número secreto es mayor que el indicado."),
                <0 => (false, "El número secreto es menor que el indicado")
            };
        }
        
        static void Main(string[] args)
        {
            //EliminaDuplicados();
            //EliminaDuplicadosb();
            //Polindromo();
            //ValidarContrasenya();
            //ValidarContrasenyab();
            //AnalizarTexto();


            /*
            Método Regex para identificar patrones en estrings.
            ^ Comenzar cadena
            $ Terminar cadena
            ?= Mira hacia delante
            .* saltando cualquier cantidad de caracteres (o ninguno)
            [A-Z] cualquier valor entre los indicados
            (?=...) Mira hacia delante, cuando hayas combrobado toda la cadena, regresa.
            \d cualquier digito
            .{8,} 8 caracters minimo, los que sean
            [\w] cualquier caracter que sea letra, números o guiones bajos
            \S cualquier caracter excepto espacios
            \b significa límite de palabra, @"\b\w+\b" busca todas las palabras del texto
            */

            bool acierto = false;
            int numSecreto = GenerarNumero();
            while (!acierto)
            {
                var (acerto,pista) = ComprobarIntento(numSecreto, PedirIntento());
                acierto = acerto;
                Console.WriteLine(pista);
            }
        }

    }
    
}


