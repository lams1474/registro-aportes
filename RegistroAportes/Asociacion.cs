public class Asociacion
{
    public Empleado[] Empleados;
    public int CantidadEmpleados;

    public Asociacion(int capacidad)
    {
        Empleados = new Empleado[capacidad];
        CantidadEmpleados = 0;
    }

    public void AgregarEmpleado(Empleado emp)
    {
        if (CantidadEmpleados < Empleados.Length)
        {
            Empleados[CantidadEmpleados] = emp;
            CantidadEmpleados++;
        }
        else
        {
            Console.WriteLine("No se puede agregar más empleados. Límite alcanzado.");
        }
    }

    public Empleado? BuscarEmpleadoPorId(int id)
    {
        for (int i = 0; i < CantidadEmpleados; i++)
        {
            if (Empleados[i].Id == id)
            {
                return Empleados[i];
            }
        }
        return null;
    }

    public void MostrarReporteGeneral()
    {
        Console.WriteLine("\n--- Reporte General de Aportes ---\n");
        for (int i = 0; i < CantidadEmpleados; i++)
        {
            Empleado emp = Empleados[i];
            Console.WriteLine($"ID: {emp.Id} | Nombre: {emp.Nombre} | Cargo: {emp.Cargo} | Total aportes: ${emp.CalcularTotalAportes():F2}");
        }
    }
}