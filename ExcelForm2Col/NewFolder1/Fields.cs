using ReactiveUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public class Fields : ReactiveList<IField>
    {
        public void toto()
        {
            
        }
    }
  /*  public class Fields : IList<Field>, ICollection<Field>, IEnumerable<Field>, IEnumerable, IList, ICollection, IReadOnlyList<Field>, IReadOnlyCollection<Field>//, INotifyPropertyChanged
    {
        int _depth;
        private List<Field> ilist = new List<Field>();

        //public event PropertyChangedEventHandler PropertyChanged=delegate{};

        public Field this[int index]
        {
            get
            {
                return ilist[index];
            }

            set
            {
                if (value.Depth != _depth && this.Count > 0) throw new MalformedRangeException("Ranges must have all same row number");
                ilist[index] = value;
                _depth = value.Depth;
            }
        }

        object IList.this[int index]
        {
            get
            {
                return this[index] as Field;
            }

            set
            {
                this[index] =(Field) value;
            }
        }

        public int Count
        {
            get
            {
                return ilist.Count;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return ((IList)ilist).IsFixedSize;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return   ((IList)ilist).IsReadOnly;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return ((IList)ilist).IsSynchronized;
            }
        }

        public object SyncRoot
        {
            get
            {
                return ((IList)ilist).SyncRoot;
            }
        }

        public int Add(object value)
        {
            this.Add((Field)value);
            return ilist.IndexOf((Field)value);
        }

        public void Add(Field item)
        {
            if (item.Depth != _depth && this.Count > 0) throw new MalformedRangeException("Ranges must have all same row number");
            ilist.Add(item);
            _depth = item.Depth;
            //PropertyChanged(this, new PropertyChangedEventArgs("Fields"));
        }

        public void Clear()
        {
            ilist.Clear();
        }

        public bool Contains(object value)
        {
            return this.Contains((Field)value);
        }

        public bool Contains(Field item)
        {
            return ilist.Contains(item);
        }

        public void CopyTo(Array array, int index)
        {
            this.CopyTo((Field[] )array, index);
        }

        public void CopyTo(Field[] array, int arrayIndex)
        {
            ilist.CopyTo((Field[])array, arrayIndex);
        }

        public IEnumerator<Field> GetEnumerator()
        {
            return ilist.GetEnumerator();
        }

        public int IndexOf(object value)
        {
            return this.IndexOf((Field)value);
        }

        public int IndexOf(Field item)
        {
            return ilist.IndexOf(item);
        }

        public void Insert(int index, object value)
        {
            this.Insert(index, (Field)value);
        }

        public void Insert(int index, Field item)
        {
            ilist.Insert(index, item);
        }

        public void Remove(object value)
        {
            this.Remove((Field)value);
        }

        public bool Remove(Field item)
        {
            return ilist.Remove(item);
        }

        public void RemoveAt(int index)
        {
            ilist.RemoveAt(index);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ilist.GetEnumerator();
        }

        public List<Field> InternalList => ilist;
    }*/
}
