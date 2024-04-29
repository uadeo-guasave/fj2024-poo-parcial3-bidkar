namespace Metodos;

public class Escuela : IImprimible
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public void Imprimir()
    {
        Console.WriteLine("Soy una escuela");
    }
}
