using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel_ = Microsoft.Office.Interop.Excel;
namespace ExcelForm2Col
{

    public interface IDestination
    {
        void Save(Columns columns);
    }
    public class Destination : IDestination
    {
        private readonly string _filename;
        private readonly string _sheetname;
        private readonly bool _addToExistingFile;
        private readonly bool _addToExistingSheet;
        Excel_.Workbook xlWorkbook;

        [Inject]
        public Excel_.Application Excel { get; set; }

        public Destination(string filename, string sheetname, bool addToExistingFile = true, bool addToExistingSheet = true)
        {
            this._filename = filename;
            this._sheetname = sheetname;
            this._addToExistingFile = addToExistingFile;
            this._addToExistingSheet = addToExistingSheet;
        }

        public void Save(Columns columns)
        {
            bool newFile;
            Excel_._Worksheet xlWorksheet;

            if (File.Exists(_filename) && !_addToExistingFile)
                File.Delete(_filename);

            newFile = !File.Exists(_filename);
            xlWorkbook = File.Exists(_filename) ? Excel.Workbooks.Open(_filename) : Excel.Workbooks.Add();
            try
            {
                if ( !_addToExistingSheet)
                    (xlWorkbook.Worksheets[_sheetname] as Excel_.Worksheet).Delete();
            }
            catch (Exception) { }

            try {
                xlWorksheet = xlWorkbook.Worksheets[_sheetname];
            }
            catch (Exception)
            {
                xlWorksheet = xlWorkbook.Worksheets.Add();
                xlWorksheet.Name = _sheetname;
            }
                

            int row = 1;
            int col = 1;
            
            foreach (var column in columns)
            {
                (xlWorksheet.Cells[row, col] as Excel_.Range).Value = column.Name;

                foreach (var line in columns[column])
                {
                    row++;
                    (xlWorksheet.Cells[row, col] as Excel_.Range).Value = line;

                }
                col++;
                row = 1;
            }
            if (newFile)
                xlWorkbook.SaveAs(_filename);
            else
                xlWorkbook.Save();
            xlWorkbook.Close();
            Excel.Quit();
        }
    }
}
