namespace EspacioCalculadora
{
    

public class Calculadora
{
   private double dato ;//quiere decir que el dato va a hacer utilizable solo dentro del sistema(mas seguridad) asi no pueda ser modificado por cualquiera
   public void Limpiar(){//va a servir para reiniciar el campo dato
      dato = 0;
   }
   public double Resultado{
      get { return dato; } 
   }
     
     public void Sumar(double termino){
        dato += termino;
     }
     public void Restar(double termino){
        dato -= termino;
     }
      public void Multiplicar(double termino){
        dato *= termino;
     }
      public void Dividir(double termino){
        if (termino != 0 )
        {
          dato /= termino;
        }
     }

 }
}
