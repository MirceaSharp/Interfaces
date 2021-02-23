using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant("Grijze Dudette", 6000.00, 'V');
            Console.WriteLine(elephant.ToString());
            Console.WriteLine(elephant.GetNumberOfFeet());
            Console.WriteLine(elephant.MakesNoise());
            Console.ReadLine();
        }

    }
}
