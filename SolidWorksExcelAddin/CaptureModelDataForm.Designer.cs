namespace SolidWorksExcelAddin
{
    partial class CaptureModelDataForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCapture = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.paramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(12, 12);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 75);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnAdd,
            this.paramName,
            this.paramValue});
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(344, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.HeaderText = "Add";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ReadOnly = true;
            this.btnAdd.Text = "+";
            this.btnAdd.UseColumnTextForButtonValue = true;
            // 
            // paramName
            // 
            this.paramName.HeaderText = "Name";
            this.paramName.Name = "paramName";
            this.paramName.ReadOnly = true;
            // 
            // paramValue
            // 
            this.paramValue.HeaderText = "Value";
            this.paramValue.Name = "paramValue";
            this.paramValue.ReadOnly = true;
            // 
            // CaptureModelDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 253);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCapture);
            this.Name = "CaptureModelDataForm";
            this.Text = "Capture Model Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramName;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramValue;
    }
}
