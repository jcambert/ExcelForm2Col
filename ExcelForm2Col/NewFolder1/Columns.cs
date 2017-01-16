using ReactiveUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public class Columns:ReactiveList<IField>//, IEnumerable<Field>
    {
        Dictionary<IField, ReactiveList<object>> values = new Dictionary<IField, ReactiveList<object>>();
        
        public ReactiveList<object> this[IField field]{
            get
            {
                if (!values.Keys.Contains(field)) values[field] = new ReactiveList<object>();
                return values[field];
            }
            
        }

        public ReactiveList<object> ByName(string name)
        {
            var field = values.Keys.Where(k => k.Name.Equals(name)).FirstOrDefault();
            if (field == null)
                return new ReactiveList<object>();
            return values[field];
        }

    }
}
