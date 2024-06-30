namespace SolidWorksExcelAddin
{
    partial class SolidWorksRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SolidWorksRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SolidWorksBuild = this.Factory.CreateRibbonTab();
            this.GroupBuildModel = this.Factory.CreateRibbonGroup();
            this.btnBuildModel = this.Factory.CreateRibbonButton();
            this.GroupCaptureModelData = this.Factory.CreateRibbonGroup();
            this.btnCaptureModelData = this.Factory.CreateRibbonButton();
            this.GroupBuildTemplate = this.Factory.CreateRibbonGroup();
            this.btnBuildTemplate = this.Factory.CreateRibbonButton();
            this.GroupUploadReferenceFiles = this.Factory.CreateRibbonGroup();
            this.btnUploadReferenceFiles = this.Factory.CreateRibbonButton();
            this.SolidWorksBuild.SuspendLayout();
            this.GroupBuildModel.SuspendLayout();
            this.GroupCaptureModelData.SuspendLayout();
            this.GroupBuildTemplate.SuspendLayout();
            this.GroupUploadReferenceFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // SolidWorksBuild
            // 
            this.SolidWorksBuild.Groups.Add(this.GroupBuildModel);
            this.SolidWorksBuild.Groups.Add(this.GroupCaptureModelData);
            this.SolidWorksBuild.Groups.Add(this.GroupBuildTemplate);
            this.SolidWorksBuild.Groups.Add(this.GroupUploadReferenceFiles);
            this.SolidWorksBuild.Label = "SolidWorks Build";
            this.SolidWorksBuild.Name = "SolidWorksBuild";
            // 
            // GroupBuildModel
            // 
            this.GroupBuildModel.Items.Add(this.btnBuildModel);
            this.GroupBuildModel.Label = "group1";
            this.GroupBuildModel.Name = "GroupBuildModel";
            // 
            // btnBuildModel
            // 
            this.btnBuildModel.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnBuildModel.Image = global::SolidWorksExcelAddin.Properties.Resources._405e2c21b8c8ffb3642d00b3f5e98e98;
            this.btnBuildModel.Label = "Build Model";
            this.btnBuildModel.Name = "btnBuildModel";
            this.btnBuildModel.ShowImage = true;
            this.btnBuildModel.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnBuildModel_Click_1);
            // 
            // GroupCaptureModelData
            // 
            this.GroupCaptureModelData.Items.Add(this.btnCaptureModelData);
            this.GroupCaptureModelData.Label = "group2";
            this.GroupCaptureModelData.Name = "GroupCaptureModelData";
            // 
            // btnCaptureModelData
            // 
            this.btnCaptureModelData.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnCaptureModelData.Image = global::SolidWorksExcelAddin.Properties.Resources._6046044;
            this.btnCaptureModelData.Label = "Capture Model Data";
            this.btnCaptureModelData.Name = "btnCaptureModelData";
            this.btnCaptureModelData.ShowImage = true;
            this.btnCaptureModelData.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCaptureModelData_Click_1);
            // 
            // GroupBuildTemplate
            // 
            this.GroupBuildTemplate.Items.Add(this.btnBuildTemplate);
            this.GroupBuildTemplate.Label = "group 3";
            this.GroupBuildTemplate.Name = "GroupBuildTemplate";
            // 
            // btnBuildTemplate
            // 
            this.btnBuildTemplate.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnBuildTemplate.Image = global::SolidWorksExcelAddin.Properties.Resources.kisspng_microsoft_excel_table_computer_icons_spreadsheet_x_table_and_chair_5b15157a4517b2_534392681528108410283;
            this.btnBuildTemplate.Label = "Build Template";
            this.btnBuildTemplate.Name = "btnBuildTemplate";
            this.btnBuildTemplate.ShowImage = true;
            this.btnBuildTemplate.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnBuildTemplate_Click_1);
            // 
            // GroupUploadReferenceFiles
            // 
            this.GroupUploadReferenceFiles.Items.Add(this.btnUploadReferenceFiles);
            this.GroupUploadReferenceFiles.Label = "group4";
            this.GroupUploadReferenceFiles.Name = "GroupUploadReferenceFiles";
            // 
            // btnUploadReferenceFiles
            // 
            this.btnUploadReferenceFiles.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnUploadReferenceFiles.Image = global::SolidWorksExcelAddin.Properties.Resources._95405_folder_1024x1024;
            this.btnUploadReferenceFiles.Label = "Upload Reference Files";
            this.btnUploadReferenceFiles.Name = "btnUploadReferenceFiles";
            this.btnUploadReferenceFiles.ShowImage = true;
            this.btnUploadReferenceFiles.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnUploadReferenceFiles_Click_1);
            // 
            // SolidWorksRibbon
            // 
            this.Name = "SolidWorksRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.SolidWorksBuild);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SolidWorksRibbon_Load);
            this.SolidWorksBuild.ResumeLayout(false);
            this.SolidWorksBuild.PerformLayout();
            this.GroupBuildModel.ResumeLayout(false);
            this.GroupBuildModel.PerformLayout();
            this.GroupCaptureModelData.ResumeLayout(false);
            this.GroupCaptureModelData.PerformLayout();
            this.GroupBuildTemplate.ResumeLayout(false);
            this.GroupBuildTemplate.PerformLayout();
            this.GroupUploadReferenceFiles.ResumeLayout(false);
            this.GroupUploadReferenceFiles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab SolidWorksBuild;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupBuildModel;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupCaptureModelData;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupBuildTemplate;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GroupUploadReferenceFiles;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnBuildModel;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnCaptureModelData;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnBuildTemplate;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnUploadReferenceFiles;
    }

    partial class ThisRibbonCollection
    {
        internal SolidWorksRibbon SolidWorksRibbon
        {
            get { return this.GetRibbon<SolidWorksRibbon>(); }
        }
    }
}
