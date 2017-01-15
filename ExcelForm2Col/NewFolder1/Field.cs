using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExcelForm2Col
{
    public class Field : IField
    {
        int _depth = -1;
        string _address;
        private int _firstColumn;
        private int _secondColumn;
        private int _firstRow;
        private int _secondRow;

        public string Address
        {
            get { return _address; }

            set
            {
                setAddress(value.ToUpper());
            }
        }

        public CellType CellType
        {
            get;

            set;
        }

        public string Name
        {
            get;

            set;
        }

        public int Depth => _depth;

        public int FirstColumn => _firstColumn;
        public int SecondColumn => _secondColumn;
        public int FirstRow => _firstRow;
        public int SecondRow => _secondRow;

        private void setAddress(string address)
        {
            address = address.Replace("$","");
            if (!address.Contains(":"))
            {
                _address = address;
                findColRow(address, out _firstColumn, out _firstRow);
                _secondColumn = _firstColumn;
                _secondRow = _firstRow;
                _depth = 1;
            }
            else
            {
                var bounds = address.Split(':');
                if (bounds.Length != 2) throw new MalformedRangeException("Address must be contain two part of range like \"A1:A20\"");
                
                findColRow(bounds[0], out _firstColumn, out _firstRow);
                findColRow(bounds[1], out _secondColumn, out _secondRow);
                if (_firstColumn != _secondColumn) throw new MalformedRangeException("Address must be a column ");
                //if (_firstRow!=_secondRow && _firstColumn!=_secondColumn) throw new MalformedRangeException("Address must be a column ");
                invert();
                _depth = _secondRow - _firstRow;
            }
        }

        private void findColRow(string bound,out int col,out int row)
        {
            string pattern = @"(?<=[a-zA-Z])(?=\d)";
            var colrow = Regex.Matches(bound, pattern, RegexOptions.IgnoreCase);
            var p = Regex.Split(bound, pattern);
            if (p.Length!= 2) throw new MalformedRangeException("Address must be formated as couple letters/numbers like \"C20\"");
            var _cols = p[0].ToCharArray();
            var _row = p[1].ToString().ToUpper();
            getCharsValue(_cols, out col);
            row = Int32.Parse(_row);
        }

        private void getCharsValue(char[] cols,out int value)
        {
            value = 0;
            for (int i = 0; i < cols.Count(); i++)
            {
                if (i > 0) value *= 26;
                value += cols[i]-64;
            }
        }

        private void invert()
        {
            if (_secondRow < _firstRow)
            {
                var tmp = _secondRow;
                _secondRow = _firstRow;
                _firstRow = tmp;
            }
            if (_secondColumn < _firstColumn)
            {
                var tmp = _secondColumn;
                _secondColumn = _firstColumn;
                _firstColumn = tmp;
            }
        }


    }
}
