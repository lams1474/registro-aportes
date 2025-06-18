public class Empleado
{
    public int Id;
    public string Nombre;
    public string Cargo;
    public Aporte[] Aportes;
    public int CantidadAportes;

    public Empleado(int id, string nombre, string cargo, int capacidadAportes)
    {
        Id = id;
        Nombre = nombre;
        Cargo = cargo;
        Aportes = new Aporte[capacidadAportes];
        CantidadAportes = 0;
    }

    public void AgregarAporte(Aporte aporte)
    {
        if (CantidadAportes < Aportes.Length)
        {
            Aportes[CantidadAportes] = aporte;
            CantidadAportes++;
        }
        else
        {
            Console.WriteLine($"No se puede agregar más aportes para {Nombre}. Límite alcanzado.");
        }
    }

    public double CalcularTotalAportes()
    {
        double total = 0;
        for (int i = 0; i < CantidadAportes; i++)
        {
            total += Aportes[i].Monto;
        }
        return total;
    }
}
