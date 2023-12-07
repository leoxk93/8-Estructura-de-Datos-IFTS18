
using System.Runtime.ConstrainedExecution;
using System;

class Program
{
    static void Main()
    {
        Ejercicio1();
        Separador();
        Ejercicio2();
        Separador();
        Ejercicio3();
        Separador();
        Ejercicio4();
        Separador();
        Ejercicio5();
        Separador();
        Ejercicio6();
        Separador();
        Ejercicio7();
        Separador();
        Ejercicio8();
        Separador();
        Ejercicio9();
        Separador();
        Ejercicio10();
        Separador();
        Ejercicio11();
        Separador();
        Ejercicio12();
        Separador();
        Ejercicio13();
        Separador();
        Ejercicio14();
        Separador();
        Ejercicio15();
        Separador();
        Ejercicio16();
    }

    static void Separador()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }

    //Ejer 1: Escribir un programa que diga el resultado de sumar 200 y 56.
    static void Ejercicio1()
    {
        int numero1 = 200;
        int numero2 = 56;

        int resultado = numero1 + numero2;

        Console.WriteLine("El resultado de sumar 200 y 56 es: " + resultado);
    }

    //Ejer 2: Hacer un programa que calcule el producto de los números 13 y 12.
    static void Ejercicio2()
    {
        int numero1 = 13;
        int numero2 = 12;

        int resultado = numero1 * numero2;

        Console.WriteLine("El producto de 13 y 12 es: " + resultado);
    }

    //Ejer 3: Desarrollar un programa que calcule la diferencia (resta) entre 321 y 213
    static void Ejercicio3()
    {
        int numero1 = 321;
        int numero2 = 213;

        int resultado = numero1 - numero2;

        Console.WriteLine("La diferencia entre 321 y 213 es: " + resultado);
    }

    //Ejer 4: Calcular el resultado de (20+5) % 6 mostrando el resultado en la consola.
    static void Ejercicio4()
    {
        int resultado = (20 + 5) % 6;

        Console.WriteLine("El resultado de (20+5) % 6 es: " + resultado);
    }

    //Ejer 5: Crear un programa que calcule el producto de los números 12 y 102, usando variables.
    static void Ejercicio5()
    {
        int numero1 = 12;
        int numero2 = 102;

        int resultado = numero1 * numero2;

        Console.WriteLine("El producto de 12 y 102 es: " + resultado);
    }

    //Ejer 6: Crear un programa que calcule la suma de 200 y 1111, usando variables.
    static void Ejercicio6()
    {
        int numero1 = 200;
        int numero2 = 1111;

        int resultado = numero1 + numero2;

        Console.WriteLine("La suma de 200 y 1111 es: " + resultado);
    }

    //Ejer 7: Crea un programa que calcule el producto de los números 10 y 25, usando variables llamadas "numero1" y "numero2".
    static void Ejercicio7()
    {
        int numero1 = 10;
        int numero2 = 25;

        int resultado = numero1 * numero2;

        Console.WriteLine("El producto de 10 y 25 es: " + resultado);
    }

    //Ejer 8: Crear un programa que calcule el producto de dos números n y m.
    static void Ejercicio8()
    {
        Console.WriteLine("Ingresa dos numeros n y m para multiplicarlos");
        Console.Write("Ingresa el valor de n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el valor de m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        int resultado = n * m;

        Console.WriteLine("El producto de " + n + " y " + m + " es: " + resultado);
    }

    //Ejer 9: Escribir un programa que muestre el estado de un alumno segun su nota.
    //Ejemp: 1 - 3 reprobado, 4-6 debe rendir final, 7-10 promocionado. Probar para los tres casos usando If-Else
    static void Ejercicio9()
    {
        Console.WriteLine("Ingresa la nota del alumno para saber su estado");
        Console.Write("Ingresa la nota del alumno: ");
        int nota = Convert.ToInt32(Console.ReadLine());

        if (nota >= 1 && nota <= 3)
        {
            Console.WriteLine("Reprobado");
        }
        else if (nota >= 4 && nota <= 6)
        {
            Console.WriteLine("Debe rendir final");
        }
        else if (nota >= 7 && nota <= 10)
        {
            Console.WriteLine("Promocionado");
        }
        else
        {
            Console.WriteLine("Nota no válida. Ingresa un número del 1 al 10.");
        }
    }

    //Ejer10: Crea un programa que pida al usuario un número entero y diga si es par (pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero: if (x % 2 == 0) ...).
    static void Ejercicio10()
    {
        Console.WriteLine("Ingresa un numero para saber si par o impar");
        Console.Write("Ingresa un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }

    //Ejer11: Crea un programa que pida al usuario dos números enteros y diga cuál es el mayor de ellos.
    static void Ejercicio11()
    {
        Console.WriteLine("Ingresa dos números enteros y diga cuál es el mayor de ellos");
        Console.Write("Ingresa el primer número entero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número entero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("El primer número es mayor.");
        }
        else if (numero1 < numero2)
        {
            Console.WriteLine("El segundo número es mayor.");
        }
        else
        {
            Console.WriteLine("Ambos números son iguales.");
        }
    }

    //Ejer12: Crea un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrará el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir entre cero".
    static void Ejercicio12()
    {
        Console.WriteLine("Ingresa dos números enteros para dividir el primero por el segundo");
        Console.Write("Ingresa el primer número entero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número entero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero2 != 0)
        {
            double resultado = (double)numero1 / numero2;
            Console.WriteLine("El resultado de la división es: " + resultado);
        }
        else
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
    }

    //Ejer13: Crea un programa que pida un número del 1 al 5 al usuario, y escriba el nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el programa escribirá "uno").
    static void Ejercicio13()
    {
        Console.Write("Ingresa un número del 1 al 5 y se escribira el nombre de ese número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Mostrar el nombre del número usando switch
        switch (numero)
        {
            case 1:
                Console.WriteLine("Uno");
                break;
            case 2:
                Console.WriteLine("Dos");
                break;
            case 3:
                Console.WriteLine("Tres");
                break;
            case 4:
                Console.WriteLine("Cuatro");
                break;
            case 5:
                Console.WriteLine("Cinco");
                break;
            default:
                Console.WriteLine("Número no válido.");
                break;
        }
    }

    //Ejer14: Crea un programa que escriba en pantalla los números del 1 al 10, usando "while".
    static void Ejercicio14()
    {
        int numero = 1;

        while (numero <= 10)
        {
            Console.WriteLine(numero);
            numero++;
        }
    }

    //Ejer15: Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".
    static void Ejercicio15()
    {
       int numero = 1;
        do
        {
            Console.WriteLine(numero);
            numero++;
        } while (numero < 10);
    }

    //Ejer16: Crea un programa que muestre los números del 10 al 20, ambos incluidos, usando "for"
    static void Ejercicio16()
    {
         for (int numero = 10; numero <= 20; numero++)
        {
            Console.WriteLine(numero);
        }
    }
}
