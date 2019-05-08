using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Persona
    {

        public string nombre;
        public string apellido;
        public string documento;
        public string direccion;

        /// <summary>
        /// Metodo para crear persona
        /// creado el 08/05/2019
        /// Autor: Maria Jimenez
        /// </summary>
        /// <param name="personita"></param>
        public void VisualizarPersona(Persona personita)
        {
            Console.WriteLine($"Nombre:{personita.nombre}\n,Apellido:{personita.apellido}\n,Documento:{personita.documento}\n,Direccion:{personita.direccion}");
        }
        /// <summary>
        /// Metodo para mostrar los datos de la persona
        /// creado el 08/05/2019
        /// autor :Maria Jimenez
        /// </summary>
        /// <param name="personita"></param>
        public void IngresarPersona(Persona personita)
        {
            Console.WriteLine("Ingrese el Nombre de la persona");
            personita.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Apellido de la persona");
            personita.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el Documento de la persona");
            personita.documento = Console.ReadLine();
            Console.WriteLine("Ingrese la Direccion de la persona");
            personita.direccion  = Console.ReadLine();
        }
    }
}



