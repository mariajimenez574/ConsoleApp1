using System;

namespace Ecuacion
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int sa;
            int sb;
            int sc;

            Console.Write("digite el valor de A");
            var a = Console.ReadLine();
            var aresult = int.TryParse(a, out sa);

            Console.Write("digite el valor de B");
            var b = Console.ReadLine();
            var bresult = int.TryParse(b, out sb);

            Console.Write("digite el valor de C");
            var c = Console.ReadLine();
            var cresult = int.TryParse(c, out sc);

            if ((aresult == true) && (bresult == true) && (cresult == true))
            {
                sa = int.Parse(a);
                sb = int.Parse(b);
                sc = int.Parse(c);

               
                if (sa == 0)
                {
                    Console.Write("No se puede realizar la ecuacion");
                }
                 else
                {


                    var solucion = (sb * sb) - (4 * (sa * sc));

                    if (solucion > 0)
                    {
                        double x = (-(sb) - Math.Sqrt(solucion))/(2*(sa));
                        double x2 = (-(sb) + Math.Sqrt(solucion)) / (2 * (sa));

                        Console.WriteLine($"La ecuacion negativa es: {x} la ecuacion es positiva {x2}");
                        Console.ReadLine();

                    }
                    else
                    {
                        Console.WriteLine("La solucion esta dentro del conjunto de los imaginarios");
                        Console.ReadLine();
                    }
                    
                }
                Console.ReadLine();




            }

      
        }
    }
}
