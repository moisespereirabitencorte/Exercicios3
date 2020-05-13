using System;
using System.Collections.Generic;
 

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Larissa");
            list.Add("Bob");
            list.Add("Alex");
            list.Insert(2, "Marco");

            foreach (string obj in list)
                Console.WriteLine(obj);
            
            
        }
    }
}

