using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataParsing;

namespace DataDisplay
{
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ParsingLogic>().As<IParsingLogic>();
            builder.RegisterType<InputDataConvert>().As<IInputDataConvert>();
            builder.RegisterType<OutputDataPrepare>().As<IOutputDataPrepare>();
            builder.RegisterType<DisplayData>().As<IDisplayData>();
            builder.RegisterType<DataSaveToFile>().As<IDataSaveToFile>();
            builder.RegisterType<DisplayDataLogic>().As<IDisplayDataLogic>();
            //builder.RegisterType<InputDataReadingFromConsole>().As<IInputDataReading>();    // if you want read input from console
            builder.RegisterType<InputDataReadingFromTxt>().As<IInputDataReading>();        // if you want read input from txt file

            Container = builder.Build();

            var app = Container.Resolve<IDisplayDataLogic>();

            app.DisplayConsole();   // if you want to display the output on console
            //app.DisplayToFile();    // if you want to save the output to a file

            Console.ReadKey();
        }
    }
}
