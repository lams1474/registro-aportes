public class Aporte
{
    public DateTime Fecha;
    public double Monto;
    public string Descripcion;

    public Aporte(DateTime fecha, double monto, string descripcion)
    {
        Fecha = fecha;
        Monto = monto;
        Descripcion = descripcion;
    }
}
