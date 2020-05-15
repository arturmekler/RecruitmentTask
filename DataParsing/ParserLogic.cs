using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataParsing.Model;

namespace DataParsing
{
    /// <summary>
    /// performs successive tasks for parsing data
    /// </summary>
    public class ParserLogic : IParserLogic
    {
        IInputDataReader inputDataReading;
        IInputDataConverter inputDataConvert;
        IOutputDataPreparer outputDataPrepare;

        public ParserLogic(IInputDataReader inputDataReading, IInputDataConverter inputDataConvert,
             IOutputDataPreparer outputDataPrepare)
        {
            this.inputDataConvert = inputDataConvert;
            this.inputDataReading = inputDataReading;
            this.outputDataPrepare = outputDataPrepare;
        }

        public List<Magazine> OutputData()
        {
            inputDataConvert.Magazines.Clear();
            inputDataConvert.BusinessObjects.Clear();

            var inputDataContent = inputDataReading.TextContent();
            foreach (var el in inputDataContent)
            {
                var splittedLine = inputDataConvert.Splitting(el);
                var businessObject = inputDataConvert.ReadBusinessObject(splittedLine);
                inputDataConvert.ReadMagazines(splittedLine, businessObject);
            }

            var magazines = inputDataConvert.Magazines;
            var sortedMagazines = outputDataPrepare.OutputSorting(magazines);
            return sortedMagazines;
        }
    }
}
