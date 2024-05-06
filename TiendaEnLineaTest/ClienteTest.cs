using TiendaEnLinea;

namespace TiendaEnLineaTest;

public class ClienteTest
{
    [Test]
    public void ClienteValido()
    {
        var cliente = new Cliente();
        cliente.Id = 1;

        Assert.That(cliente.Validar, Is.False);
    }

    [Test]
    public void RecuperarClientePorId()
    {
        // setup
        var cliente1 = Cliente.Recuperar(1);

        // actual
        var cliente2 = new Cliente();
        cliente2.Id = 1;
        cliente2.Nombre = "Joel";
        cliente2.Apellidos = "Vega";
        cliente2.Domicilio = "Guasave";
        cliente2.Telefono = "6870000000";

        // assert
        Assert.That(cliente1.Id, Is.EqualTo(cliente2.Id));
        Assert.That(cliente1.Nombre, Is.EqualTo(cliente2.Nombre));
        Assert.That(cliente1.Apellidos, Is.EqualTo(cliente2.Apellidos));
        Assert.That(cliente1.Domicilio, Is.EqualTo(cliente2.Domicilio));
        Assert.That(cliente1.Telefono, Is.EqualTo(cliente2.Telefono));
    }
}
