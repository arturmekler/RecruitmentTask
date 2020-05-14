using System.Collections.Generic;
using DataParsing.Model;

namespace DataDisplay
{
    public interface IDisplayData
    {
        void OutputToConsole(List<Magazine> magazines);
        List<string> OutputToFile(List<Magazine> magazines);
    }
}