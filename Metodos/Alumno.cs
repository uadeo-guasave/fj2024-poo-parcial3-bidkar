namespace Metodos;

public class Alumno
{
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    public DateOnly FechaDeNacimiento { get; set; }

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
}
