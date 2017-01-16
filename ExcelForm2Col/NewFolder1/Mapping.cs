using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public class Mapping : ReactiveObject, IMapping
    {
        private readonly Fields fields = new Fields();
        private readonly ReactiveList<string> names = new ReactiveList<string>();

        public Fields Fields => fields;

        //public List<string> Names => names;

        public void AddSheetName(String name)
        {
            if (names.Contains("*")) return;
            if (name.Equals("*"))
            {
                names.Clear();
                names.Add("*");
            }
            else
                names.Add(name);
        }

        public IEnumerable<string> SheetNames()
        {
            return names.AsEnumerable();
        }



    }
}
