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
        private Persona[] _empleados;
        private int _numEmpleados;

        public string Nombre 
        { 
            get { return _nombre; } 
            set { _nombre = value; } 
        }
        public Persona[] Empleados
        {
            get { return _empleados; }
        }
     
        public Empresa(string nombre)
        {
            _nombre = nombre;
            _empleados = new Persona[100];
            _numEmpleados = 0;
        }

        public void ContrataEmpleado( Persona pContratada)
        {
            if(_numEmpleados < _empleados.Length)
            {
                _empleados[_numEmpleados] = pContratada;
                _numEmpleados++;
            }
        }

        public void MuestraEmpleados()
        {
            for (int i = 0; i < _numEmpleados; i++)
            {
                Console.WriteLine($"{_empleados[i].Nombre} tiene {_empleados[i].Edad}");
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
                if (_empleados[i] != null && _empleados[i].Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
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

        //public Persona EmpleadoMasJoven()
        //{
        //    if (_numEmpleados == 0) return null;
        //    Persona masJoven = _empleados[0];
        //    for(int i = 1; i < _numEmpleados; i++)
        //    {
        //        if (_empleados[i] != null && _empleados[i].Edad <= masJoven.Edad) 
        //            masJoven = _empleados[i];
        //    }
        //    return masJoven;
        //}

        public Persona? EmpleadoMasJovenb()
        {
            if(_numEmpleados == 0 ) return null;
            return _empleados.Where(e => e != null).OrderBy(e => e.Edad).FirstOrDefault(); 
        }

        //public Persona EmpleadoMasMayor()
        //{
        //    if (_numEmpleados == 0) return null;
        //    Persona masMayor = _empleados[0];
        //    for(int i = 1; i < _numEmpleados; i++)
        //    {
        //        if (_empleados[i] != null && _empleados[i].Edad >= masMayor.Edad) 
        //            masMayor = _empleados[i];
        //    }
        //    return masMayor;
        //}

        public Persona? EmpleadoMasMayorb()
        {
            if (_numEmpleados == 0) return null;
            return _empleados.Where(e => e != null).OrderByDescending(e => e.Edad).FirstOrDefault();
        }

        public double EdadPromedio()
        {
            return _empleados.Where(e=>e != null).Average(e=>e.Edad);
        }

        //public int EmpleadosPorEncimaDeMedia()
        //{
        //    int porEncima = 0;
        //    for(int i = 0; i < _numEmpleados; i++)
        //    {
        //        if (_empleados[i] != null && _empleados[i].Edad > EdadPromedio()) porEncima++;
        //    }
        //    return porEncima;
        //}
        public int EmpleadosPorEncimaDeMediab()
        {
            if (_numEmpleados == 0) return 0;
            return _empleados.Where(e => e != null && e.Edad > EdadPromedio()).Count();
        }

        //public int EmpleadosPorDebajoDeMedia()
        //{
        //    int porDebajo = 0;
        //    for(int i = 0; i < _numEmpleados; i++)
        //    {
        //        if (_empleados[i] != null && _empleados[i].Edad < EdadPromedio()) porDebajo++;
        //    }
        //    return porDebajo;
        //}

        public int EmpleadosPorDebajoDeMediab()
        {
            if (_numEmpleados == 0) return 0;
            return _empleados.Where(e => e != null && e.Edad < EdadPromedio()).Count();
        }


    }
}
