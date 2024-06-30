using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Ribbon;

namespace SolidWorksExcelAddin
{
    public partial class SolidWorksRibbon: RibbonBase
    {
        private SldWorks swApp;

        private void SolidWorksRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            // Initialize SolidWorks application instance
            try
            {
                swApp = Activator.CreateInstance(Type.GetTypeFromProgID("SldWorks.Application")) as SldWorks;
                if (swApp == null)
                {
                    MessageBox.Show("Unable to connect to SolidWorks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    swApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize SolidWorks: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SolidWorksRibbon_Load2(object sender, RibbonUIEventArgs e)
        {
            swApp = new SldWorks();
        }

        private void btnBuildTemplate_Click(object sender, RibbonControlEventArgs e)
        {
            BuildTemplate();
        }

        private void btnCaptureModelData_Click(object sender, RibbonControlEventArgs e)
        {
            CaptureModelDataForm captureForm = new CaptureModelDataForm(swApp);
            captureForm.ShowDialog();
        }

        private void btnUploadReferenceFiles_Click(object sender, RibbonControlEventArgs e)
        {
            // Implement logic for uploading reference files
        }

        private void btnBuildModel_Click(object sender, RibbonControlEventArgs e)
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

        private void BuildSolidWorks()
        {
            try
            {
                Excel.Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
                int row = 2;
                while (true)
                {
                    string parameterName = activeSheet.Cells[row, 2].Value?.ToString();
                    if (string.IsNullOrEmpty(parameterName)) break;

                    double newValue = Convert.ToDouble(activeSheet.Cells[row, 4].Value) / 1000;

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

        private void btnBuildModel_Click_1(object sender, RibbonControlEventArgs e)
        {
            BuildSolidWorksModel();

        }

        private void BuildSolidWorksModel()
        {
            try
            {
                Excel.Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
                int row = 2;
                while (true)
                {
                    string parameterName = activeSheet.Cells[row, 2].Value?.ToString();
                    if (string.IsNullOrEmpty(parameterName)) break;

                    double newValue = Convert.ToDouble(activeSheet.Cells[row, 4].Value) / 1000;

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


        private void btnCaptureModelData_Click_1(object sender, RibbonControlEventArgs e)
        {
            CaptureModelDataForm captureForm = new CaptureModelDataForm(swApp);
            captureForm.ShowDialog();

        }


        private void btnBuildTemplate_Click_1(object sender, RibbonControlEventArgs e)
        {
            BuildTemplateExcel();

        }

        private void BuildTemplateExcel()
        {
            try
            {
                Excel.Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;

                if (activeSheet == null)
                {
                    MessageBox.Show("No active worksheet. Please open an Excel workbook and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Excel.Application excelApp = activeSheet.Application;
                excelApp.ScreenUpdating = false;
                excelApp.DisplayAlerts = false;

                activeSheet.Cells[1, 1].Value = "Command";
                activeSheet.Cells[1, 2].Value = "Name";
                activeSheet.Cells[1, 3].Value = "Parent";
                activeSheet.Cells[1, 4].Value = "Value 1";
                activeSheet.Cells[1, 5].Value = "Value 2";
                activeSheet.Cells[1, 6].Value = "Notes";

                excelApp.ScreenUpdating = true;
                excelApp.DisplayAlerts = true;

                MessageBox.Show("Template built.");
            }
            catch (System.Runtime.InteropServices.COMException comEx)
            {
                MessageBox.Show($"COM Exception: {comEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnUploadReferenceFiles_Click_1(object sender, RibbonControlEventArgs e)
        {

            MessageBox.Show("Upload Reference Files functionality not implemented yet.");


        }
    }
}
