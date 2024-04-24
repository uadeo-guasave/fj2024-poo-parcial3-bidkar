namespace Metodos;

public class Alumno : IImprimible
{
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DateOnly FechaDeNacimiento { get; set; }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Nombres, Apellidos);
    }

    public override bool Equals(object? obj)
    {
        var alumno = obj as Alumno;
        return alumno != null &&
               Id == alumno.Id &&
               Nombres == alumno.Nombres &&
               Apellidos == alumno.Apellidos;
    }

    public override string ToString()
    {
        return $"Id:{Id}, Nombre:{NombreCompleto()}, Nacido en: {FechaDeNacimiento}";
    }

    public string NombreCompleto()
    {
        return $"{Nombres} {Apellidos}";
    }

    public string NombreCompleto(bool primeroApellidos)
    {
        if (primeroApellidos)
            return $"{Apellidos} {Nombres}";
        else
            return NombreCompleto();
    }

    public string NombreCompleto(bool primeroApellidos, bool enMayusculas)
    {
        if (primeroApellidos && enMayusculas)
            return NombreCompleto(true).ToUpper();
        else if (primeroApellidos && !enMayusculas)
            return NombreCompleto(true).ToLower();
        else if (!primeroApellidos && enMayusculas)
            return NombreCompleto().ToUpper();
        else
            return NombreCompleto().ToLower();
    }

    public void Imprimir()
    {
        Console.WriteLine(this.ToString());
    }
}
