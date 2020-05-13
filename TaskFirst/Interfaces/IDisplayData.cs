using System.Collections.Generic;
using TaskFirst.Model;

namespace TaskFirst
{
    public interface IDisplayData
    {
        void OutputToConsole(List<Magazine> magazines);
        List<string> OutputToFile(List<Magazine> magazines);
    }
}