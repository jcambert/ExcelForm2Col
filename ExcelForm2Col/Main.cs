using ComponentFactory.Krypton.Ribbon;
using Ninject;
using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Windows.Forms;
using Excel_ = Microsoft.Office.Interop.Excel;
namespace ExcelForm2Col
{
    public partial class Main : Form
    {
        Excel_.Workbook wbk;
        Excel_.Worksheet wsht;
        public class Person
        {
            public string Name { get; set; }
        }
        [Inject]
        public Main(IProject project)
        {
            InitializeComponent();
            Project = project;
            
        }
        [Inject]
        public IKernel Kernel { get; set; }

        [Inject]
        public Excel_.Application Excel { get; set; }

        [Inject]
        public ILogger Logger { get; set; }

        
        public IProject Project { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*var wbk = Excel.Workbooks.Add();
            Excel.Visible = true;
            wbk.Activate();
            Excel_.Worksheet s = wbk.ActiveSheet;
            s.SelectionChange += S_SelectionChange;*/

            //dataGridView1.AutoGenerateColumns = true;
            Project.Ef2c.Mapping.Fields.CountChanged.Subscribe(ev => {
                Logger.Debug("Datagrid Count change to:" + ev);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Project.Ef2c.Mapping.Fields;
            });

            Project.Ef2c.Mapping.Fields.Add(new Field { Address = "E7", Name = "test7", CellType = CellType.Chaine });
            Project.Ef2c.Mapping.Fields.Add(new Field { Address = "E8", Name = "test8", CellType = CellType.Chaine });

            List<Person> persons = new List<Person>();
            persons.Add(new Person { Name = "AMBERT" });
            dataGridView2.DataSource = persons;

            persons.Add(new Person { Name = "GUINDER" });

            Project.Ef2c.Mapping.Fields.Add(new Field { Address = "E9", Name = "test9", CellType = CellType.Chaine });
           
        }

       

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Excel.Quit();
        }

        private void newProjectCmd_Execute(object sender, EventArgs e)
        {
            NewProjectForm frm =Kernel.Get<NewProjectForm>();
            Project project;
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                project = frm.Project;
            }
            
            
        }

        private void chooseExcelFileCmd_Execute(object sender, EventArgs e)
        {
            openExcelFileDialog.ShowDialog();
        }

        private void openExcelFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (e.Cancel) return;
            wbk=Excel.Workbooks.Open(openExcelFileDialog.FileName);
            Excel.Visible = true;
            
           /* var sheetChange= Observable.FromEventPattern<Excel_.WorkbookEvents_SheetChangeEventHandler>(wbk, "SheetChange");
            sheetChange.Subscribe(s => {
                Logger.Debug("toto");
            });*/
           
        }

        private void pickField_Execute(object sender, EventArgs e)
        {
            PickFieldForm frm = Kernel.Get<PickFieldForm>();
            frm.SetWorkbook(wbk);
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
               // Project.Ef2c.Mapping.Fields.Add(new Field { Address = "E9", Name = "test9", CellType = CellType.Chaine });
                Project.Ef2c.Mapping.Fields.Add(frm.Field);
            }
        }
    }
}
