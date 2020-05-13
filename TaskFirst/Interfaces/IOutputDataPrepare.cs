using System.Collections.Generic;
using TaskFirst.Model;

namespace TaskFirst
{
    public interface IOutputDataPrepare
    {
        List<Magazine> OutputSorting(List<Magazine> magazines);
        void OutputToConsole(List<Magazine> magazines);
        List<string> OutputToFile(List<Magazine> magazines);
    }
}