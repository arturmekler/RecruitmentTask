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
            var inputData = new InputDataReading();
            var inputDataContent = inputData.TextContent();

            InputDataConvert inputDataConvert = new InputDataConvert();

            foreach(var el in inputDataContent)
            {
                var splitedLine = inputDataConvert.Spliting(el);
                var businessObject = inputDataConvert.ReadBusinessObject(splitedLine);
                inputDataConvert.ReadMagazines(splitedLine, businessObject);
            }

            var magazines = inputDataConvert.magazines;
            Console.ReadKey();
        }
    }
}
