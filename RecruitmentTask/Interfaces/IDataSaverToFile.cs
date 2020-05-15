using System.Collections.Generic;

namespace RecruitmentTask
{
    public interface IDataSaverToFile
    {
        void SaveToFile(List<string> lines);
    }
}