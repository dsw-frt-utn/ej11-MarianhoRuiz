using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    Dictionary<int, Alumno> diccionarioAlumnos = new(); 

    public void agregarAlumno(Alumno alumno)
    {
        diccionarioAlumnos.Add(alumno.Id, alumno);
    }

    public Alumno buscarAlumno(int legajo)
    {
       return diccionarioAlumnos[legajo];
    }

    public Dictionary<int, Alumno> retornarDiccionario()
    {
        return diccionarioAlumnos;
    }
    
    public void eliminarAlumno(int legajo)
    {
        diccionarioAlumnos.Remove(legajo);
    }

}
