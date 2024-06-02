using EspacioCalculadora;
using EmpleadosEmpresa;
using System.Linq; //proporciona funcionalidades de consulta de datos como el metodo sum
using System;
using System.Threading.Tasks.Dataflow;

// Calculadora MiCalculadora= new Calculadora();
// MiCalculadora.Sumar(20);
// MiCalculadora.Multiplicar(4);


class Program
{
    static void Main()
    {
        // Calculadora calculadora = new Calculadora();
        // string comando;
        // double numero;

        // Console.WriteLine("Calculadora iniciada. Ingrese un comando para operar o 'salir' para terminar.");

        // while (true)
        // {
        //     Console.WriteLine($"Resultado actual: {calculadora.Resultado}");
        //     Console.Write("Ingrese un comando (sumar, restar, multiplicar, dividir, limpiar, salir): ");
        //     comando = Console.ReadLine().ToLower();

        //     if (comando == "salir")
        //     {
        //         break;
        //     }

        //     if (comando == "limpiar")
        //     {
        //         calculadora.Limpiar();
        //         continue;
        //     }

        //     Console.Write("Ingrese un número: ");
        //     if (!double.TryParse(Console.ReadLine(), out numero))
        //     {
        //         Console.WriteLine("Número no válido. Inténtelo de nuevo.");
        //         continue;
        //     }

        //     switch (comando)
        //     {
        //         case "sumar":
        //             calculadora.Sumar(numero);
        //             break;
        //         case "restar":
        //             calculadora.Restar(numero);
        //             break;
        //         case "multiplicar":
        //             calculadora.Multiplicar(numero);
        //             break;
        //         case "dividir":
        //             calculadora.Dividir(numero);
        //             break;
        //         default:
        //             Console.WriteLine("Comando no reconocido. Inténtelo de nuevo.");
        //             break;
        //     }
        // }

        // Console.WriteLine("Calculadora finalizada.");


          //Sistema de empresa
          Empleado[] empleados= new Empleado[3];
        empleados[0] = new Empleado("Juan", "Pérez", new DateTime(1980, 5, 15), 'C', new DateTime(2005, 10, 1), 650000.0, Cargos.Ingeniero);
        empleados[1] = new Empleado("María", "Gómez", new DateTime(1975, 3, 22), 'S', new DateTime(2010, 8, 5), 700000.0, Cargos.Especialista);
        empleados[2] = new Empleado("Carlos", "López", new DateTime(1985, 11, 10), 'C', new DateTime(2015, 2, 10), 600000.0, Cargos.Administrativo);
        
          // d. Obtener el Monto Total de lo que se paga en concepto de Salarios
        double montoTotalSalarios = empleados.Sum(e => e.CalcularSalario()); //toma cada empleado e en el arreglo empleados y llama al método CalcularSalario para obtener el salario de ese empleado.
        Console.WriteLine($"Monto Total de Salarios: {montoTotalSalarios}");
         // e- Mostrar por pantalla los datos del empleado que esté más próximo a jubilarse
        Empleado empleadoMasProximoAJubilarse = empleados.OrderBy(e => e.CalcularAniosParaJubilarse()).First();//para el método OrderBy, indicando que debe ordenar los empleados según los años para jubilarse, .First() selecciona el primer empleado en la lista ordenada, es decir, el empleado que tiene la menor cantidad de años restantes para jubilarse

        
        //mostrar los datos del empleado mas proximo a jubilarse
        Console.WriteLine($"Nombre: { empleadoMasProximoAJubilarse.GetNombre()}{ empleadoMasProximoAJubilarse.GetApellido}");
        Console.WriteLine($"Edad:{ empleadoMasProximoAJubilarse.CalcularEdad()}años");
        Console.WriteLine($"Antiguedad: { empleadoMasProximoAJubilarse.CalcularAntiguedad() }Años");
        Console.WriteLine($"Salario: { empleadoMasProximoAJubilarse.CalcularSalario()}");
        Console.WriteLine($"Años para Jubilarse: { empleadoMasProximoAJubilarse.CalcularAniosParaJubilarse()}Años");

    }

   
   
}



