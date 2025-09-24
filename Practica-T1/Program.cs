using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_T1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int suma = 0;

            Console.WriteLine("Sumando números pares del 100 al 200, sin contar del 150 al 176");

            for (int i = 100; i <= 200; i++)
            {
               if (i < 150)
                {
                    suma = suma + i;
                }
                else
                {
                    if (i > 176)
                    {
                        suma = suma + i;
                    }
                }
                    
                
            }

            Console.WriteLine("La suma total es: " + suma);
        }
    }
}
