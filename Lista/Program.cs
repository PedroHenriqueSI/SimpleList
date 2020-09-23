using Lista.Entities;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();
            list.Add(new People("Pedro", 12));
            list.Add(new People("Carlos", 15));
            list.Add(new People("Leane", 18));
            list.Add(new People("Claudia", 30));
            list.Add(new People("Snow", 19));

            foreach (People people in list)
            {
                Console.WriteLine("Name: "+people.Name+"-- Age: "+people.Age);
            }
        }
    }
}
