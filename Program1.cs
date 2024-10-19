using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoSelectM1Assingmnet
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, string address,int Age)
        {
            Name = name; 
            Address = address;
            this.Age = Age;
        }
    }
    class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            string Result = "";
            foreach(var item in person)
            {
                Result += item.Name + " " + item.Address + " ";
            }
            return Result;
        }
        public double Average(IList<Person> person)
        {
            double Sum = 0;
            int Count = 0;
            foreach (var item in person)
            {
                Sum += item.Age;
                Count++;
            }
            return Sum / Count;
        }

        public int Max(IList<Person> person) {
            int MaxAge = 0;
            foreach(var item in person)
            {
                if (item.Age > MaxAge)
                {
                    MaxAge = item.Age;
                }
            }
            return MaxAge;
        }
    }
    class Program1
    {
        public static void Main(string[] args)
        {
            IList<Person> p = new List<Person>();
            p.Add(new Person { Name = "Aarya", Address = "A2101", Age = 69 });
            p.Add(new Person { Name = "Daniel", Address = "D104", Age = 40 });
            p.Add(new Person { Name = "Ira", Address = "H801", Age = 25 });
            p.Add(new Person { Name = "Jennifer", Address = "I1704", Age = 33 });
            PersonImplementation personImplementation = new PersonImplementation();
            Console.WriteLine(personImplementation.GetName(p));
            Console.WriteLine(personImplementation.Average(p));
            Console.WriteLine(personImplementation.Max(p));
        }
    }
}
