using System.Collections.Generic;
using TaskFirst.Model;

namespace TaskFirst
{
    public interface IApplicationLogic
    {
        List<Magazine> ProcessData();
        void DisplayConsole();
        void DisplayToFile();
    }
}