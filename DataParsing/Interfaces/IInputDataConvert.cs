using System.Collections.Generic;
using DataParsing.Model;

namespace DataParsing
{
    public interface IInputDataConvert
    {
        List<Magazine> Magazines { get; }

        BusinessObject ReadBusinessObject(string[] splitedLine);
        void ReadMagazines(string[] splitedLine, BusinessObject businessObject);
        string[] Spliting(string line);
    }
}