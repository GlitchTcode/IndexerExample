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

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, };
            List<int> listEven = new List<int>();
            foreach(int i in list)
            {
                // select even numbers and add into evens list
                if(i % 2 == 0)
                {
                    listEven.Add(i);
                }
            } 
            foreach(int i in listEven)
            {
                Console.WriteLine(i);
            }

            List<int> listEven2 = list.Where(n => n % 2 == 0).ToList();

            listEven2.ForEach(n => Console.WriteLine(n));
        }  

    }
}
