namespace TiendaEnLinea;

public class Cliente
{
    public static int Creados { get; private set; } = 0;
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Domicilio { get; set; }
    public string Telefono { get; set; }

    public Cliente()
    {
        Cliente.Creados++;
    }

    public bool Guardar()
    {
        return Validar();
    }

    public bool Validar()
    {
        var resultado = true;
        if (Id == 0) resultado = false;
        if (String.IsNullOrEmpty(Nombre)) resultado = false;
        if (String.IsNullOrEmpty(Apellidos)) resultado = false;
        if (String.IsNullOrEmpty(Domicilio)) resultado = false;
        if (String.IsNullOrEmpty(Telefono)) resultado = false;

        return resultado;
    }

    public static Cliente Recuperar(int id)
    {
        var cliente = new Cliente();

        if (id == 1)
        {
            cliente.Id = 1;
            cliente.Nombre = "Joel";
            cliente.Apellidos = "Vega";
            cliente.Domicilio = "Guasave";
            cliente.Telefono = "6870000000";
        }

        return cliente;
    }
}
