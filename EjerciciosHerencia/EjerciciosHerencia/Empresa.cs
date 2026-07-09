using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosHerencia
{
    internal class Empresa
    {
        public Direccion Direccion { get; set; }
        public string Nombre { get; set; }
        public Empleado?[] Empleados { get; set; }
        public int NumEmpleados { get; set; }

        public Empresa(string nombre, Direccion direccion, int maxEmpleados)
        {
            Nombre = nombre;
            Direccion = direccion;
            Empleados = new Empleado[maxEmpleados];
            NumEmpleados = 0;
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            if(NumEmpleados >= Empleados.Length)
                Console.WriteLine("No hay espacio para más empleados.");
            Empleados[NumEmpleados] = empleado;
            NumEmpleados++;
        }

        public Empresa Clone()
        {
            Empresa copia = (Empresa)MemberwiseClone();
            copia.Direccion = Direccion.Clone();
            copia.Empleados = Empleados.Select(e => e?.Clone()).ToArray();
            return copia;
        }

        public IEnumerable<Empleado> ObtenerEmpleadosActivos() => Empleados.Where(e => e != null);

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Empresa: {Nombre}");
            sb.AppendLine($"Direccion: { Direccion}");
            sb.AppendLine($"Capacidad máxima: {Empleados.Length}");
            sb.AppendLine($"Empleados actuales: {NumEmpleados}");
            sb.AppendLine("Lista de empleados:");

            var activos = ObtenerEmpleadosActivos().ToList();

            if (!activos.Any()) sb.AppendLine( "Sin empleados");
            else
            {
                var lineas = activos.Select((emp, indice) => $"  {indice + 1}. {emp}");
                foreach (var linea in lineas)
                    sb.AppendLine(linea);
            }
            return sb.ToString();
        }
    }
}
