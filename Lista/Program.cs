using Lista.Entities;
using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();

            Console.Write("Enter the number of people");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Name of "+i+" people: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                list.Add(new People(name, age));
            }
            foreach (People people in list)
            {
                Console.WriteLine(people.Name+" - "+people.Age);
            }
        }
    }
}
