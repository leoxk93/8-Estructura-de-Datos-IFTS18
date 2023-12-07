using System.Runtime.ConstrainedExecution;
using System;
using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ejer1: Crear una clase Auto que tenga atributos (características) [string] marcaModelo, [string] patente, etc, y acciones(métodos no estáticos en los 3
//ejercicios), avanzar(), detener(), etc.Se deberá crear uno o varios objetos
//instancias de la clase Auto, mostrar las características y acciones por consola.
public class Auto
{
    private string? marcaModelo;
    private string? patente;

    public string MarcaModelo
    {
        get => marcaModelo;
        set
        {
            if (!string.IsNullOrEmpty(value))
                marcaModelo = value;
        }
    }

    public string? Patente
    {
        get { return patente; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                patente = value;
        }
    }

    public Auto(string marcaModelo, string patente)
    {
        MarcaModelo = marcaModelo;
        Patente = patente;
    }

    public void Avanzar()
    {
        if (marcaModelo != null)
        {
            Console.WriteLine($"El auto {marcaModelo} está avanzando.");
        }
        else
        {
            Console.WriteLine("El auto no tiene marca/modelo definido.");
        }
    }

    public void Detener()
    {
        if (marcaModelo != null)
        {
            Console.WriteLine($"El auto {marcaModelo} se ha detenido.");
        }
        else
        {
            Console.WriteLine("El auto no tiene marca/modelo definido.");
        }
    }


    class Program
    {
        static void Main()
        {
            Auto miAuto = new Auto("Renault Sandero", "AB 068 JT");
            Console.WriteLine($"Marca y Modelo: {miAuto.MarcaModelo}");
            Console.WriteLine($"Patente: {miAuto.Patente}");
            miAuto.Avanzar();
            miAuto.Detener();

            Auto otroAuto = new Auto("Ford Eco Sport", "ERN 777");
            Console.WriteLine($"Marca y Modelo: {otroAuto.MarcaModelo}");
            Console.WriteLine($"Patente: {otroAuto.Patente}");
            otroAuto.Avanzar();
            otroAuto.Detener();
        }
    }
}






