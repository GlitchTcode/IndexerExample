using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{   // => Lambda or Fat Arrow Operator. Used to write anonymous methods
    //Implicitly returns value
    // Delegates: Func<>
    internal class LambdaEx
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int RandomNum()
        {
            Random r = new Random();
            return r.Next(0, 100);
        }
        /*static void Main(string[] args)
        {
            Func<int, int, int> del = Add;
            int result = del(10,20);
            Console.WriteLine(result);

            Func<int> del2 = RandomNum;
            int result2 = del2();
            Console.WriteLine(result2);

            //Use Lambdas
            Func<int, int, int> delLambda = (a, b) => a + b;
            Console.WriteLine(delLambda(9, 10));

            Func<int> delLambda2 = () => new Random().Next(0, 100);
        }*/
    }
}
