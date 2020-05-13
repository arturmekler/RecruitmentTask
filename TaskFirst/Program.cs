using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<InputDataReading>().As<IInputDataReading>();
            Container = builder.Build();
  

            var inputData = new InputDataReading();
            var inputDataContent = inputData.TextContent();

            InputDataConvert inputDataConvert = new InputDataConvert();
            OutputDataSaveToFile outputdata = new OutputDataSaveToFile();

            foreach(var el in inputDataContent)
            {
                var splitedLine = inputDataConvert.Spliting(el);
                var businessObject = inputDataConvert.ReadBusinessObject(splitedLine);
                inputDataConvert.ReadMagazines(splitedLine, businessObject);
            }

            var magazines = inputDataConvert.magazines;
            var sortedMagazines = new OutputData();
            var qwe = sortedMagazines.OutputSorting(magazines);
            sortedMagazines.OutputToConsole(qwe);
            var wewe = sortedMagazines.OutputToFile(qwe);

            outputdata.SaveToFile(wewe);

            Console.ReadKey();
        }
    }
}
