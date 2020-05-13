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
            builder.RegisterType<ApplicationLogic>().As<IApplicationLogic>();
            builder.RegisterType<InputDataReadingFromConsole>().As<IInputDataReading>();
            builder.RegisterType<InputDataConvert>().As<IInputDataConvert>();
            builder.RegisterType<DataSaveToFile>().As<IDataSaveToFile>();
            builder.RegisterType<OutputDataPrepare>().As<IOutputDataPrepare>();
            builder.RegisterType<DisplayData>().As<IDisplayData>();
            Container = builder.Build();

            var app = Container.Resolve<IApplicationLogic>();
            app.DisplayConsole();
  
            Console.ReadKey();
        }
    }
}
