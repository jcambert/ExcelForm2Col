using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public interface IMapping
    {
        Fields Fields { get; }
        IEnumerable<string> SheetNames();
        void AddSheetName(String name);
    }
}
