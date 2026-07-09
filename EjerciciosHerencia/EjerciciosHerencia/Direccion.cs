using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosHerencia
{
    internal class Direccion
    {
        public string Calle { get; set; }
        public int Numero { get; set; }

        public Direccion(string calle, int numero)
        {
            Calle = calle;
            Numero = numero;
        }

        public override string ToString() => $"{Calle}, {Numero}";

        public Direccion Clone()  => (Direccion)MemberwiseClone();
    }
}
