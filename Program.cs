using EspacioCalculadora;
using System;

// Calculadora MiCalculadora= new Calculadora();
// MiCalculadora.Sumar(20);
// MiCalculadora.Multiplicar(4);


class Program
{
    static void Main()
    {
        Calculadora calculadora = new Calculadora();
        string comando;
        double numero;

        Console.WriteLine("Calculadora iniciada. Ingrese un comando para operar o 'salir' para terminar.");

        while (true)
        {
            Console.WriteLine($"Resultado actual: {calculadora.Resultado}");
            Console.Write("Ingrese un comando (sumar, restar, multiplicar, dividir, limpiar, salir): ");
            comando = Console.ReadLine().ToLower();

            if (comando == "salir")
            {
                break;
            }

            if (comando == "limpiar")
            {
                calculadora.Limpiar();
                continue;
            }

            Console.Write("Ingrese un número: ");
            if (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número no válido. Inténtelo de nuevo.");
                continue;
            }

            switch (comando)
            {
                case "sumar":
                    calculadora.Sumar(numero);
                    break;
                case "restar":
                    calculadora.Restar(numero);
                    break;
                case "multiplicar":
                    calculadora.Multiplicar(numero);
                    break;
                case "dividir":
                    calculadora.Dividir(numero);
                    break;
                default:
                    Console.WriteLine("Comando no reconocido. Inténtelo de nuevo.");
                    break;
            }
        }

        Console.WriteLine("Calculadora finalizada.");
    }
}



