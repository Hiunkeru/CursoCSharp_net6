using CursoCSharp_02_introduccion_consultas_linq_net6;
using CursoCSharp_05_clausula_join_net6;

List<Libro> libros = Libro.GetLibros();
List<LibroStats> librosStats = LibroStats.GetLibrosStats();

var TitulosLibros = from l in libros
                    join s in librosStats on l.ISBN equals s.ISBN
                    let ganancias = (l.Precio * s.Ventas)
                    select new
                    {
                        TituloSeleccionado = l.Titulo,
                        Ganancias = ganancias
                    };

foreach (var item in TitulosLibros)
{
    Console.WriteLine($"Titulo: {item.TituloSeleccionado} Ganancias: {item.Ganancias}");
}

Console.ReadKey();
