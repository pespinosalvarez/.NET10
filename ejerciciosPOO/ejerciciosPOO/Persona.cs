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
            set { if (value >= 0) _edad = value;
            else Console.WriteLine("La edad no puede ser menor que 0."); }
        }

        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public string Saluda() 
        {
            return $"{_nombre} con {_edad} años.";
        }

        public Persona(Persona p)
        {
            this._nombre = p._nombre;
            this._edad = p._edad;
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
