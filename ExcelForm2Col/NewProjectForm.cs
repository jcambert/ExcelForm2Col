using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelForm2Col
{
    public partial class NewProjectForm : Form
    {

        [Inject]
        public NewProjectForm(Project project)
        {
            InitializeComponent();
            Project = project;
            kryptonTextBox1.DataBindings.Add("Text", Project, "Name");
        }

        
        public Project Project { get; set; }

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
