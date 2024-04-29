namespace Metodos;

public class Docente : Persona, IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Soy un(a) docente");
    }
}
