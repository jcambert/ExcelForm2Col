using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public interface IProject
    {
        string Name { get; set; }

        EF2C Ef2c { get; set; }
    }

    public class Project:IProject
    {
        public string Name { get; set; }

        [Inject]
        public EF2C Ef2c { get; set; }
    }
}
