using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentTask
{
    /// <summary>
    /// saves to OutputData.txt file
    /// </summary>
    public class DataSaverToFile : IDataSaverToFile
    {
        public void SaveToFile(List<string> lines)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter("OutputData.txt"))
            {
                foreach (string line in lines)
                {
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
