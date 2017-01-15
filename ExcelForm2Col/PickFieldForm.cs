using Ninject;
using Ninject.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel_ = Microsoft.Office.Interop.Excel;
namespace ExcelForm2Col
{
    public partial class PickFieldForm : Form
    {
        Excel_.Workbook wbk;
        Excel_.Worksheet wsht;

        [Inject]
        public PickFieldForm(IField field)
        {
            InitializeComponent();
            Field = field;
            excelRangeTxt.DataBindings.Add("Text", Field, "Address");
            nameTxt.DataBindings.Add("Text", Field, "Name");
        }
        [Inject]
        public ILogger Logger { get; set; }


        public IField Field { get; set; }

        public void SetWorkbook(Excel_.Workbook wbk)
        {
            if (wbk != null)
            {
                this.wbk = wbk;
                wbk.SheetActivate += Wbk_SheetActivate;
                wsht = wbk.ActiveSheet;
                wsht.SelectionChange += Wsht_SelectionChange;
            }
        }
        private void Wbk_SheetActivate(object sh)
        {
            Logger.Debug("Sheet activate to:" + ((Excel_.Worksheet)sh).Name);
            if (wsht != null) wsht.SelectionChange -= Wsht_SelectionChange;
            wsht = (Excel_.Worksheet)sh;
            wsht.SelectionChange += Wsht_SelectionChange;
        }

        private void Wsht_SelectionChange(Excel_.Range Target)
        {
            Logger.Debug("Sheet selection changed to:" + Target.Value);
            excelRangeTxt.InvokeIfRequired(() => {
                excelRangeTxt.Text = Target.Address;
            });
            
        }

        private void okCmd_Execute(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Visible = false;
        }

        private void cancelCmd_Execute(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Visible = false;
        }
    }
}
