using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataParsing.Model;

namespace DataParsing
{
    public class OutputDataPrepare : IOutputDataPrepare
    {
        public List<Magazine> OutputSorting(List<Magazine> magazines)
        {
            return magazines
                .Select(p =>
                    {
                        var businessObjectWithCount = p.businessObjects.OrderBy(bussObj => bussObj.Item2.ID).ToList();
                        p.businessObjects = businessObjectWithCount;
                        return p;
                    })
                .OrderByDescending(el => el.Name)
                .OrderByDescending(el => el.CountOfBusinessObjects)
                .ToList();
        }
    }
}
