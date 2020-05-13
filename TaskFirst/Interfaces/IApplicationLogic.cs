using System.Collections.Generic;
using TaskFirst.Model;

namespace TaskFirst
{
    public interface IApplicationLogic
    {
        List<Magazine> OutputData();
        void DisplayConsole();
        void DisplayToFile();
    }
}