using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataParsing.Model;
using DataParsing;

namespace RecruitmentTask
{
    /// <summary>
    /// contains methods and logic to display data on console or save data into file
    /// </summary>
    public class DisplayDataLogic : IDisplayDataLogic
    {
        IDataSaveToFile dataSaveToFile;
        IDisplayData display;
        IParsingLogic parsingLogic;

        public DisplayDataLogic(IDataSaveToFile dataSaveToFile, IDisplayData display, IParsingLogic parsingLogic)
        {
            this.dataSaveToFile = dataSaveToFile;
            this.display = display;
            this.parsingLogic = parsingLogic;
        }
        public void DisplayConsole()
        {
            display.OutputToConsole(parsingLogic.OutputData());
        }

        public void DisplayToFile()
        {
            var dataToSaveToFile = display.OutputToFile(parsingLogic.OutputData());
            dataSaveToFile.SaveToFile(dataToSaveToFile);
        }
    }
}
