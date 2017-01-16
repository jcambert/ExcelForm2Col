using Ninject;
using ReactiveUI;
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

    public class Project: ReactiveObject, IProject
    {
        private string _name;
        public string Name { get { return _name; } set { this.RaiseAndSetIfChanged(ref _name, value); } }

        [Inject]
        public EF2C Ef2c { get; set; }
    }
}
