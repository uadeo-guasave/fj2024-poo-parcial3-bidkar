namespace TiendaEnLinea;

public class PedidoProducto : IABCable<PedidoProducto>
{
    public int PedidoId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioDeVenta { get; set; }

    public static PedidoProducto Recuperar(int id)
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
