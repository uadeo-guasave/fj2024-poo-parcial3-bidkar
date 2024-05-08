using TiendaEnLinea;

namespace TiendaEnLineaTest;

public class ClienteTest
{
    [Test]
    public void ContarClientes()
    {
        var cliente1 = new Cliente();
        var cliente2 = new Cliente();
        var cliente3 = new Cliente();

        var esperado = 3;

        Assert.That(Cliente.Creados, Is.EqualTo(esperado));
    }

    [Test]
    public void GuardarClienteNoValido()
    {
        var cliente = new Cliente();

        var sePudoGuardar = cliente.Guardar();

        Assert.That(sePudoGuardar, Is.False);
    }

    [Test]
    public void GuardarClienteValido()
    {
        var cliente = new Cliente
        {
            Id = 1,
            Nombre="Celia",
            Apellidos="Payan",
            Domicilio="Conocido",
            Telefono="687000000"
        };

        var sePudoGuardar = cliente.Guardar();

        Assert.That(sePudoGuardar, Is.True);
    }

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
