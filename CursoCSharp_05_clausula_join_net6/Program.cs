using CursoCSharp_02_introduccion_consultas_linq_net6;
using CursoCSharp_05_clausula_join_net6;

List<Libro> libros = Libro.GetLibros();
List<LibroStats> librosStats = LibroStats.GetLibrosStats();

var TitulosLibros = from l in libros
                    join s in librosStats on l.ISBN equals s.ISBN
                    select new
                    {
                        TituloSeleccionado = l.Titulo,
                        PaginasLibro = s.Paginas
                    };

foreach (var item in TitulosLibros)
{
    Console.WriteLine($"Titulo: {item.TituloSeleccionado} Paginas: {item.PaginasLibro}");
}

Console.ReadKey();