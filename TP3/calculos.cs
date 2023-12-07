using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejer2: Crear una clase Cálculos(en el archivo nuevo calculos.cs) con métodos
//para sumar, restar, multiplicar y dividir dos o más números enteros.Se deberá
//interactuar con el usuario mediante consola(ReadLine()) para ingresar datos
//(guardándolos en variables públicas) y mostrar los resultados de las operaciones por consola.Instanciar la clase mediante objetos.

public class Calculos
{
    public int Num1 { get; set; }
    public int Num2 { get; set; }

    public Calculos(int num1, int num2)
    {
        Num1 = num1;
        Num2 = num2;
    }

    public int Sumar()
    {
        return Num1 + Num2;
    }

    public int Restar()
    {
        return Num1 - Num2;
    }

    public int Multiplicar()
    {
        return Num1 * Num2;
    }

    public double Dividir()
    {
        if (Num2 != 0)
            return (double)Num1 / Num2;
        else
            throw new DivideByZeroException("No se puede dividir por cero.");
    }
}

internal class Program2
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Calculos calculos = new Calculos(num1, num2);

        Console.WriteLine("La suma es: " + calculos.Sumar());
        Console.WriteLine("La resta es: " + calculos.Restar());
        Console.WriteLine("La multiplicación es: " + calculos.Multiplicar());

        try
        {
            Console.WriteLine("La división es: " + calculos.Dividir());
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
