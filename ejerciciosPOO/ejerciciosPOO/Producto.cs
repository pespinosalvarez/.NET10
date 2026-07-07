using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosPOO
{
    internal class Producto
    {
        private string nombre;
        private double precio;
        public string Nombre { get; set; }
        public double Precio{ get;set;}
        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
        public double getPrecioImpuesto(double impuesto)
        {
            return Precio*(1 +  impuesto);
        }

    }
}
