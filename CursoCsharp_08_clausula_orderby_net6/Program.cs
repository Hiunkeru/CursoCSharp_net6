using CursoCSharp_02_introduccion_consultas_linq_net6;
using CursoCSharp_05_clausula_join_net6;

List<Libro> libros = Libro.GetLibros();
List<LibroStats> librosStats = LibroStats.GetLibrosStats();

var TitulosLibros = from l in libros
                    join s in librosStats on l.ISBN equals s.ISBN
                    orderby l.FechaSalida, s.Paginas
                    select new
                    {
                        Nombre = l.Titulo,
                        Fecha = l.FechaSalida,
                        Pag = s.Paginas
                    };

var TitulosLibros2 = from l in libros
                     join s in librosStats on l.ISBN equals s.ISBN
                     orderby l.FechaSalida, s.Paginas descending
                     select new
                     {
                         Nombre = l.Titulo,
                         Fecha = l.FechaSalida,
                         Pag = s.Paginas
                     };

var TitulosLibros3 = from l in libros
                     join s in librosStats on l.ISBN equals s.ISBN
                     orderby l.FechaSalida descending, s.Paginas
                     select new
                     {
                         Nombre = l.Titulo,
                         Fecha = l.FechaSalida,
                         Pag = s.Paginas
                     };


Console.ReadKey();
