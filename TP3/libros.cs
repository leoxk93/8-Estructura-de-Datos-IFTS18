using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

//Ejer3: Crear una clase "Libro", que contendrá atributos "autor", "titulo", "ubicación" (todos ellos strings y privados) y métodos Get y Set adecuados
//para leer su valor y cambiarlo. Preparar un Main que cree un objeto de la clase Libro, dé valores a sus tres atributos y luego los muestre por consola.

public class Libro
{
    private string autor = "";
    private string titulo = "";
    private string ubicacion = "";

    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }

    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }

    public string Ubicacion
    {
        get { return ubicacion; }
        set { ubicacion = value; }
    }
}

internal class Program3
{
    static void Main(string[] args)
    {
        Libro libro = new Libro();

        libro.Autor = "Borges";
        libro.Titulo = "Aleft";
        libro.Ubicacion = "Biblioteca";

        Console.WriteLine("Autor: " + libro.Autor);
        Console.WriteLine("Título: " + libro.Titulo);
        Console.WriteLine("Ubicación: " + libro.Ubicacion);
    }
}
