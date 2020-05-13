using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFirst
{
    public class ApplicationLogic : IApplicationLogic
    {
        IInputDataReading inputDataReading;
        IInputDataConvert inputDataConvert;
        IDataSaveToFile dataSaveToFile;
        IOutputDataPrepare outputDataPrepare;

        public ApplicationLogic(IInputDataReading inputDataReading, IInputDataConvert inputDataConvert,
            IDataSaveToFile dataSaveToFile, IOutputDataPrepare outputDataPrepare)
        {
            this.inputDataConvert = inputDataConvert;
            this.inputDataReading = inputDataReading;
            this.dataSaveToFile = dataSaveToFile;
            this.outputDataPrepare = outputDataPrepare;
        }

        public void ProcessData()
        {
            var inputDataContent = inputDataReading.TextContent();

            foreach (var el in inputDataContent)
            {
                var splitedLine = inputDataConvert.Spliting(el);
                var businessObject = inputDataConvert.ReadBusinessObject(splitedLine);
                inputDataConvert.ReadMagazines(splitedLine, businessObject);
            }

            var magazines = inputDataConvert.Magazines;
            var qwe = outputDataPrepare.OutputSorting(magazines);
            outputDataPrepare.OutputToConsole(qwe);
            var wewe = outputDataPrepare.OutputToFile(qwe);

            dataSaveToFile.SaveToFile(wewe);

            Console.ReadKey();
        }


    }
}
