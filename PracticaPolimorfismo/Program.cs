// See https://aka.ms/new-console-template for more information

namespace PracticaPolimorfismo
{
    class Program
    {
        public static void Main(string[] args)
        {
            DocenteFijo docente1 = new DocenteFijo(01, "Juan" , "Soto", 2500,8);
            DocentePorHora docentePorHora = new DocentePorHora(02, "Maria", "Perez", 10);
            EmpleadoAdministrativo empleadoAdministrativo = new EmpleadoAdministrativo(03, "Pedro", "Gomez", 2000);
            docentePorHora.MostrarDatos();
            docente1.MostrarDatos();
            empleadoAdministrativo.MostrarDatos();
        }
    }
}
