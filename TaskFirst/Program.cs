using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            InputDataConvert data = new InputDataConvert();
            data.ReadTxtFile();
            Console.ReadKey();
        }
    }
}
