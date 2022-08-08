using CursoCSharp_02_introduccion_consultas_linq_net6;

List<Libro> libros = Libro.GetLibros();

var titulosLibros =
    from l in libros
    select l.Titulo;

foreach (var titulo in titulosLibros)
{
    Console.WriteLine(titulo);
}

Console.ReadKey();