using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ejerciciosPOO
{
    internal class Empresa
    {
        private string _nombre;
        private string[] _empleados;
        private int _numEmpleados;

        public string Nombre 
        { 
            get { return _nombre; } 
            set { _nombre = value; } 
        }
        public string[] Empleados
        {
            get { return _empleados; }
        }
        //        Crea un constructor que reciba el nombre de la empresa y lo asigne.Además, deberá
        //inicializar el array de empleados con 100 posiciones, y la propiedad numEmpleados a cero.
        //Crea una empresa y muestra “He creado la empresa (nombre de la empresa)”  después por
        //la consola.

        public Empresa(string nombre)
        {
            Nombre = nombre;
            _empleados = new string[100];
            _numEmpleados = 0;
        }

        public void ContrataEmpleado( Persona p)
        {
            if(_numEmpleados < _empleados.Length)
            {
                _empleados[_numEmpleados] = p.Nombre;
                _numEmpleados++;
            }
        }

        public void MuestraEmpleados()
        {
            for (int i = 0; i < _numEmpleados; i++)
            {
                Console.WriteLine($"- Empleado {i + 1}: {_empleados[i]}");
            }
        }

        public void DespideEmpleado(int pos)
        {
            if (pos < 0 || pos >= _numEmpleados)
            {
                Console.WriteLine("Error: Posición no válida.");
                return;
            }
            for (int i = pos; i < _numEmpleados-1; i++)
            {
                _empleados[i] = _empleados[i+1] ;
            }
            _empleados[_numEmpleados - 1] = null;
            _numEmpleados--;
        }

        public void DespideEmpleado(string nombre)
        {
            int posicionEncontrada = -1;
            for (int i = 0; i < _numEmpleados - 1; i++)
            {
                if (_empleados[i] != null && _empleados[i].Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    posicionEncontrada = i;
                    break;
                }
            }
            if (posicionEncontrada != -1)
            {
                DespideEmpleado(posicionEncontrada);
            }
            else
            {
                Console.WriteLine($"No se encontró ningún empleado con el nombre: {nombre}");
            }

        }


    }
}
