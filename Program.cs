using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Последовательность
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Я выбрал цикл for потому, что извесна последовательность чисел.
            int initialNumber;
            int finiteNumber = 97;

            for(initialNumber = 5; initialNumber < finiteNumber; initialNumber+= 7)
            {
                Console.WriteLine(initialNumber);
            }
        }
    }
}
