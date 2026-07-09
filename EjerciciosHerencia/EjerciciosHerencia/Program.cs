namespace EjerciciosHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Direccion direccionEmpresa = new Direccion("Zuquillo", 133);
            Empresa miEmpresa = new Empresa("MiEmpresa", direccionEmpresa,5);
            miEmpresa.AgregarEmpleado(new Empleado("Pablo", 3500));
            miEmpresa.AgregarEmpleado(new Empleado("Zuco", 3345));
            miEmpresa.AgregarEmpleado(new Empleado("Shallan", 5670));

            Empresa copiaEmpresa = miEmpresa.Clone();

            copiaEmpresa.Empleados[0].Nombre = "Pablo Clonado";
            copiaEmpresa.Direccion.Numero = 999;
            copiaEmpresa.AgregarEmpleado(new Empleado("Kaladin", 4200));

            Console.WriteLine("========== EMPRESA ORIGINAL ==========");
            Console.WriteLine(miEmpresa);

            Console.WriteLine("========== EMPRESA COPIA ==========");
            Console.WriteLine(copiaEmpresa);
        }
    }
}
