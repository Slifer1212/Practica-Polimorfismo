using System.Runtime.InteropServices;

namespace PracticaPolimorfismo;

public abstract class Empleado
{
    protected const int HorasMinimas = 160;
    public int IdEmpleado { get; private set; }
    public string nombre { get; private set; }
    public string apellido { get; private set; }

    public Empleado(int IdEmpleado, string nombre, string apellido)
    {
        this.IdEmpleado = IdEmpleado;
        this.nombre = nombre;
        this.apellido = apellido;
    }

    public abstract decimal CalcularSalario();

    public virtual void MostrarDatos()
    {
        Console.WriteLine($"Id: {IdEmpleado}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Apellido: {apellido}");
        
    }
}