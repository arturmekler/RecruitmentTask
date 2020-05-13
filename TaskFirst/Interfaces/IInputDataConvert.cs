using System.Collections.Generic;
using TaskFirst.Model;

namespace TaskFirst
{
    public interface IInputDataConvert
    {
        List<Magazine> Magazines { get; }

        BusinessObject ReadBusinessObject(string[] splitedLine);
        void ReadMagazines(string[] splitedLine, BusinessObject businessObject);
        string[] Spliting(string line);
    }
}