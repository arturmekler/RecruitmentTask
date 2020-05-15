using System.Collections.Generic;

namespace DataDisplay
{
    public interface IDataSaveToFile
    {
        void SaveToFile(List<string> lines);
    }
}