// See https://aka.ms/new-console-template for more information

namespace PracticaPolimorfismo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Empleado[] empleados = new Empleado[3];
            empleados[0] = new DocenteFijo(1, "Juan", "Perez", 10000, 160);
            empleados[1] = new DocentePorHora(2, "Maria", "Martinez", 160);
            empleados[2] = new EmpleadoAdministrativo(3, "Pedro", "Gomez", 8000);

            foreach (var empleado in empleados)
            {
                empleado.MostrarDatos();
                Console.WriteLine();
            }
        }
    }
}
