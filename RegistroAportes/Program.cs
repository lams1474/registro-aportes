class Program
{
    static void Main(string[] args)
    {
        Asociacion asociacion = new Asociacion(20);

        Empleado emp1 = new Empleado(1, "Ana Martínez", "Secretaria", 10);
        emp1.AgregarAporte(new Aporte(DateTime.Now, 50.0, "Cuota mensual"));
        emp1.AgregarAporte(new Aporte(DateTime.Now.AddDays(-10), 20.0, "Donación"));

        Empleado emp2 = new Empleado(2, "Carlos Díaz", "Técnico", 10);
        emp2.AgregarAporte(new Aporte(DateTime.Now, 60.0, "Cuota mensual"));

        Empleado emp3 = new Empleado(3, "Elena Rivas", "Contadora", 10);
        emp3.AgregarAporte(new Aporte(DateTime.Now.AddDays(-5), 75.5, "Aporte extraordinario"));

        asociacion.AgregarEmpleado(emp1);
        asociacion.AgregarEmpleado(emp2);
        asociacion.AgregarEmpleado(emp3);

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
