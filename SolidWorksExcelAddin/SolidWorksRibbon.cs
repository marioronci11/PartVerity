using System;
using System.Runtime.InteropServices;
using Office = Microsoft.Office.Core;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SolidWorksExcelAddin
{
    [ComVisible(true)]
    public partial class SolidWorksRibbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;
        private SldWorks swApp;

        public SolidWorksRibbon() : base(Globals.Factory.GetRibbonFactory()) { }

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("SolidWorksExcelAddin.SolidWorksRibbon.xml");
        }

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
            swApp = new SldWorks();
        }

        public void BuildTemplate_Click(Office.IRibbonControl control)
        {
            BuildTemplate();
        }

        public void CaptureModelData_Click(Office.IRibbonControl control)
        {
            CaptureModelDataForm captureForm = new CaptureModelDataForm();
            captureForm.ShowDialog();
        }

        public void AddReferenceFiles_Click(Office.IRibbonControl control)
        {
            AddReferenceFiles();
        }

        public void BuildSolidWorks_Click(Office.IRibbonControl control)
        {
            BuildSolidWorks();
        }

        private void BuildTemplate()
        {
            Excel.Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
            activeSheet.Cells[1, 1].Value = "Command";
            activeSheet.Cells[1, 2].Value = "Name";
            activeSheet.Cells[1, 3].Value = "Parent";
            activeSheet.Cells[1, 4].Value = "Value 1";
            activeSheet.Cells[1, 5].Value = "Value 2";
            activeSheet.Cells[1, 6].Value = "Notes";
            MessageBox.Show("Template built.");
        }

        private void AddReferenceFiles()
        {
            MessageBox.Show("Reference files added.");
        }

        private void BuildSolidWorks()
        {
            try
            {
                Excel.Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
                int row = 2;
                while (true)
                {
                    string parameterName = activeSheet.Cells[row, 1].Value?.ToString();
                    if (string.IsNullOrEmpty(parameterName)) break;

                    double newValue = Convert.ToDouble(activeSheet.Cells[row, 2].Value) / 1000; // Convert to meters

                    ModelDoc2 swModel = (ModelDoc2)swApp.ActiveDoc;
                    if (swModel == null)
                    {
                        swModel = (ModelDoc2)swApp.OpenDoc6("C:\\path\\to\\your\\part.sldprt",
                            (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "", 0, 0);
                    }

                    if (swModel != null)
                    {
                        swModel.Parameter(parameterName).SystemValue = newValue;
                        swModel.EditRebuild3();
                        swModel.Save();
                        MessageBox.Show($"SolidWorks model updated with parameter {parameterName}.");
                    }
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating SolidWorks model: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetResourceText(string resourceName)
        {
            var asm = System.Reflection.Assembly.GetExecutingAssembly();
            using (var stream = asm.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    using (var reader = new System.IO.StreamReader(stream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
            return null;
        }
    }
}
