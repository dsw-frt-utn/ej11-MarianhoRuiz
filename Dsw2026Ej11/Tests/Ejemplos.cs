using Dsw2026Ej11.Domain;
using Dsw2026Ej11.Collections;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var alu1= new Alumno(1, "Juan", 7.5);
        var alu2= new Alumno(2, "Maria", 8.0);
        var alu3= new Alumno(3, "Pedro", 6.5);
        
        var casoList = new CasoList();
        casoList.agregarAlumno(alu1);
        casoList.agregarAlumno(alu2);
        casoList.agregarAlumno(alu3);

        foreach (var Alumno in casoList.retornarListaAlumnos())
        {
            Console.WriteLine($"ID: {Alumno.Id}, Nombre: {Alumno.Nombre}, Promedio: {Alumno.Promedio}");
        }
        Console.WriteLine("");
        Console.WriteLine("Lista por consola completada, siguiente buscar por nombre un alumno que exista y mostrar por consola");
        EsperarTecla();
        Console.Clear();
        Console.WriteLine("Busqueda del nombre Juan:");
        Console.WriteLine("");

        var aux = casoList.buscarAlumnoNombre("Juan");
        Console.WriteLine($"El alumno es {aux.Nombre}, tiene el ID : {aux.Id} y su promedio es {aux.Promedio}");
        Console.WriteLine("");
        Console.WriteLine("Listo");
        EsperarTecla();
        Console.Clear();


        Console.WriteLine("Busqueda del nombre Roberto:");
        Console.WriteLine("");

        try { var aux1 = casoList.buscarAlumnoNombre("Roberto") ?? throw new Exception(); }
        catch (Exception ex)
        {
            Console.WriteLine("Nombre no encontrado en la lista // NO EXISTE ");
        }

        Console.WriteLine("");
        Console.WriteLine("Listo");
        EsperarTecla();

        Console.Clear();
        Console.WriteLine("Borrado de alumno");
        Console.WriteLine("");
        Console.WriteLine("Lista actual:");

        foreach (var Alumno in casoList.retornarListaAlumnos())
          {
            Console.WriteLine($"ID: {Alumno.Id}, Nombre: {Alumno.Nombre}, Promedio: {Alumno.Promedio}");
          }
        Console.WriteLine("");
        Console.WriteLine("Se procede a borrar el alumno juan");
        Console.WriteLine("");
        casoList.eliminarAlumno( casoList.buscarAlumnoNombre("Juan") );
        Console.WriteLine("Nueva lista actual");
            foreach (var Alumno in casoList.retornarListaAlumnos())
              {
                Console.WriteLine($"ID: {Alumno.Id}, Nombre: {Alumno.Nombre}, Promedio: {Alumno.Promedio}");
              }
        Console.WriteLine("");
        Console.WriteLine("Listo");
        EsperarTecla();
        Console.Clear();
        Console.WriteLine("Ultimo caso: se elimina el primero de la lista");

        Console.WriteLine("Lista actual:");

        foreach (var Alumno in casoList.retornarListaAlumnos())
        {
            Console.WriteLine($"ID: {Alumno.Id}, Nombre: {Alumno.Nombre}, Promedio: {Alumno.Promedio}");
        }
        Console.WriteLine("");
        Console.WriteLine("Se borra el primero");
        Console.WriteLine("");
        casoList.eliminarAlumnoPorPoslista(1);

        Console.WriteLine("Lista:");

        foreach (var Alumno in casoList.retornarListaAlumnos())
        {
            Console.WriteLine($"ID: {Alumno.Id}, Nombre: {Alumno.Nombre}, Promedio: {Alumno.Promedio}");
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var alu1 = new Alumno(1, "Juan", 7.5);
        var alu2 = new Alumno(2, "Maria", 8.0);
        var alu3 = new Alumno(3, "Pedro", 6.5);

        var diccionario = new CasoDictionary();
        diccionario.agregarAlumno(alu1);
        diccionario.agregarAlumno(alu2);
        diccionario.agregarAlumno(alu3);

        foreach (var alumno in diccionario.retornarDiccionario())
        {
            Console.WriteLine($"Alumno: {alumno.ToString()}");
        }
        Console.WriteLine("");
        Console.WriteLine("Listo");
        EsperarTecla();
        // ----------------------------------------------------------------
        Console.Clear();
        Console.WriteLine("Buscar un alumno por clave y mostrar por consola");
        Console.WriteLine($"El alumno es { diccionario.buscarAlumno(2).Nombre }");
        EsperarTecla();
        // ------------------------------------------------------------------
        Console.Clear();
        Console.WriteLine("Buscar un alumno por clave y mostrar por consola que no existe");
        try { var aux = diccionario.buscarAlumno(5) ?? throw new Exception(); }
        catch (Exception ex)
        {
            Console.WriteLine("Alumno no existe");
        }
        // ----------------------------------------------------------------------
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Eliminar alumno, maria");
        diccionario.eliminarAlumno(alu2.Id);

        foreach (var alumno in diccionario.retornarDiccionario())
        {
            Console.WriteLine($"Legajo;{alumno.Key}");
        }



    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var casoLinq = new CasoLinq();
        var libros = new List<Libro>();
        Console.WriteLine($"El primer libro es {casoLinq.obtenerPrimero()}");
        Console.WriteLine("");
        Console.WriteLine($"El ultimo libro es {casoLinq.obtenerUltimo()}");
        Console.WriteLine("");
        Console.WriteLine($"La suma de los precios es {casoLinq.sumaPrecios()}");
        Console.WriteLine("");
        Console.WriteLine($"El promedio de los precios es {casoLinq.promedioPrecios()}");
        casoLinq.GetListById(2).ForEach(libro => Console.WriteLine($"Libro con ID 2: {libro}"));
        Console.WriteLine("");
        Console.WriteLine("Mostrar libros:");
        Console.WriteLine("");
        Console.WriteLine($"Mostrar el mayor precio {casoLinq.GetMayorPrecio()}");
        Console.WriteLine("");
        Console.WriteLine($"Mostrar el menor precio {casoLinq.GetMenorPrecio()}");
        Console.WriteLine("");
        casoLinq.librosMayorPromedio().ForEach(libro => Console.WriteLine($"Libros con precio mayor al promedio: {libro}"));
        Console.WriteLine("");
        casoLinq.OrdenDescendente().ForEach(libro => Console.WriteLine($"Libros ordenados de mayor a menor precio: {libro}"));


    }
        static void EsperarTecla()
    {
        Console.WriteLine("\nPresione una tecla para continuar..");
        Console.ReadKey();
    }
}
