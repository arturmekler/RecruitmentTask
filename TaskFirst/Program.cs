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
            builder.RegisterType<InputDataReading>().As<IInputDataReading>();
            builder.RegisterType<InputDataConvert>().As<IInputDataConvert>();
            Container = builder.Build();

            var app = Container.Resolve<IApplicationLogic>();
            app.ProcessData();
  

            Console.ReadKey();
        }
    }
}
