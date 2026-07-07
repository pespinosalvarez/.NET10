using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosPOO
{
    internal class Cuadrado
    {
        private double lado;
        public double Lado
        {
            get { return lado; }
            set
            {
                if (value > 0.0) lado = value;
            }
        }
        public Cuadrado(double lado)
        {
            Lado = lado; 
        }

        public Cuadrado()
        {
            Lado = 1;
        }

        public Cuadrado(int lado)
        {
            Lado = lado;
        }
    }
}
