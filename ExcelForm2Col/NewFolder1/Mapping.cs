using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public class Mapping : IMapping
    {
        private readonly Fields fields = new Fields();
        private readonly List<string> names = new List<string>();

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
