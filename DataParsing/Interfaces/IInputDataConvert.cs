using System.Collections.Generic;
using DataParsing.Model;

namespace DataParsing
{
    public interface IInputDataConvert
    {
        List<Magazine> Magazines { get; }

        BusinessObject ReadBusinessObject(string[] splittedLine);
        void ReadMagazines(string[] splitedLine, BusinessObject businessObject);
        string[] Splitting(string line);
    }
}