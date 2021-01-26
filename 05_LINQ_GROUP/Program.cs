using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _05_LINQ_GROUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] listaNum = {1,1,1,1,4,4,2,3,5,6,6,10,9,8};

            var listaFiltrada = listaNum.OrderBy(n=> n).Distinct();

            foreach (var item in listaFiltrada)
            {
                Console.WriteLine(item);
                
            }

            var listaFiltrada2 = listaNum.OrderBy(n=> n).GroupBy(n=> n).Select(n=> n);

              foreach (var item in listaFiltrada2)
            {
                //Key serve para mostrar o numero
                Console.WriteLine("ex2: " + item.Key);
                
            }
        }
    }
}
