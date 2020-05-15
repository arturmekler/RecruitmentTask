using System.Collections.Generic;

namespace RecruitmentTask
{
    public interface IDataSaveToFile
    {
        void SaveToFile(List<string> lines);
    }
}