using System;
using System.Windows;
using System.Windows.Controls;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using ControlzEx;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace PartVerity
{
    public partial class MainForm : Window
    {
        private SldWorks swApp;
        private ModelDoc2 swModel;

        public MainForm()
        {
            InitializeComponent();
            InitializeSolidWorks();
        }

        private void InitializeSolidWorks()
        {
            try
            {
                swApp = new SldWorks();
                swApp.Visible = true;
                swModel = (ModelDoc2)swApp.ActiveDoc;
                if (swModel == null)
                {
                    MessageBox.Show("No active document found in SolidWorks. Please open a part file.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing SolidWorks: {ex.Message}");
            }
        }

        private void modify_part_button_Click(object sender, RoutedEventArgs e)
        {
            if (swModel == null)
            {
                MessageBox.Show("No active document found in SolidWorks.");
                return;
            }

            try
            {
                if (check_box_width.IsChecked == true && !string.IsNullOrEmpty(txt_width.Text))
                {
                    ModifyPartDimension("Width", txt_width.Text);
                }
                // Repeat for other dimensions...

                swModel.EditRebuild3();
                MessageBox.Show("Part modified successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void upload_excel_button_Click(object sender, RoutedEventArgs e)
        {
            // Implement Excel upload functionality
        }

        private void LoadExcelData(string filePath)
        {
            // Implement Excel data loading using NPOI or other library
        }

        private void ModifyPartDimension(string dimensionName, string value)
        {
            if (double.TryParse(value, out double dimensionValue))
            {
                var feature = swModel.FeatureByName(dimensionName);
                if (feature != null)
                {
                    var dimension = feature.GetFirstDimension();
                    if (dimension != null)
                    {
                        dimension.SystemValue = dimensionValue / 1000.0; // Convert mm to meters
                    }
                }
            }
        }

        private void ModifyPartMaterial(string materialName)
        {
            try
            {
                var materialDb = swApp.GetMaterialDatabaseNames();
                foreach (var db in materialDb)
                {
                    var materialList = swApp.GetMaterialNames(db);
                    if (materialList != null && materialList.Contains(materialName))
                    {
                        bool result = swModel.SetMaterialPropertyName2("", db, materialName);
                        if (result)
                        {
                            MessageBox.Show($"Material changed to {materialName} successfully.");
                            return;
                        }
                    }
                }
                MessageBox.Show($"Material {materialName} not found in any database.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing material: {ex.Message}");
            }
        }
    }
}
