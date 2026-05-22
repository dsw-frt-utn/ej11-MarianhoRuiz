using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    List<Libro> libros = Libro.CrearLista();
    
    public string obtenerPrimero()
    {
       return libros.FirstOrDefault().ToString();
    }

    public Libro obtenerUltimo()
    {
        return libros.LastOrDefault();
    }

    public decimal sumaPrecios()
    {
        return libros.Sum(a => a.Precio);
    }

    public decimal promedioPrecios()
    {
        return libros.Average(a => a.Precio);
    }

    public List<Libro> GetListById(int id)
    {
        return libros.FindAll(a => a.Id > id);
    }

    public List<string> MostrarLibros()
    {
        return libros.Select(libro => $"{libro.Titulo} - {libro.Precio:C}").ToList();
    }

    public decimal GetMayorPrecio()
    {
        return libros.Max(libro => libro.Precio);
    }

    public decimal GetMenorPrecio()
    {
        return libros.Min(libro => libro.Precio);
    }

    public List<Libro> librosMayorPromedio()
    {
        return libros.FindAll(libro => libro.Precio > promedioPrecios());
    }
    
    public List<Libro> OrdenDescendente()
    {
        return libros.OrderByDescending(libro => libro.Precio).ToList();
    }

    



}
