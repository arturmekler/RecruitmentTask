﻿using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataParsing;

namespace RecruitmentTask
{
    /// <summary>
    /// write "exit" if you have finished entering data in console
    /// </summary>
    class Program
    {
        private static IContainer Container { get; set; }
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ParserLogic>().As<IParserLogic>();
            builder.RegisterType<InputDataConverter>().As<IInputDataConverter>();
            builder.RegisterType<OutputDataPreparer>().As<IOutputDataPreparer>();
            builder.RegisterType<DisplayData>().As<IDisplayData>();
            builder.RegisterType<DataSaverToFile>().As<IDataSaverToFile>();
            builder.RegisterType<DisplayDataLogic>().As<IDisplayDataLogic>();
            //builder.RegisterType<InputDataReadingFromConsole>().As<IInputDataReading>();    // if you want read input from console
            builder.RegisterType<InputDataReaderFromTxt>().As<IInputDataReader>();        // if you want read input from txt file

            Container = builder.Build();

            var app = Container.Resolve<IDisplayDataLogic>();

            app.DisplayConsole();   // if you want to display the output on console
            app.DisplayToFile();    // if you want to save the output to a file

            Console.ReadKey();
        }
    }
}
