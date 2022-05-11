using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorVet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeneratorVet generatorVet = new GeneratorVet();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(generatorVet.GenerujVetu());
            }
            Console.ReadKey();
        }
    }
}
