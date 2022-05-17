using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniversalReferenceDataEditor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.splitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colIsTask = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tableDataGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sqlEditControl = new DevExpress.XtraRichEdit.RichEditControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.mFile = new DevExpress.XtraBars.BarSubItem();
            this.iNew = new DevExpress.XtraBars.BarButtonItem();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iClose = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.mHelp = new DevExpress.XtraBars.BarSubItem();
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.commonBar1 = new DevExpress.XtraRichEdit.UI.CommonBar();
            this.undoItem1 = new DevExpress.XtraRichEdit.UI.UndoItem();
            this.redoItem1 = new DevExpress.XtraRichEdit.UI.RedoItem();
            this.fileNewItem1 = new DevExpress.XtraRichEdit.UI.FileNewItem();
            this.fileOpenItem1 = new DevExpress.XtraRichEdit.UI.FileOpenItem();
            this.fileSaveItem1 = new DevExpress.XtraRichEdit.UI.FileSaveItem();
            this.fileSaveAsItem1 = new DevExpress.XtraRichEdit.UI.FileSaveAsItem();
            this.quickPrintItem1 = new DevExpress.XtraRichEdit.UI.QuickPrintItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.maxResultLimitBarItem = new DevExpress.XtraBars.BarEditItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.fileInfoBar1 = new DevExpress.XtraRichEdit.UI.FileInfoBar();
            this.showDocumentPropertiesFormItem1 = new DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.printItem1 = new DevExpress.XtraRichEdit.UI.PrintItem();
            this.printPreviewItem1 = new DevExpress.XtraRichEdit.UI.PrintPreviewItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.updateButton = new DevExpress.XtraEditors.SimpleButton();
            this.DatabaseBand = new DevExpress.XtraTreeList.Columns.TreeListBand();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.richEditBarController1 = new DevExpress.XtraRichEdit.UI.RichEditBarController(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).BeginInit();
            this.splitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.repositoryItemSpinEdit2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.IsFloatValue = false;
            this.repositoryItemSpinEdit2.Mask.EditMask = "N00";
            this.repositoryItemSpinEdit2.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // splitContainerControl
            // 
            this.splitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl.Location = new System.Drawing.Point(0, 106);
            this.splitContainerControl.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainerControl.Name = "splitContainerControl";
            this.splitContainerControl.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerControl.Panel1.Controls.Add(this.treeList1);
            this.splitContainerControl.Panel1.Text = "Panel1";
            this.splitContainerControl.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl.Panel2.Text = "Panel2";
            this.splitContainerControl.Size = new System.Drawing.Size(1292, 652);
            this.splitContainerControl.SplitterPosition = 277;
            this.splitContainerControl.TabIndex = 0;
            this.splitContainerControl.Text = "splitContainerControl1";
            // 
            // treeList1
            // 
            this.treeList1.Appearance.Caption.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeList1.Appearance.Caption.Options.UseFont = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIsTask,
            this.colName});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = this.databaseBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.FixedLineWidth = 1;
            this.treeList1.HorzScrollStep = 2;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Margin = new System.Windows.Forms.Padding(2);
            this.treeList1.MinWidth = 16;
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(277, 646);
            this.treeList1.TabIndex = 0;
            this.treeList1.TreeLevelWidth = 12;
            // 
            // colIsTask
            // 
            this.colIsTask.FieldName = "IsTask";
            this.colIsTask.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colIsTask.ImageOptions.SvgImage")));
            this.colIsTask.MinWidth = 16;
            this.colIsTask.Name = "colIsTask";
            this.colIsTask.OptionsColumn.AllowEdit = false;
            this.colIsTask.Visible = true;
            this.colIsTask.VisibleIndex = 0;
            this.colIsTask.Width = 50;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("colName.ImageOptions.SvgImage")));
            this.colName.MinWidth = 16;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 50;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(UniversalReferenceDataEditor.Database);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainerControl2.Panel1.Controls.Add(this.tableDataGrid);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.panelControl1);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(977, 646);
            this.splitContainerControl2.SplitterPosition = 271;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl1";
            // 
            // tableDataGrid
            // 
            this.tableDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableDataGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.tableDataGrid.Location = new System.Drawing.Point(0, 0);
            this.tableDataGrid.MainView = this.gridView1;
            this.tableDataGrid.Margin = new System.Windows.Forms.Padding(1);
            this.tableDataGrid.Name = "tableDataGrid";
            this.tableDataGrid.Size = new System.Drawing.Size(971, 271);
            this.tableDataGrid.TabIndex = 0;
            this.tableDataGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.Gray;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.Azure;
            this.gridView1.Appearance.OddRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gridView1.DetailHeight = 182;
            this.gridView1.FixedLineWidth = 1;
            this.gridView1.GridControl = this.tableDataGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl2);
            this.panelControl1.Controls.Add(this.updateButton);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(1);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(971, 337);
            this.panelControl1.TabIndex = 1;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.labelControl3);
            this.layoutControl2.Controls.Add(this.simpleButton1);
            this.layoutControl2.Controls.Add(this.sqlEditControl);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(2, 2);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2573, 552, 975, 890);
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(887, 333);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(12, 308);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(863, 13);
            this.labelControl3.StyleController = this.layoutControl2;
            this.labelControl3.TabIndex = 11;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 247);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(863, 42);
            this.simpleButton1.StyleController = this.layoutControl2;
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "&Execute!";
            this.simpleButton1.Click += new System.EventHandler(this.ExecuteSqlButtonClick);
            // 
            // sqlEditControl
            // 
            this.sqlEditControl.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.sqlEditControl.Appearance.Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sqlEditControl.Appearance.Text.BackColor2 = System.Drawing.Color.Gray;
            this.sqlEditControl.Appearance.Text.Font = new System.Drawing.Font("Consolas", 12F);
            this.sqlEditControl.Appearance.Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sqlEditControl.Appearance.Text.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sqlEditControl.Appearance.Text.Options.UseBackColor = true;
            this.sqlEditControl.Appearance.Text.Options.UseFont = true;
            this.sqlEditControl.Appearance.Text.Options.UseForeColor = true;
            this.sqlEditControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.sqlEditControl.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.sqlEditControl.Location = new System.Drawing.Point(73, 12);
            this.sqlEditControl.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.sqlEditControl.Margin = new System.Windows.Forms.Padding(2);
            this.sqlEditControl.MenuManager = this.barManager;
            this.sqlEditControl.Name = "sqlEditControl";
            this.sqlEditControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.sqlEditControl.Options.Printing.PrintPreviewFormKind = DevExpress.XtraRichEdit.PrintPreviewFormKind.Bars;
            this.sqlEditControl.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.sqlEditControl.Size = new System.Drawing.Size(802, 231);
            this.sqlEditControl.TabIndex = 5;
            this.sqlEditControl.Text = "sqlEditControl";
            this.sqlEditControl.Views.DraftView.AllowDisplayLineNumbers = true;
            this.sqlEditControl.Views.SimpleView.AdjustColorsToSkins = true;
            this.sqlEditControl.Views.SimpleView.AllowDisplayLineNumbers = true;
            this.sqlEditControl.Views.SimpleView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sqlEditControl.Views.SimpleView.Padding = new System.Windows.Forms.Padding(5, 4, 4, 0);
            this.sqlEditControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1KeyDown);
            this.sqlEditControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1KeyPress);
            this.sqlEditControl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1KeyUp);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.commonBar1,
            this.fileInfoBar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mFile,
            this.barButtonItem2,
            this.iOpen,
            this.iClose,
            this.iNew,
            this.iSave,
            this.iSaveAs,
            this.iExit,
            this.mHelp,
            this.iAbout,
            this.barToolbarsListItem1,
            this.undoItem1,
            this.redoItem1,
            this.fileNewItem1,
            this.fileOpenItem1,
            this.fileSaveItem1,
            this.fileSaveAsItem1,
            this.quickPrintItem1,
            this.printItem1,
            this.printPreviewItem1,
            this.showDocumentPropertiesFormItem1,
            this.barButtonItem1,
            this.barCheckItem1,
            this.barStaticItem1,
            this.maxResultLimitBarItem,
            this.barStaticItem2,
            this.barHeaderItem1});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 29;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.mHelp)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // mFile
            // 
            this.mFile.Caption = "&File";
            this.mFile.Id = 0;
            this.mFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.iOpen),
            new DevExpress.XtraBars.LinkPersistInfo(this.iClose),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSaveAs),
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1)});
            this.mFile.Name = "mFile";
            // 
            // iNew
            // 
            this.iNew.Caption = "&New";
            this.iNew.Id = 6;
            this.iNew.Name = "iNew";
            // 
            // iOpen
            // 
            this.iOpen.Caption = "&Open";
            this.iOpen.Id = 4;
            this.iOpen.Name = "iOpen";
            // 
            // iClose
            // 
            this.iClose.Caption = "&Close";
            this.iClose.Id = 5;
            this.iClose.Name = "iClose";
            // 
            // iSave
            // 
            this.iSave.Caption = "&Save";
            this.iSave.Id = 7;
            this.iSave.Name = "iSave";
            // 
            // iSaveAs
            // 
            this.iSaveAs.Caption = "Save &As";
            this.iSaveAs.Id = 8;
            this.iSaveAs.Name = "iSaveAs";
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.Id = 9;
            this.iExit.Name = "iExit";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Print";
            this.barStaticItem1.Id = 25;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // mHelp
            // 
            this.mHelp.Caption = "&Help";
            this.mHelp.Id = 10;
            this.mHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iAbout)});
            this.mHelp.Name = "mHelp";
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.Id = 11;
            this.iAbout.Name = "iAbout";
            // 
            // commonBar1
            // 
            this.commonBar1.Control = this.sqlEditControl;
            this.commonBar1.DockCol = 0;
            this.commonBar1.DockRow = 1;
            this.commonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.commonBar1.FloatLocation = new System.Drawing.Point(1126, 210);
            this.commonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.undoItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.redoItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.fileNewItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "N", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.fileOpenItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "O", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.fileSaveItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "S", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.fileSaveAsItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "A", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.quickPrintItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barCheckItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.maxResultLimitBarItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2)});
            // 
            // undoItem1
            // 
            this.undoItem1.Id = 13;
            this.undoItem1.Name = "undoItem1";
            // 
            // redoItem1
            // 
            this.redoItem1.Id = 14;
            this.redoItem1.Name = "redoItem1";
            // 
            // fileNewItem1
            // 
            this.fileNewItem1.Id = 15;
            this.fileNewItem1.Name = "fileNewItem1";
            // 
            // fileOpenItem1
            // 
            this.fileOpenItem1.Id = 16;
            this.fileOpenItem1.Name = "fileOpenItem1";
            this.fileOpenItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.fileOpenItem1_ItemClick);
            // 
            // fileSaveItem1
            // 
            this.fileSaveItem1.Id = 17;
            this.fileSaveItem1.Name = "fileSaveItem1";
            this.fileSaveItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.fileSaveItem1_ItemClick);
            // 
            // fileSaveAsItem1
            // 
            this.fileSaveAsItem1.Id = 18;
            this.fileSaveAsItem1.Name = "fileSaveAsItem1";
            this.fileSaveAsItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.fileSaveAsItem1_ItemClick);
            // 
            // quickPrintItem1
            // 
            this.quickPrintItem1.Id = 19;
            this.quickPrintItem1.Name = "quickPrintItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 23;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1_ItemClick);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "Apply MaxRow To Custom Query";
            this.barCheckItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.AfterText;
            this.barCheckItem1.Id = 24;
            this.barCheckItem1.Name = "barCheckItem1";
            this.barCheckItem1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckItem1_CheckedChanged);
            // 
            // maxResultLimitBarItem
            // 
            this.maxResultLimitBarItem.Caption = "maxResultLimitBarItem";
            this.maxResultLimitBarItem.Edit = this.repositoryItemSpinEdit2;
            this.maxResultLimitBarItem.Id = 26;
            this.maxResultLimitBarItem.Name = "maxResultLimitBarItem";
            this.maxResultLimitBarItem.Size = new System.Drawing.Size(200, 0);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Max Row Count";
            this.barStaticItem2.Id = 27;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // fileInfoBar1
            // 
            this.fileInfoBar1.Control = this.sqlEditControl;
            this.fileInfoBar1.DockCol = 1;
            this.fileInfoBar1.DockRow = 1;
            this.fileInfoBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.fileInfoBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.showDocumentPropertiesFormItem1)});
            this.fileInfoBar1.Offset = 611;
            // 
            // showDocumentPropertiesFormItem1
            // 
            this.showDocumentPropertiesFormItem1.Id = 22;
            this.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 33);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlTop.Size = new System.Drawing.Size(1292, 73);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 758);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlBottom.Size = new System.Drawing.Size(1292, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 106);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 652);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1292, 106);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(1);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 652);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Open";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 12;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // printItem1
            // 
            this.printItem1.Id = 20;
            this.printItem1.Name = "printItem1";
            // 
            // printPreviewItem1
            // 
            this.printPreviewItem1.Id = 21;
            this.printPreviewItem1.Name = "printPreviewItem1";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 28;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(887, 333);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 281);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(867, 15);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.sqlEditControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(867, 235);
            this.layoutControlItem5.Text = "Custom Sql";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(58, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.simpleButton1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 235);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(867, 46);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl3;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 296);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(867, 17);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // updateButton
            // 
            this.updateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.updateButton.Location = new System.Drawing.Point(889, 2);
            this.updateButton.Margin = new System.Windows.Forms.Padding(1);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 333);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "&Apply";
            this.updateButton.Click += new System.EventHandler(this.ApplyChanges);
            // 
            // DatabaseBand
            // 
            this.DatabaseBand.Caption = "Databases";
            this.DatabaseBand.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DatabaseBand.ImageOptions.SvgImage")));
            this.DatabaseBand.Name = "DatabaseBand";
            this.DatabaseBand.Width = 224;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(12, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(398, 19);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Rows";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 19);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Return top ";
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.textEdit1.Location = new System.Drawing.Point(152, 35);
            this.textEdit1.MenuManager = this.barManager;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(142, 50);
            this.textEdit1.TabIndex = 2;
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 106);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1292, 652);
            this.fluentDesignFormContainer1.TabIndex = 5;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1292, 33);
            this.fluentDesignFormControl1.TabIndex = 7;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.skinDropDownButtonItem1);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 0;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            this.skinDropDownButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // richEditBarController1
            // 
            this.richEditBarController1.BarItems.Add(this.undoItem1);
            this.richEditBarController1.BarItems.Add(this.redoItem1);
            this.richEditBarController1.BarItems.Add(this.fileNewItem1);
            this.richEditBarController1.BarItems.Add(this.fileOpenItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveItem1);
            this.richEditBarController1.BarItems.Add(this.fileSaveAsItem1);
            this.richEditBarController1.BarItems.Add(this.quickPrintItem1);
            this.richEditBarController1.BarItems.Add(this.printItem1);
            this.richEditBarController1.BarItems.Add(this.printPreviewItem1);
            this.richEditBarController1.BarItems.Add(this.showDocumentPropertiesFormItem1);
            this.richEditBarController1.Control = this.sqlEditControl;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 758);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.splitContainerControl);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResizeBegin += new System.EventHandler(this.Form1ResizeBegin);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl)).EndInit();
            this.splitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iClose;
        private DevExpress.XtraBars.BarButtonItem iNew;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iSaveAs;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarSubItem mHelp;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraGrid.GridControl tableDataGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarToolbarsListItem barToolbarsListItem1;
        private PanelControl panelControl1;
        private SimpleButton updateButton;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private LabelControl labelControl1;
        private LabelControl labelControl2;
        private SpinEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraRichEdit.RichEditControl sqlEditControl;
        private DevExpress.XtraRichEdit.UI.CommonBar commonBar1;
        private DevExpress.XtraRichEdit.UI.UndoItem undoItem1;
        private DevExpress.XtraRichEdit.UI.RedoItem redoItem1;
        private DevExpress.XtraRichEdit.UI.FileNewItem fileNewItem1;
        private DevExpress.XtraRichEdit.UI.FileOpenItem fileOpenItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveItem fileSaveItem1;
        private DevExpress.XtraRichEdit.UI.FileSaveAsItem fileSaveAsItem1;
        private DevExpress.XtraRichEdit.UI.QuickPrintItem quickPrintItem1;
        private DevExpress.XtraRichEdit.UI.PrintItem printItem1;
        private DevExpress.XtraRichEdit.UI.PrintPreviewItem printPreviewItem1;
        private DevExpress.XtraRichEdit.UI.FileInfoBar fileInfoBar1;
        private DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem showDocumentPropertiesFormItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController1;
        private SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DevExpress.XtraTreeList.Columns.TreeListBand DatabaseBand;
        private DevExpress.Data.UnboundSource unboundSource1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsTask;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private BindingSource databaseBindingSource;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem maxResultLimitBarItem;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private LabelControl labelControl3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
