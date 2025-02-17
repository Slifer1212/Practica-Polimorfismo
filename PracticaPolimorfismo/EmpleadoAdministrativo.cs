﻿namespace PracticaPolimorfismo;

public class EmpleadoAdministrativo : Empleado
{
    private const string rol = "Empleado Administrativo";
    public decimal salario { get;}
    public int HorasTrabajadas { get; private set; }

    public EmpleadoAdministrativo(int IdEmpleado, string nombre, string apellido, decimal salario) :
        base(IdEmpleado, nombre, apellido)
    {
        this.salario = salario;
    }

    public override decimal CalcularSalario()  => HorasTrabajadas >= HorasMinimas ? salario : salario / 2;



    public override void MostrarDatos()
    {
        base.MostrarDatos();
        Console.WriteLine($"Puesto: {rol}");
        Console.WriteLine($"Horas trabajadas: {HorasTrabajadas}");
        Console.WriteLine($"Salario Base: {salario}");
        Console.WriteLine($"Salario de este mes: {CalcularSalario()}");
    }
}