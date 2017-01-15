using Ninject;
using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel_ = Microsoft.Office.Interop.Excel;
namespace ExcelForm2Col
{
    public interface IEF2C : IDisposable
    {
        SourceType SourceType { get; set; }
        string Source { get; set; }
        IMapping Mapping { get; set; }
        Excel_.Application Excel { get; set; }
        Columns Columns { get; }
        void Start();
    }

    public class EF2C : IEF2C
    {
        Columns columns = new Columns();
        
        public SourceType SourceType { get; set; }

        public string Source { get; set; }

        [Inject]
        public IMapping Mapping { get; set; }

        [Inject]
        public Excel_.Application Excel { get; set; }

        [Inject]
        public ILogger Logger { get; set; }

        public Columns Columns => columns;
        /*public async void StartAsync()
        {
            await Task.Factory.StartNew(() => Start());

        }*/

        public void Start()
        {
            Excel_.Workbook xlWorkbook;
            Excel.WorkbookOpen += Excel_WorkbookOpen;
            foreach (var file in GetFiles())
            {
                xlWorkbook = Excel.Workbooks.Open(file);
                
                readWorkbook(xlWorkbook);
                xlWorkbook.Close(false);
            }
        }

        private void readWorkbook(Excel_.Workbook xlWorkbook)
        {
            //   Excel_._Worksheet xlWorksheet;

            foreach (var xlWorksheet in GetWorksheet(xlWorkbook))
            {
                Logger.Debug("Sheet:"+ xlWorksheet.Name + " was opened");
                readWorksheet(xlWorksheet);

            }
        }

        private void readWorksheet(Excel_._Worksheet xlWorksheet)
        {
            foreach (var field in Mapping.Fields)
            {
                readField(xlWorksheet, field);
            }
        }

        private void readField(Excel_._Worksheet xlWorksheet, Field field)
        {
            var range = xlWorksheet.Range[field.Address];
            if (field.Address.Contains(":"))
            {
                int rowCount, colCount;
                rowCount = range.Rows.Count;
                colCount = range.Columns.Count;

                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < colCount; j++)
                    {
                        var r = range.Cells[i+1, j+1];
                        var value = ( r as Excel_.Range).Value;
                        Columns[field].Add(value);
                    }
                }
            }
            else
            {
                
                var value = range.Cells.Value;
                Columns[field].Add(value);
            }
        }

        private void Excel_WorkbookOpen(Excel_.Workbook Wb)
        {
            Logger.Debug("Sheet:" + Wb.Name + " was opened");
        }

        private List<string> GetFiles()
        {
            List<string> files = new List<string>();
            if (SourceType == SourceType.Directory)
            {
                files = Directory.EnumerateFiles(Source,"*.xlsx").ToList();
            }
            else
            {
                files.Add(Source);
            }
            return files;
        }


        private IEnumerable<Excel_._Worksheet> GetWorksheet(Excel_.Workbook Wb)
        {
            foreach (var sheetName in Mapping.SheetNames())
            {
                if (sheetName.Equals("*"))
                    foreach (var sheet in Wb.Worksheets)
                    {
                        yield return sheet as Excel_._Worksheet;
                    }
                else
                    yield return Wb.Worksheets[sheetName];
            }
            yield break;
        }

        public void Dispose()
        {
          //  if (Excel != null) Excel.ActiveWorkbook.Close(false);
            Excel.Quit();
        }
    }
}
