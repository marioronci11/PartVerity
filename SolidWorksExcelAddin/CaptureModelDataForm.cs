using System;
using System.Windows.Forms;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using Excel = Microsoft.Office.Interop.Excel;

namespace SolidWorksExcelAddin
{
    public partial class CaptureModelDataForm : Form
    {
        private SldWorks swApp;

        public CaptureModelDataForm(SldWorks swApp)
        {
            InitializeComponent();
            this.swApp = swApp;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            CaptureModelData();
        }

        private void CaptureModelData()
        {
            try
            {
                ModelDoc2 swModel = (ModelDoc2)swApp.ActiveDoc;
                if (swModel == null)
                {
                    MessageBox.Show("No active document in SolidWorks. Please open a document first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] parameters = { "D1@Sketch1", "D2@Sketch1", "D1@Boss-Extrude1" };
                dataGridView1.Rows.Clear();
                foreach (var param in parameters)
                {
                    double dimensionValue = swModel.Parameter(param).SystemValue * 1000;
                    dataGridView1.Rows.Add(new object[] { "Add", param, dimensionValue });
                }
                MessageBox.Show("Model data captured.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error capturing model data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                AddDataToExcelTemplate(e.RowIndex);
            }
        }

        private void AddDataToExcelTemplate(int rowIndex)
        {
            try
            {
                Excel.Worksheet activeSheet = Globals.ThisAddIn.Application.ActiveSheet;
                var row = dataGridView1.Rows[rowIndex];
                string paramName = row.Cells[1].Value.ToString();
                double paramValue = Convert.ToDouble(row.Cells[2].Value);

                int excelRow = 2;
                while (activeSheet.Cells[excelRow, 2].Value != null)
                {
                    excelRow++;
                }

                activeSheet.Cells[excelRow, 2].Value = paramName;
                activeSheet.Cells[excelRow, 4].Value = paramValue;
                MessageBox.Show("Data added to Excel template.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding data to Excel template: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
