using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string categoria;
            int hijos;
            float sueldo, incr, porincr, nuevosueld, aumenh, desc, sueldo_neto;
            Console.WriteLine("Ingrese su sueldo actual: ");
            sueldo = float.Parse(Console.ReadLine());  
            Console.WriteLine("Ingrese su categoria (A/B/C/D): ");
            categoria = Console.ReadLine(); 
            Console.WriteLine("Cuantos hijos tiene?: ");
            hijos = int.Parse(Console.ReadLine());
            nuevosueld = 0;
            porincr = 0;
            aumenh = 0;
            desc = 0; 
            incr = 0;   
        switch (categoria.ToLower())
            {
                case "a":
                    porincr = 0.25f;
                    break;
                case "b":
                    porincr = 0.20f;
                    break;
                case "c":
                    porincr = 0.15f;
                    break;
                case "d":
                    porincr = 010f;
                    break;
            }
            if (nuevosueld >= 0) 
            {
                aumenh = (sueldo * 0.025f) * hijos;
                incr = sueldo * porincr;
                nuevosueld = sueldo + incr + aumenh;

                if (nuevosueld > 2000)
                {
                    desc = nuevosueld * 0.03f;
                }
                else
                {
                    desc = 0f; 
                }
            }
            sueldo_neto = (sueldo + incr + aumenh) - desc;

            Console.WriteLine("Incremento del sueldo: " + incr.ToString("0.00"));
            Console.WriteLine("Aumento por hijos: " + aumenh.ToString("0.00"));
            Console.WriteLine("Nuevo sueldo: " + nuevosueld.ToString("0.00"));
            Console.WriteLine("Descuento: " + desc.ToString("0.00"));
            Console.WriteLine("Sueldo neto: " + sueldo_neto.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
