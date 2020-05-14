using System.Collections.Generic;
using DataParsing.Model;

namespace DataParsing
{
    public interface IOutputDataPrepare
    {
        List<Magazine> OutputSorting(List<Magazine> magazines);
    }
}