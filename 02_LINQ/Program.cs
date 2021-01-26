using System;
using System.Linq;
namespace _02_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = {3,9,4,6,20,10,60,90,80,50};

            var listamod = from a in lista where a > 10 orderby a select a;

            foreach (var item in listamod)
            {
                 Console.WriteLine("--" + item);
            }
        }
    }
}
