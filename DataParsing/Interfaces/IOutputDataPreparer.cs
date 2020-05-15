using System.Collections.Generic;
using DataParsing.Model;

namespace DataParsing
{
    public interface IOutputDataPreparer
    {
        List<Magazine> OutputSorting(List<Magazine> magazines);
    }
}