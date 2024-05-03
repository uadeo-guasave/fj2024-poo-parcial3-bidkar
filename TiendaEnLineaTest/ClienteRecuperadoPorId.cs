namespace TiendaEnLineaTest;

public class ClienteRecuperadoPorId
{
    [Test]
    public void RecuperarTest()
    {
        var cliente = new Cliente().Recuperar(1);
    }
}
