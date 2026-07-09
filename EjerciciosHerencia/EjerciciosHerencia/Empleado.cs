using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosHerencia
{
    internal class Empleado
    {
        public string Nombre {  get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, decimal salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public override string ToString() => $"{Nombre} - {Salario:C2}";

        public Empleado Clone() => (Empleado)MemberwiseClone();
    }
}
