using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Digite su edad");

            int salida;
            var edad = Console.ReadLine();
            var Result = int.TryParse(edad ,out salida);
            if (Result == true)

            {
                Console.Write("El valor se puede convertir");
                salida = int.Parse(edad);

            } 
            else
            {
                Console.Write("No se puede convertir");

            }

           
           
            
      
       
        
        }
    }
}
