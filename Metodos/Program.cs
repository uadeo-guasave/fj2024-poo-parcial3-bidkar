using Metodos;

// Sobrecarga();
// Anular();
Polimorfismo();

static void Polimorfismo()
{
    var lista = new List<IImprimible>();
    var alumno = new Alumno { Nombres = "Gaddiel" };
    var docente = new Docente { Nombres = "Lidia" };
    var escuela = new Escuela { Nombre = "UAdeO" };
    lista.Add(alumno);
    lista.Add(docente);
    lista.Add(escuela);

    foreach (var item in lista)
    {
        item.Imprimir();
    }
}

static void Anular()
{
    // override es la anulación de la funcionalidad de un método
    // de acuerdo a su objeto padre
    // existen tres métodos de la clase Object padre de todos
    // los objetos, ToString() Equal() GetHashCode()
    var alumno1 = new Alumno { Id = 2, Nombres = "Roshet", Apellidos = "Medina" };
    Console.WriteLine(alumno1.ToString());

    // equals
    int a = 10;
    int b = a;
    a = 15;
    Console.WriteLine(b); // b=10

    var alumno2 = alumno1;
    alumno2.Apellidos = "Medina López";
    Console.WriteLine(alumno1.Apellidos); // Apellidos=?
    Console.WriteLine(alumno1 == alumno2); // true

    var alumno3 = new Alumno { Id = 2, Nombres = "Roshet", Apellidos = "Medina López" };
    Console.WriteLine(alumno1 == alumno3); // false

    Console.WriteLine(alumno1.GetHashCode());
    Console.WriteLine(alumno3.GetHashCode());
    Console.WriteLine(alumno1.Equals(alumno3)); // true
}

static void Sobrecarga()
{
    var alumno1 = new Alumno()
    {
        Id = 1,
        Nombres = "Juan Manuel",
        Apellidos = "Alcantar Rubio"
    };

    // imprimir el nombre completo del alumno iniciando con el nombre
    Console.WriteLine(alumno1.NombreCompleto());

    // imprimir el nombre completo del alumno iniciando por apellidos
    Console.WriteLine(alumno1.NombreCompleto(true));

    // imprimir el nombre completo del alumno iniciando con apellidos y en minusculas
    Console.WriteLine(alumno1.NombreCompleto(primeroApellidos: true, enMayusculas: false));

    // imprimir el nombre completo del alumno iniciando con apellidos y en mayusculas
    Console.WriteLine(alumno1.NombreCompleto(true, true));

    // imprimir el nombre completo del alumno iniciando con nombre y en mayusculas
    Console.WriteLine(alumno1.NombreCompleto(false, true));

    // imprimir el nombre completo del alumno iniciando con nombre y en minusculas
    Console.WriteLine(alumno1.NombreCompleto(false, false));

    // imprimir lo que salga del método ToString() del alumno
    Console.WriteLine(alumno1.ToString());
}