using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public interface IField
    {
        
        [DisplayName("Nom")]
        [Browsable(true)]
        string Name { get; set; }
        [DisplayName("Adresse")]
        [Browsable(true)]
        string Address { get; set; }
        [DisplayName("Type Cellule")]
        [Browsable(true)]
        CellType CellType { get; set; }

        [Browsable(false)]
        int Depth { get; }
        [Browsable(false)]
        int FirstColumn { get; }
        [Browsable(false)]
        int SecondColumn { get; }
        [Browsable(false)]
        int FirstRow { get; }
        [Browsable(false)]
        int SecondRow { get; }
    }
}
