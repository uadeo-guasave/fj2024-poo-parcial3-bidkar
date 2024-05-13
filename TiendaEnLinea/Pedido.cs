namespace TiendaEnLinea;

public class Pedido : IABCable<Pedido>
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public int ClienteId { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Impuestos { get; set; }
    public decimal Total { get; set; }

    public static Pedido Recuperar(int id)
    {
        throw new NotImplementedException();
    }

    public bool Guardar()
    {
        throw new NotImplementedException();
    }

    public bool Validar()
    {
        throw new NotImplementedException();
    }
}
