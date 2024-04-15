using Metodos;

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