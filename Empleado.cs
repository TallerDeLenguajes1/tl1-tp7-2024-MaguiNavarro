using System;
using System.Security.Cryptography;
namespace EmpleadosEmpresa
{
    public enum Cargos  //se utiliza para definir un tipo de datos enumerado. Un tipo enumerado es una forma de definir un conjunto de constantes con nombre.
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}
    class Empleado
    {
        private string Nombre;
        private string Apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBasico;
        private Cargos cargo;

        // Constructor de la clase Empleado
    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
    { //Constructor es un método especial que se utiliza para inicializar un objeto justo después de su creación,
    // Se utiliza para establecer los valores iniciales de los campos y propiedades de un objeto
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaIngreso = fechaIngreso;
        this.sueldoBasico = sueldoBasico;
        this.cargo = cargo;
    }
        public string GetNombre()
    {
        return Nombre;
    }

    public void SetNombre(string nombre)
    {
        this.Nombre = nombre;
    }

    public string GetApellido()
    {
        return Apellido;
    }

    public void SetApellido(string apellido)
    {
        this.Apellido = apellido;
    }

    public DateTime GetFechaNacimiento()
    {
        return fechaNacimiento;
    }

    public void SetFechaNacimiento(DateTime fechaNacimiento)
    {
        this.fechaNacimiento = fechaNacimiento;
    }

    public char GetEstadoCivil()
    {
        return estadoCivil;
    }

    public void SetEstadoCivil(char estadoCivil)
    {
        this.estadoCivil = estadoCivil;
    }

    public DateTime GetFechaIngreso()
    {
        return fechaIngreso;
    }

    public void SetFechaIngreso(DateTime fechaIngreso)
    {
        this.fechaIngreso = fechaIngreso;
    }

    public double GetSueldoBasico()
    {
        return sueldoBasico;
    }

    public void SetSueldoBasico(double sueldoBasico)
    {
        this.sueldoBasico = sueldoBasico;
    }

    public Cargos GetCargo()
    {
        return cargo;
    }

    public void SetCargo(Cargos cargo)
    {
        this.cargo = cargo;
    }
       //Metodo para calcular la antiguedad en la empresa
    public int CalcularAntiguedad()
    {
     DateTime hoy= DateTime.Today;
     int antiguedad= hoy.Year- fechaIngreso.Year;
     if (hoy < fechaIngreso.AddYears(antiguedad))
     {
        antiguedad--;
     }
      return antiguedad;
    }
    public int CalcularEdad()
    {
        DateTime hoy= DateTime.Today;
     int edad= hoy.Year- fechaIngreso.Year;
     if (hoy < fechaIngreso.AddYears(edad))
     {
        edad--;
     }
      return edad;
    }

     // Método para calcular la cantidad de años que le falta al empleado para poder jubilarse
    public int CalcularAniosParaJubilarse()
    {
        const int edadJubilacion = 65;
        int edadActual = CalcularEdad();
        int aniosParaJubilarse = edadJubilacion - edadActual;

        // Si ya tiene la edad de jubilación o más, retornar 0
        return aniosParaJubilarse > 0 ? aniosParaJubilarse : 0;
    }
       // Método para calcular el salario del empleado
    public double CalcularSalario()
    {
        double adicional = 0;
        int antiguedad = CalcularAntiguedad();

        // i) 1 % del sueldo básico por cada año de antigüedad hasta los 20 años
        //    A partir de este, el porcentaje se fija en 25%
        if (antiguedad <= 20)
        {
            adicional += sueldoBasico * 0.01 * antiguedad;
        }
        else
        {
            adicional += sueldoBasico * 0.25;
        }

        // ii) Si el cargo es Ingeniero o Especialista, el Adicional se incrementa en un 50%
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional *= 1.5;
        }

        // Si es casado, agregar un 5% adicional
        if (estadoCivil == 'C' || estadoCivil == 'c')
        {
            adicional += 150000;
        }

        return sueldoBasico + adicional;
    }

   }


}

  
