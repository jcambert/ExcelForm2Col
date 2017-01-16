namespace ExcelForm2Col
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.fieldRibbonTab = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.chooseExcelFileCmd = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.kryptonRibbonGroupButton4 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.pickFieldCmd = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.chooseExcelFileBtn = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines();
            this.pickFieldBtn = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.ribbon = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.newProjectCmd = new ComponentFactory.Krypton.Toolkit.KryptonCommand();
            this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableNavigator1 = new ComponentFactory.Krypton.Docking.KryptonDockableNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).BeginInit();
            this.kryptonDockableNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldRibbonTab
            // 
            this.fieldRibbonTab.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.fieldRibbonTab.Text = "Outils";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1,
            this.chooseExcelFileBtn,
            this.pickFieldBtn});
            this.kryptonRibbonGroup1.TextLine1 = "Champs";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton3,
            this.kryptonRibbonGroupButton4});
            // 
            // kryptonRibbonGroupButton3
            // 
            this.kryptonRibbonGroupButton3.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton3.ImageLarge")));
            this.kryptonRibbonGroupButton3.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton3.ImageSmall")));
            this.kryptonRibbonGroupButton3.KryptonCommand = this.chooseExcelFileCmd;
            // 
            // chooseExcelFileCmd
            // 
            this.chooseExcelFileCmd.ImageLarge = ((System.Drawing.Image)(resources.GetObject("chooseExcelFileCmd.ImageLarge")));
            this.chooseExcelFileCmd.ImageSmall = ((System.Drawing.Image)(resources.GetObject("chooseExcelFileCmd.ImageSmall")));
            this.chooseExcelFileCmd.Execute += new System.EventHandler(this.chooseExcelFileCmd_Execute);
            // 
            // kryptonRibbonGroupButton4
            // 
            this.kryptonRibbonGroupButton4.ImageLarge = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton4.ImageLarge")));
            this.kryptonRibbonGroupButton4.ImageSmall = ((System.Drawing.Image)(resources.GetObject("kryptonRibbonGroupButton4.ImageSmall")));
            this.kryptonRibbonGroupButton4.KryptonCommand = this.pickFieldCmd;
            // 
            // pickFieldCmd
            // 
            this.pickFieldCmd.ImageLarge = ((System.Drawing.Image)(resources.GetObject("pickFieldCmd.ImageLarge")));
            this.pickFieldCmd.ImageSmall = ((System.Drawing.Image)(resources.GetObject("pickFieldCmd.ImageSmall")));
            this.pickFieldCmd.Text = "kryptonCommand1";
            this.pickFieldCmd.Execute += new System.EventHandler(this.pickField_Execute);
            // 
            // chooseExcelFileBtn
            // 
            this.chooseExcelFileBtn.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Large;
            // 
            // ribbon
            // 
            this.ribbon.InDesignHelperMode = true;
            this.ribbon.Name = "ribbon";
            this.ribbon.RibbonAppButton.AppButtonMenuItems.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            this.ribbon.RibbonAppButton.AppButtonText = "Fichier";
            this.ribbon.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.fieldRibbonTab});
            this.ribbon.SelectedContext = null;
            this.ribbon.SelectedTab = this.fieldRibbonTab;
            this.ribbon.Size = new System.Drawing.Size(450, 143);
            this.ribbon.TabIndex = 0;
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.KryptonCommand = this.newProjectCmd;
            this.kryptonContextMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.kryptonContextMenuItem1.Text = "Nouveau";
            // 
            // newProjectCmd
            // 
            this.newProjectCmd.Text = "Nouveau";
            this.newProjectCmd.Execute += new System.EventHandler(this.newProjectCmd_Execute);
            // 
            // openExcelFileDialog
            // 
            this.openExcelFileDialog.Filter = "Excel | *.xlsx";
            this.openExcelFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openExcelFileDialog_FileOk);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonDockableNavigator1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 143);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(450, 351);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonDockableNavigator1
            // 
            this.kryptonDockableNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonDockableNavigator1.Name = "kryptonDockableNavigator1";
            this.kryptonDockableNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonDockableNavigator1.SelectedIndex = 1;
            this.kryptonDockableNavigator1.Size = new System.Drawing.Size(450, 351);
            this.kryptonDockableNavigator1.TabIndex = 1;
            this.kryptonDockableNavigator1.Text = "kryptonDockableNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.dataGridView2);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(448, 324);
            this.kryptonPage1.Text = "Pages";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "6BE6BBA4A9AD4BDF538BE8F923CDB6BB";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(448, 324);
            this.dataGridView2.TabIndex = 0;
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.dataGridView1);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(448, 324);
            this.kryptonPage2.Text = "Champs";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "B8A372FE6FE24191B3A7F66B912BD290";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 494);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.ribbon);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableNavigator1)).EndInit();
            this.kryptonDockableNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab fieldRibbonTab;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon ribbon;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand newProjectCmd;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupLines chooseExcelFileBtn;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple pickFieldBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand chooseExcelFileCmd;
        private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
        private ComponentFactory.Krypton.Toolkit.KryptonCommand pickFieldCmd;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Docking.KryptonDockableNavigator kryptonDockableNavigator1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

