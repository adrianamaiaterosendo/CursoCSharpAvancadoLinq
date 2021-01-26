using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _03_LINQ_OBJ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Usuario> lista = new List<Usuario>();
            lista.Add(new Usuario(){Nome = "Maria", Email= "maria@teste.com"});
            lista.Add(new Usuario(){Nome = "Jose", Email= "jose@gmail.com"});
            lista.Add(new Usuario(){Nome = "Joao", Email= "joao@gmail.com"});
            lista.Add(new Usuario(){Nome = "Tiago", Email= "tiago@teste.com"});
            lista.Add(new Usuario(){Nome = "Miguel", Email= "miguel@teste.com"});


            var ListaFiltrada = lista.Where(a=> a.Email.Contains("gmail.com")).Select(a=>a);

            foreach (var item in ListaFiltrada)
            {
                Console.WriteLine(item.Nome + " " + item.Email);
            }

            
        }
    }
}
