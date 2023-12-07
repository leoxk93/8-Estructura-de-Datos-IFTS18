
using System.Runtime.ConstrainedExecution;
using System;
using System.Net;

class Program
{
    static Random random = new Random();
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
    }

    static void Separador()
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }

    //Guia 2: Arrays y Metodos en C#

    //1- Pedir al usuario que ingrese tres datos del tipo string usando ReadLine() y que estos sean guardados en un array.
    //Luego será mostrado por consola el array en el orden que fueron ingresados estos datos y al revés.

    static void Ejercicio1()
    {
        string[] datos = new string[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingresa el dato #{i + 1}: ");
            datos[i] = Console.ReadLine();
        }

        Console.WriteLine("\nDatos ingresados en el orden original:");
        foreach (string dato in datos)
        {
            Console.WriteLine(dato);
        }

        Console.WriteLine("\nDatos ingresados al revés:");
        for (int i = 2; i >= 0; i--)
        {
            Console.WriteLine(datos[i]);
        }
    }


    //2 - Crear un programa que pida al usuario 5 números enteros y los guarde en un array.
    //Luego deberá calcular su promedio usando un ciclo for o while y mostrar por consola dicho promedio.

    static void Ejercicio2()
    {
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingresa el número #{i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        int suma = 0;
        foreach (int numero in numeros)
        {
            suma += numero;
        }
        double promedio = (double)suma / numeros.Length;

        Console.WriteLine("\nEl promedio de los números ingresados es: " + promedio);
    }

    //3 - Hacer un programa que tenga un array de varios strings formado por palabras. Luego se deberá pedir al usuario que ingrese una palabra.
    //Habrá que buscar si la palabra ingresada por el usuario está en el array usando for o while informando de su existencia o no por consola.

    static void Ejercicio3()
    {
        string[] palabras = { "tv", "compu", "lamp", "celu", "vaso" };

        Console.Write("Ingresa una palabra: ");
        string tuPalabra = Console.ReadLine();

        bool encontrada = false;
        foreach (string palabra in palabras)
        {
            if (palabra == tuPalabra)
            {
                encontrada = true;
                break;
            }
        }

        if (encontrada)
        {
            Console.WriteLine("La palabra existe en el array.");
        }
        else
        {
            Console.WriteLine("La palabra no existe en el array.");
        }
    }
    //4- Desarrollar un programa principal y un método (función) estático que muestre un mensaje por consola, el método deberá ser llamado desde el programa principal (main).
    //El método no deberá recibir argumentos ni retornar datos (void).

    static void Ejercicio4() //main
    {
        MostrarMensaje();
    }

    static void MostrarMensaje()
    {
        Console.WriteLine("Este es el mensaje mostrado por el método.");
    }


    //5 - Crear un método estático que reciba dos números enteros por parametro y que muestre por consola la suma y resta de estos.
    //No deberá retornar datos. Deberá ser llamado desde el programa principal.

    static void Ejercicio5()
    {
        int num1 = 120;
        int num2 = 30;

        Operaciones(num1, num2);
    }

    static void Operaciones(int a, int b)
    {
        int suma = a + b;
        int resta = a - b;

        Console.WriteLine($"La suma de {a} y {b} es: {suma}");
        Console.WriteLine($"La resta de {a} y {b} es: {resta}");
    }
    //6- Hacer un método potencia que reciba dos enteros a y b por parámetro y retorne a = a la potencia de b. Ej: si recibe 5 y 2, deberá retornar 25 que es el resultado de 5 a la 2.
    //Se podrá hacer uso del método heredado Math.Pow(a, b). Mostrar el resultado por consola en el main.

    static void Ejercicio6()
    {
        int a = 5;
        int b = 2;

        int resultado = Potencia(a, b);
        Console.WriteLine($"El resultado de {a}^{b} es: {resultado}");
    }
    static int Potencia(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }

    //7- Hacer un programa que simule el juego de la quiniela.
    //El usuario debe elegir un número del 0 al 99 y un monto a apostar, si acierta el número gana 70 veces lo apostado.
    //(El número de la suerte debe ser elegido al azar). Para este punto se podrá instanciar la clase Random() y el metodo .Next() -propios en C#- para alegir numeros al azar.
    //Crear metodos estáticos y mostrar resultados por consola desde el main.

    static void Ejercicio7()
    {
        int numeroElegido = ElegirNumero();
        int montoApostado = PedirMonto();

        int numeroSuerte = GenerarNumeroSuerte();

        Console.WriteLine($"\nEl número de la suerte es: {numeroSuerte}");

        if (numeroElegido == numeroSuerte)
        {
            int montoGanado = montoApostado * 70;
            Console.WriteLine($"\n¡Felicidades! Has ganado {montoGanado} unidades.");
        }
        else
        {
            Console.WriteLine("\n¡Lo siento! No has acertado el número.");
        }
    }

    static int ElegirNumero()
    {
        int numeroElegido;
        bool esNumeroValido = false;

        do
        {
            Console.Write("Elige un número del 0 al 99: ");
            string input = Console.ReadLine();
            esNumeroValido = int.TryParse(input, out numeroElegido);

            if (!esNumeroValido)
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
            }
        } while (!esNumeroValido);

        return numeroElegido;
    }

    static int PedirMonto()
    {
        int montoApostado;
        bool esMontoValido = false;

        do
        {
            Console.Write("Ingresa el monto a apostar: ");
            string input = Console.ReadLine();
            esMontoValido = int.TryParse(input, out montoApostado);

            if (!esMontoValido)
            {
                Console.WriteLine("Por favor, ingresa un monto válido.");
            }
        } while (!esMontoValido);

        return montoApostado;
    }

    static int GenerarNumeroSuerte()
    {
        return random.Next(100);
    }


    //8- (opcional)-Hacer un programa que permita al usuario jugar al piedra, papel o tijera contra la computadora.
    //Se debe jugar al mejor de 5, es decir, si uno de los participantes consigue 3 victorias el juego termina.
    //Usar Random() y métodos estaticos.

    static void Ejercicio8()
    {
        int victoriasUsuario = 0;
        int victoriasComputadora = 0;

        while (victoriasUsuario < 3 && victoriasComputadora < 3)
        {
            string eleccionUsuario = ElegirJugadaUsuario();
            string eleccionComputadora = ElegirJugadaComputadora();

            Console.WriteLine($"\nTu elección: {eleccionUsuario}");
            Console.WriteLine($"Elección de la Computadora: {eleccionComputadora}");

            string resultado = DeterminarGanador(eleccionUsuario, eleccionComputadora);
            Console.WriteLine(resultado);

            if (resultado.Contains("Ganaste"))
            {
                victoriasUsuario++;
            }
            else if (resultado.Contains("Computadora"))
            {
                victoriasComputadora++;
            }


            Console.WriteLine($"\nPuntuación: Usuario {victoriasUsuario} - Computadora {victoriasComputadora}\n");
        }

        if (victoriasUsuario == 3)
        {
            Console.WriteLine("¡Felicidades! Has ganado la partida.");
        }
        else
        {
            Console.WriteLine("La Computadora ha ganado la partida.");
        }


        static string ElegirJugadaUsuario()
        {
            Console.Write("Elige tu jugada (piedra, papel o tijera): ");
            return Console.ReadLine().ToLower();
        }

        static string ElegirJugadaComputadora()
        {
            string[] opciones = { "piedra", "papel", "tijera" };
            int indice = random.Next(opciones.Length);
            return opciones[indice];
        }

        static string DeterminarGanador(string usuario, string computadora)
        {
            if ((usuario == "piedra" && computadora == "tijera") ||
                (usuario == "papel" && computadora == "piedra") ||
                (usuario == "tijera" && computadora == "papel"))
            {
                return "¡Ganaste esta ronda!";
            }
            else if ((usuario == "piedra" && computadora == "papel") ||
                     (usuario == "papel" && computadora == "tijera") ||
                     (usuario == "tijera" && computadora == "piedra"))
            {
                return "La Computadora gana esta ronda.";
            }
            else
            {
                return "¡Empate en esta ronda!";
            }
        }
    }
}