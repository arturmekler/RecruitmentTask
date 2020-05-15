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
        IDataSaverToFile dataSaveToFile;
        IDisplayData display;
        IParserLogic parsingLogic;

        public DisplayDataLogic(IDataSaverToFile dataSaveToFile, IDisplayData display, IParserLogic parsingLogic)
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
