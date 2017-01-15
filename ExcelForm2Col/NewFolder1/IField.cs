using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public interface IField
    {
        string Name { get; set; }
        string Address { get; set; }
        CellType CellType { get; set; }

        int Depth { get; }
        int FirstColumn { get; }
        int SecondColumn { get; }
        int FirstRow { get; }
        int SecondRow { get; }
    }
}
