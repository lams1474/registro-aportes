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

        Empleado emp6 = new Empleado(6, "Javier Rodriguez", "Socio", 10);
        emp6.AgregarAporte(new Aporte(DateTime.Now.AddDays(-5), 20.0, "Aporte voluntario"));

        Empleado emp7 = new Empleado(7, "Luis Tapia", "Socio", 10);
        emp7.AgregarAporte(new Aporte(DateTime.Now, 100.0, "Cuota anual"));

        Empleado emp8 = new Empleado(8, "Javier Maigua", "Socio", 10);
        emp8.AgregarAporte(new Aporte(DateTime.Now.AddDays(-10), 20.0, "Aporte voluntario"));

        Empleado emp9 = new Empleado(9, "Luis Maigua", "Socio", 10);
        emp9.AgregarAporte(new Aporte(DateTime.Now, 90.0, "Cuota anual"));

        Empleado emp10 = new Empleado(10, "Miguel Velez", "Socio", 10);
        emp10.AgregarAporte(new Aporte(DateTime.Now.AddDays(-5), 40.0, "Aporte voluntario"));

        Empleado emp11 = new Empleado(11, "Teresa Jacome", "Socio", 10);
        emp11.AgregarAporte(new Aporte(DateTime.Now, 80.0, "Cuota anual"));

        Empleado emp12 = new Empleado(12, "Maria Suntasig", "Socio", 10);
        emp12.AgregarAporte(new Aporte(DateTime.Now.AddDays(-5), 30.0, "Aporte voluntario"));

        Empleado emp13 = new Empleado(13, "Juan Topa", "Socio", 10);
        emp13.AgregarAporte(new Aporte(DateTime.Now, 70.0, "Cuota anual"));

        Empleado emp14 = new Empleado(14, "Daniel Flores", "Socio", 10);
        emp14.AgregarAporte(new Aporte(DateTime.Now.AddDays(-10), 50.0, "Aporte voluntario"));
        
        asociacion.AgregarEmpleado(emp1);
        asociacion.AgregarEmpleado(emp2);
        asociacion.AgregarEmpleado(emp3);
        asociacion.AgregarEmpleado(emp4);
        asociacion.AgregarEmpleado(emp5);
        asociacion.AgregarEmpleado(emp6);
        asociacion.AgregarEmpleado(emp7);
        asociacion.AgregarEmpleado(emp8);
        asociacion.AgregarEmpleado(emp9);
        asociacion.AgregarEmpleado(emp10);
        asociacion.AgregarEmpleado(emp11);
        asociacion.AgregarEmpleado(emp12);
        asociacion.AgregarEmpleado(emp13);
        asociacion.AgregarEmpleado(emp14);
        

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