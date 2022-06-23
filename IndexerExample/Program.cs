using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Indexers? 
// used to iterate through collections => your own classes

namespace IndexerExample
{   class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

           List<Person> personList = new List<Person>();
            personList.Add(new Person("Thomas", 40));
            personList.Add(new Person("Mars", 31));

            var avgAge = personList.Average(p => p.Age);

            var pplNamesList = personList.Where(p => p.Age > 32).Select(p => p.Name);
            foreach(var name in pplNamesList)
            {
                Console.WriteLine(name);
            }
            //List<int> list = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, };
            //List<int> listEven = new List<int>();
            //foreach(int i in list)
            //{
            //    // select even numbers and add into evens list
            //    if(i % 2 == 0)
            //    {
            //        listEven.Add(i);
            //    }
            //} 
            //foreach(int i in listEven)
            //{
            //    Console.WriteLine(i);
            //}

            //List<int> listEven2 = list.Where(n => n % 2 == 0).ToList();

            //listEven2.ForEach(n => Console.WriteLine(n));
        }  

    }
}
