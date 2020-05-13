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

        public ApplicationLogic(IInputDataReading inputDataReading, IInputDataConvert inputDataConvert)
        {
            this.inputDataConvert = inputDataConvert;
            this.inputDataReading = inputDataReading;
        }

        public void ProcessData()
        {
            var inputDataContent = inputDataReading.TextContent();

            OutputDataSaveToFile outputdata = new OutputDataSaveToFile();

            foreach (var el in inputDataContent)
            {
                var splitedLine = inputDataConvert.Spliting(el);
                var businessObject = inputDataConvert.ReadBusinessObject(splitedLine);
                inputDataConvert.ReadMagazines(splitedLine, businessObject);
            }

            var magazines = inputDataConvert.Magazines;
            var sortedMagazines = new OutputData();
            var qwe = sortedMagazines.OutputSorting(magazines);
            sortedMagazines.OutputToConsole(qwe);
            var wewe = sortedMagazines.OutputToFile(qwe);

            outputdata.SaveToFile(wewe);

            Console.ReadKey();
        }


    }
}
