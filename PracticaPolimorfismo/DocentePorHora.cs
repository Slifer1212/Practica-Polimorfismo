namespace PracticaPolimorfismo;

public class DocentePorHora : Empleado
{
    private const int  PagoPorHora = 800;
    protected int horasTrabajadas { get;}
    private string rol = "Docente por Hora";
    
    public DocentePorHora(int IdEmpleado, string nombre, string apellido, int horasTrabajadas) :
        base(IdEmpleado, nombre, apellido)
    {
        this.horasTrabajadas = horasTrabajadas;
        rol = "Docente por Hora";
    }
    public override double CalcularSalario() =>horasTrabajadas * PagoPorHora;
    

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Puesto: {rol}");
        Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
        Console.WriteLine($"Salario de este mes: {CalcularSalario()}");
    }
}