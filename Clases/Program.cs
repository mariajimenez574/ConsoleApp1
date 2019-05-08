using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program

    {
        static void Main(string[] args)
        {

            Persona sujeto1 = new Persona();
            sujeto1.nombre = "Diego";
            sujeto1.apellido = "Gamboa";
            sujeto1.documento = "1047859322";
            sujeto1.direccion = "cra13#25-2";
            Persona sujeto2 = new Persona();
            sujeto2.nombre = "Milena";
            sujeto2.apellido = "Molano";
            sujeto2.documento = "1047521898";
            sujeto2.direccion = "cra12#15-3";

            sujeto2.VisualizarPersona(sujeto2);
            sujeto1.VisualizarPersona(sujeto1);
            Console.ReadLine();
       
        }
    }
}
