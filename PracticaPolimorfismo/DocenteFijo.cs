namespace PracticaPolimorfismo;

public class DocenteFijo : Empleado
{
    private const string rol = "Docente Fijo";
    public double salario { get; private set; }
    public int horasTrabajada { get; private set; }
    
    public DocenteFijo(int IdEmpleado, string nombre, string apellido, double salario, int horasTrabajada) :
        base(IdEmpleado, nombre, apellido)
    {
        this.horasTrabajada = horasTrabajada;
        this.salario = salario;
    }

    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Puesto: {rol}");
        Console.WriteLine($"Horas trabajadas: {horasTrabajada}");
        Console.WriteLine($"Salario Base: {salario}");
        Console.WriteLine($"Salario de este mes: {CalcularSalario()}");
    }

    public override double CalcularSalario()
    {
        return horasTrabajada >= HorasMinimas    
            ? salario 
            : salario / 2;
    }
}