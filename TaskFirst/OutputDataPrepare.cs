using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFirst.Model;

namespace TaskFirst
{
    class OutputDataPrepare : IOutputDataPrepare
    {
        public List<Magazine> OutputSorting(List<Magazine> magazines)
        {
            return magazines
                .Select(p =>
                    {
                        var wqeqwe = p.businessObjects.OrderBy(bussObj => bussObj.Item2.ID).ToList();
                        p.businessObjects = wqeqwe;
                        return p;
                    })
                .OrderByDescending(el => el.Name)
                .OrderByDescending(el => el.CountOfBusinessObjects)
                .ToList();
        }
    }
}
