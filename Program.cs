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
            int initialNumber = 5;
            int finiteNumber = 97;
            int seguenceNumber = 7;

            for(initialNumber = 5; initialNumber < finiteNumber; initialNumber+= seguenceNumber)
            {
                Console.WriteLine(initialNumber);
            }
        }
    }
}
