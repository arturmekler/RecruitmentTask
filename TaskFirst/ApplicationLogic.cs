using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFirst.Model;

namespace TaskFirst
{
    public class ApplicationLogic : IApplicationLogic
    {
        IInputDataReading inputDataReading;
        IInputDataConvert inputDataConvert;
        IDataSaveToFile dataSaveToFile;
        IOutputDataPrepare outputDataPrepare;
        IDisplayData display;

        public ApplicationLogic(IInputDataReading inputDataReading, IInputDataConvert inputDataConvert,
            IDataSaveToFile dataSaveToFile, IOutputDataPrepare outputDataPrepare, IDisplayData display)
        {
            this.inputDataConvert = inputDataConvert;
            this.inputDataReading = inputDataReading;
            this.dataSaveToFile = dataSaveToFile;
            this.outputDataPrepare = outputDataPrepare;
            this.display = display;
        }

        public List<Magazine> ProcessData()
        {
            var inputDataContent = inputDataReading.TextContent();

            foreach (var el in inputDataContent)
            {
                var splitedLine = inputDataConvert.Spliting(el);
                var businessObject = inputDataConvert.ReadBusinessObject(splitedLine);
                inputDataConvert.ReadMagazines(splitedLine, businessObject);
            }

            var magazines = inputDataConvert.Magazines;
            var sortedMagazines = outputDataPrepare.OutputSorting(magazines);
            return sortedMagazines;
        }

        public void DisplayConsole()
        {
            display.OutputToConsole(ProcessData());
        }

        public void DisplayToFile()
        {
            var dataToSaveToFile = display.OutputToFile(ProcessData());
            dataSaveToFile.SaveToFile(dataToSaveToFile);
        }



    }
}
