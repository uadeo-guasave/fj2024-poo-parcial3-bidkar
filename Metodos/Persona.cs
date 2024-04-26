namespace Metodos;
// las clases abstractas solo se utilizan para
// que otras hereden de estas
// no se pueden crear instancias (objetos)
// a partir de las mismas
// var persona1 = new Persona(); ERROR

public abstract class Persona
{
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
}
