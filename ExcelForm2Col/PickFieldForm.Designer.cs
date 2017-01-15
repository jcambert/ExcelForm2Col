namespace ExcelForm2Col
{
    partial class PickFieldForm
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
            this.excelRangeTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.okBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.okCmd = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.cancelBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cancelCmd = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.nameTxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.nameTxt);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.cancelBtn);
            this.kryptonPanel1.Controls.Add(this.okBtn);
            this.kryptonPanel1.Controls.Add(this.excelRangeTxt);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(398, 143);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(45, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Range";
            // 
            // excelRangeTxt
            // 
            this.excelRangeTxt.Location = new System.Drawing.Point(64, 11);
            this.excelRangeTxt.Name = "excelRangeTxt";
            this.excelRangeTxt.Size = new System.Drawing.Size(232, 23);
            this.excelRangeTxt.TabIndex = 1;
            this.excelRangeTxt.Text = "RANGE";
            // 
            // okBtn
            // 
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okBtn.KryptonCommand = this.okCmd;
            this.okBtn.Location = new System.Drawing.Point(64, 94);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 25);
            this.okBtn.TabIndex = 2;
            this.okBtn.Values.Text = "kryptonButton1";
            // 
            // okCmd
            // 
            this.okCmd.Text = "&Ok";
            this.okCmd.Execute += new System.EventHandler(this.okCmd_Execute);
            // 
            // cancelBtn
            // 
            this.cancelBtn.KryptonCommand = this.cancelCmd;
            this.cancelBtn.Location = new System.Drawing.Point(206, 94);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 25);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Values.Text = "kryptonButton1";
            // 
            // cancelCmd
            // 
            this.cancelCmd.Text = "&Annuler";
            this.cancelCmd.Execute += new System.EventHandler(this.cancelCmd_Execute);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(12, 40);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(38, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Nom";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(64, 40);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(232, 23);
            this.nameTxt.TabIndex = 5;
            this.nameTxt.Text = "NOM";
            // 
            // PickFieldForm
            // 
            this.AcceptButton = this.okBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.okBtn;
            this.ClientSize = new System.Drawing.Size(398, 143);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PickFieldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick a Field";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox excelRangeTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton cancelBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand cancelCmd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton okBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand okCmd;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox nameTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}