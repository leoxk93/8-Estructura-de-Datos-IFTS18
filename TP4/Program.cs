using System;
using System.Collections;

class Program
{
    static void Main()
    {
        EjercicioPilas1();
        Separador();
        EjercicioPilas2();
        Separador();
        EjercicioPilas3();
        Separador();
        EjercicioColas1();
        Separador();
        EjercicioColas2();
        Separador();
        EjercicioColas3();
        Separador();
        Ejercicio4();
        Separador();
    }

    static void Separador()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }



    // Ejercicio Pilas 1
    static void EjercicioPilas1()
    {
        Stack<int> pilaNumeros = new Stack<int>();

        Console.WriteLine("Por favor, introduce 10 números enteros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            pilaNumeros.Push(numero);
        }

        Console.WriteLine("\nLos números en orden inverso son:");

        while (pilaNumeros.Count > 0)
        {
            Console.WriteLine(pilaNumeros.Pop());
        }
    }

    // Ejercicio Pilas 2
    static void EjercicioPilas2()
    {
        Stack pilaPalabras = new Stack();

        Console.WriteLine("Ejercicio Pilas 2 - Ingrese 5 palabras:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Palabra {i + 1}: ");
            string palabra = Console.ReadLine();
            pilaPalabras.Push(palabra);
        }

        Console.WriteLine("\nPalabras apiladas:");

        foreach (var palabra in pilaPalabras)
        {
            Console.WriteLine(palabra);
        }

        Console.WriteLine("\nSolo la primera palabra ingresada:");
        Console.WriteLine(pilaPalabras.Pop());
    }

    // Ejercicio Pilas 3
    static void EjercicioPilas3()
    {
        Stack pilaMarcas = new Stack();

        Console.WriteLine("Ejercicio Pilas 3 - Ingrese marcas de celulares (escriba 'fin' para detenerse):");

        while (true)
        {
            Console.Write("Marca: ");
            string marca = Console.ReadLine();
            if (marca.ToLower() == "fin")
                break;
            pilaMarcas.Push(marca);
        }

        Console.Write("\nIngrese la marca a buscar: ");
        string marcaBuscada = Console.ReadLine();

        if (BuscarMarcaEnPila(pilaMarcas, marcaBuscada))
        {
            Console.WriteLine($"{marcaBuscada} está en la pila.");
        }
        else
        {
            Console.WriteLine($"{marcaBuscada} no está en la pila.");
        }

        // Vaciar la pila
        pilaMarcas.Clear();
    }

    static bool BuscarMarcaEnPila(Stack pila, string marca)
    {
        return pila.Contains(marca);
    }

    // Ejercicio Colas 1
    static void EjercicioColas1()
    {
        Queue colaNumeros = new Queue();

        Console.WriteLine("Ejercicio Colas 1 - Ingrese 5 números reales de doble precisión:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            colaNumeros.Enqueue(numero);
        }

        Console.WriteLine("\nNúmeros en la cola:");

        while (colaNumeros.Count > 0)
        {
            Console.WriteLine(colaNumeros.Dequeue());
        }
    }

    // Ejercicio Colas 2
    static void EjercicioColas2()
    {
        Queue colaFrases = new Queue();

        Console.WriteLine("Ejercicio Colas 2 - Ingrese frases (deje vacío para detenerse):");

        while (true)
        {
            Console.Write("Frase: ");
            string frase = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(frase))
                break;
            colaFrases.Enqueue(frase);
        }

        Console.WriteLine("\nFrases en la cola:");

        foreach (var frase in colaFrases)
        {
            Console.WriteLine(frase);
        }
    }


    // Ejercicio Colas 3
    static void EjercicioColas3()
    {
        Queue colaElementos = new Queue();

        Console.WriteLine("Ejercicio Colas 3 - Operaciones con Cola:");
        Console.WriteLine("1. Agregar elemento");
        Console.WriteLine("2. Quitar elemento");
        Console.WriteLine("3. Mostrar elementos");
        Console.WriteLine("4. Salir");

        while (true)
        {
            Console.Write("Seleccione una opción (1-4): ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el elemento a agregar: ");
                    string elementoAgregar = Console.ReadLine();
                    colaElementos.Enqueue(elementoAgregar);
                    break;

                case 2:
                    if (colaElementos.Count > 0)
                    {
                        Console.WriteLine($"Elemento eliminado: {colaElementos.Dequeue()}");
                    }
                    else
                    {
                        Console.WriteLine("La cola está vacía.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Elementos en la cola:");
                    foreach (var elemento in colaElementos)
                    {
                        Console.WriteLine(elemento);
                    }
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        }
    }

    // Ejercicio 4
    interface ITema
    {
        void MostrarInformacion();
        void RealizarAccion();
    }

    // Clase 1 implementando la interfaz
    class Tema1 : ITema
    {
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del Tema 1");
        }

        public void RealizarAccion()
        {
            Console.WriteLine("Acción del Tema 1");
        }
    }

    // Clase 2 implementando la interfaz
    class Tema2 : ITema
    {
        public void MostrarInformacion()
        {
            Console.WriteLine("Información del Tema 2");
        }

        public void RealizarAccion()
        {
            Console.WriteLine("Acción del Tema 2");
        }
    }

    static void Ejercicio4()
    {
        // Ejemplo de uso
        ITema tema1 = new Tema1();
        ITema tema2 = new Tema2();

        tema1.MostrarInformacion();
        tema1.RealizarAccion();

        tema2.MostrarInformacion();
        tema2.RealizarAccion();
    }
}

