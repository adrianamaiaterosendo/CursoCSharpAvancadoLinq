using System;
using System.Linq;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = {3,9,4,6,20,10,60,90,80,50};

            var listamod = lista.Where(a=> a > 10 ).OrderBy(a=> a).Select(a=> a);

            foreach (var item in listamod)
            {
                 Console.WriteLine(item);
            }
           
        }
    }
}
