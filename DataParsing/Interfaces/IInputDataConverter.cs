using System.Collections.Generic;
using DataParsing.Model;

namespace DataParsing
{
    public interface IInputDataConverter
    {
        List<Magazine> Magazines { get; }
        List<BusinessObject> BusinessObjects { get; }

        BusinessObject ReadBusinessObject(string[] splittedLine);
        void ReadMagazines(string[] splitedLine, BusinessObject businessObject);
        string[] Splitting(string line);
    }
}