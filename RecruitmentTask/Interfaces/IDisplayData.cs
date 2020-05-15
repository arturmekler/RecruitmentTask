using System.Collections.Generic;
using DataParsing.Model;

namespace RecruitmentTask
{
    public interface IDisplayData
    {
        void OutputToConsole(List<Magazine> magazines);
        List<string> OutputToFile(List<Magazine> magazines);
    }
}