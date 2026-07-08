using System.Runtime.Serialization;
using System.Threading.Channels;

namespace ejerciciosPOO
{
    internal class Program
    {
        static void ejercicio8()
        {
            Empresa e1 = new Empresa("Zuco");
            Console.WriteLine($"He creado una empresa llamada {e1.Nombre}");
        }

       

        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pepito", 16);
            Console.WriteLine($"{p1.Nombre} tiene {p1.Edad} años.");

            //    //p1.Saluda();


            //    //Persona p2 = p1;
            //    //p2.Nombre = "María";
            //    //p2.Edad = 24;
            //    //p2.Saluda();
            //    //p1.Saluda();

            Persona p2 = new Persona(p1);
            p2.Nombre = "María";
            p2.Edad = 24;
            //    //p2.Saluda();
            //    //p1.Saluda();

            Persona[] personas = { p1, p2, new Persona("Pedro", 34), new Persona("Alba", 87) };
            //    //for (int i = 0; i < personas.Length; i++)
            //    //{
            //    //    personas[i].Saluda();
            //    //}

            //    //Persona[] personas = { p1, p2, null , new Persona("Alba", 87) };
            //    //for (int i = 0; i < personas.Length; i++)
            //    //    personas[i]?.Saluda();

            //    Console.WriteLine();
            //    //Persona[] personas2 = Persona.CopiaArray(personas);
            //    //personas2[0].Nombre = "Pablo";
            //    //personas2[3].Edad = 32;
            //    //for (int i = 0; i < personas2.Length; i++)
            //    //    personas2[i]?.Saluda();

            //    Persona pInventada = new Persona("Álvaro", 13);
            //    pInventada.EstoyEnArray(personas);
            //    if (pInventada.EstoyEnArray(personas)) Console.WriteLine($"{pInventada.Nombre} está en el array");
            //    else Console.WriteLine("No está en el array");
            //    if (p1.EstoyEnArray(personas)) Console.WriteLine($"{p1.Nombre} está en el array");
            //    else Console.WriteLine("No está en el array");

            //ejercicio8();
            Empresa e1 = new Empresa("Zuco");
            Console.WriteLine($"He creado una empresa llamada {e1.Nombre}");
            for (int i = 0; i < 4; i++)
            {
                e1.ContrataEmpleado(personas[i]);
            }

            e1.MuestraEmpleados();
            //e1.DespideEmpleado(2);
            //e1.DespideEmpleado("Pepito");
            //Console.WriteLine();
            //e1.MuestraEmpleados();


            Console.WriteLine( );
            Console.WriteLine($"La persona más joven es: {e1.EmpleadoMasJovenb()?.Saluda()}"); 
            Console.WriteLine($"La persona más mayor es: {e1.EmpleadoMasMayorb()?.Saluda()}"); 
            Console.WriteLine($"La edad promedio de la empresa es: {e1.EdadPromedio()}");
            //Console.WriteLine($"Empleados por encima de la media: {e1.EmpleadosPorEncimaDeMedia()}");
            Console.WriteLine($"Empleados por encima de la media: {e1.EmpleadosPorEncimaDeMediab()}");
            //Console.WriteLine($"Empleados por debajo de la media: {e1.EmpleadosPorDebajoDeMedia()}");
            Console.WriteLine($"Empleados por debajo de la media: {e1.EmpleadosPorDebajoDeMediab()}");
        }
    }
}
