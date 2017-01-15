using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public class Columns:IEnumerable<Field>
    {
        Dictionary<Field, List<object>> values = new Dictionary<Field, List<object>>();
        
        public List<object> this[Field field]{
            get
            {
                if (!values.Keys.Contains(field)) values[field] = new List<object>();
                return values[field];
            }
            
        }

        public List<object> ByName(string name)
        {
            var field = values.Keys.Where(k => k.Name.Equals(name)).FirstOrDefault();
            if (field == null)
                return new List<object>();
            return values[field];
        }

        public IEnumerator<Field> GetEnumerator()
        {
            return values.Keys.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
