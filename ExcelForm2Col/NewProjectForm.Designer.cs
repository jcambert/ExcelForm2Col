namespace ExcelForm2Col
{
    partial class NewProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.okBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.okCmd = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.cancelCmd = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cancelBtn);
            this.kryptonPanel1.Controls.Add(this.okBtn);
            this.kryptonPanel1.Controls.Add(this.kryptonTextBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(426, 132);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(13, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Nom";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(58, 12);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(284, 23);
            this.kryptonTextBox1.TabIndex = 1;
            this.kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // okBtn
            // 
            this.okBtn.KryptonCommand = this.okCmd;
            this.okBtn.Location = new System.Drawing.Point(136, 67);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 25);
            this.okBtn.TabIndex = 2;
            this.okBtn.Values.Text = "Ok";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.KryptonCommand = this.cancelCmd;
            this.cancelBtn.Location = new System.Drawing.Point(252, 67);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 25);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Values.Text = "Ok";
            // 
            // okCmd
            // 
            this.okCmd.Text = "&Ok";
            this.okCmd.Execute += new System.EventHandler(this.okCmd_Execute);
            // 
            // cancelCmd
            // 
            this.cancelCmd.Text = "&Annuler";
            this.cancelCmd.Execute += new System.EventHandler(this.cancelCmd_Execute);
            // 
            // NewProjectForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(426, 132);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouveau Projet";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand cancelCmd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton okBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand okCmd;
    }
}