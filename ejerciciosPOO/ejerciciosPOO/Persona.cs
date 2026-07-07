using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejerciciosPOO
{
    internal class Persona
    {
        private string _nombre;
        private int _edad;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { if (value > 0) _edad = value; }
        }

        public Persona(string _nombre, int _edad)
        {
            Nombre = _nombre;
            Edad = _edad;
        }

        public void Saluda() 
        {
            Console.WriteLine($"{Nombre} tiene {Edad} años.");
        }

        public Persona(Persona p)
        {
            Nombre = p.Nombre;
            Edad = p.Edad;
        } 

        public static Persona[] CopiaArray(Persona[] pOriginal)
        {
            Persona[] copiaPersonas = new Persona[pOriginal.Length];
             for(int i= 0; i < pOriginal.Length; i++)
            {
                if (pOriginal[i] != null)
                    copiaPersonas[i] = new Persona(pOriginal[i]);
                else
                    copiaPersonas[i] = null;
            }
            return copiaPersonas;
        }

        public bool EstoyEnArray(Persona[] pOriginal)
        {
            for (int i = 0; i < pOriginal.Length; i++)
                if (pOriginal[i] == this && pOriginal[i] != null) return true;
            return false;
        }
        
    }
}
