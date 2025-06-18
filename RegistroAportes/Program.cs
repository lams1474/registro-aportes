class Program
{
    static void Main(string[] args)
    {
        Asociacion asociacion = new Asociacion(20);

        Empleado emp1 = new Empleado(1, "Piedad Cango", "Secretaria", 10);
        emp1.AgregarAporte(new Aporte(DateTime.Now, 50.0, "Cuota mensual"));
        emp1.AgregarAporte(new Aporte(DateTime.Now.AddDays(-10), 20.0, "Donación"));

        Empleado emp2 = new Empleado(2, "Kevin Maigua", "Técnico", 10);
        emp2.AgregarAporte(new Aporte(DateTime.Now, 60.0, "Cuota mensual"));

        Empleado emp3 = new Empleado(3, "Bryan Maigua", "Contadora", 10);
        emp3.AgregarAporte(new Aporte(DateTime.Now.AddDays(-5), 75.5, "Aporte extraordinario"));

        Empleado emp4 = new Empleado(4, "Camila Maigua", "Asistente", 10);
        emp4.AgregarAporte(new Aporte(DateTime.Now.AddDays(-20), 30.0, "Aporte voluntario"));

        Empleado emp5 = new Empleado(5, "Luis Maigua", "Presidente", 10);
        emp5.AgregarAporte(new Aporte(DateTime.Now, 100.0, "Cuota anual"));

        asociacion.AgregarEmpleado(emp1);
        asociacion.AgregarEmpleado(emp2);
        asociacion.AgregarEmpleado(emp3);
        asociacion.AgregarEmpleado(emp4);
        asociacion.AgregarEmpleado(emp5);

        // Mostrar todos los aportes
        asociacion.MostrarReporteGeneral();

        // Búsqueda segura por ID
        Console.WriteLine("\n--- Búsqueda de empleado por ID ---");
        Empleado? buscado = asociacion.BuscarEmpleadoPorId(2);

        if (buscado != null)
        {
            Console.WriteLine($"Empleado encontrado: {buscado.Nombre}, total aportes: ${buscado.CalcularTotalAportes():F2}");
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }
}