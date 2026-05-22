using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    List<Alumno> Alumnos = new List<Alumno>();
    public void agregarAlumno(Alumno alumno)
    {
        Alumnos.Add(alumno);
    }
    public List<Alumno> retornarListaAlumnos()
    {
        return Alumnos;
    }

    public Alumno buscarAlumnoNombre(string nombre)
    {
        return Alumnos.Find(pedro => pedro.Nombre == nombre);
    }

    public void eliminarAlumno(Alumno alumno)
    {
        Alumnos.Remove(alumno);
    }

    public void eliminarAlumnoPorPoslista(int posicion)
    {
        eliminarAlumno(Alumnos[posicion]);
    }
}
