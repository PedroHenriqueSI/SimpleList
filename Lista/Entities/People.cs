using System;
using System.Collections.Generic;
using System.Text;

namespace Lista.Entities
{
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public People()
        {
        }

        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
