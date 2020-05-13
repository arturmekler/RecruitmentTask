using System.Collections.Generic;
using TaskFirst.Model;

namespace TaskFirst
{
    public interface IOutputDataPrepare
    {
        List<Magazine> OutputSorting(List<Magazine> magazines);
    }
}