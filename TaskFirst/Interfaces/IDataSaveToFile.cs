using System.Collections.Generic;

namespace TaskFirst
{
    public interface IDataSaveToFile
    {
        void SaveToFile(List<string> lines);
    }
}