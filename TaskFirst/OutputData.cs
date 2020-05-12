using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskFirst.Model;

namespace TaskFirst
{
    class OutputData
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

        public void OutputToConsole(List<Magazine> magazines)
        {
            foreach (var mag in magazines)
            {
                Console.WriteLine(mag.Name + " Total " + "(" + mag.CountOfBusinessObjects + ")");
                mag.businessObjects.ForEach(elem =>
                {
                    Console.WriteLine(elem.Item2.ID + ": " + elem.Item1);
                });
                Console.WriteLine(String.Empty);
            }
        }
    }
}
