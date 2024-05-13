namespace TiendaEnLinea;

public class Producto : IABCable<Producto>
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Existencia { get; set; }

    public static Producto Recuperar(int id)
    {
        var producto = new Producto();

        if (id == 1)
        {
            producto.Id = 1;
            producto.Nombre = "Perfume Imari";
            producto.Descripcion = "Loción de larga duración ...";
            producto.Precio = 1499.99m;
            producto.Existencia = 10;
        }

        return producto;
        // realizar una prueba unitaria para validar si dos
        // objetos de tipo Producto son iguales
        // anula y reescribe los métodos GetHashCode y Equals
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
