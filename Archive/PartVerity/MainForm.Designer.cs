namespace PartVerity
{
    partial class MainForm
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
            this.txt_width = new System.Windows.Forms.TextBox();
            this.width_label = new System.Windows.Forms.Label();
            this.length_label = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.height_label = new System.Windows.Forms.Label();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.fillet_radius_label = new System.Windows.Forms.Label();
            this.txt_fillet_radius = new System.Windows.Forms.TextBox();
            this.hole_depth_label = new System.Windows.Forms.Label();
            this.txt_hole_depth = new System.Windows.Forms.TextBox();
            this.diameter_label = new System.Windows.Forms.Label();
            this.txt_diameter = new System.Windows.Forms.TextBox();
            this.material_label = new System.Windows.Forms.Label();
            this.txt_material = new System.Windows.Forms.TextBox();
            this.partverity_header = new System.Windows.Forms.Label();
            this.open_excel_sheet_button = new System.Windows.Forms.Button();
            this.modify_part_button = new System.Windows.Forms.Button();
            this.check_box_width = new System.Windows.Forms.CheckBox();
            this.check_box_length = new System.Windows.Forms.CheckBox();
            this.check_box_height = new System.Windows.Forms.CheckBox();
            this.check_box_material = new System.Windows.Forms.CheckBox();
            this.check_box_diameter = new System.Windows.Forms.CheckBox();
            this.check_box_hole_depth = new System.Windows.Forms.CheckBox();
            this.check_box_fillet_radius = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(58, 117);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(100, 22);
            this.txt_width.TabIndex = 1;
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width_label.Location = new System.Drawing.Point(29, 85);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(79, 29);
            this.width_label.TabIndex = 2;
            this.width_label.Text = "Width";
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.length_label.Location = new System.Drawing.Point(29, 161);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(92, 29);
            this.length_label.TabIndex = 4;
            this.length_label.Text = "Length";
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(58, 193);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(100, 22);
            this.txt_length.TabIndex = 3;
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_label.Location = new System.Drawing.Point(29, 251);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(89, 29);
            this.height_label.TabIndex = 6;
            this.height_label.Text = "Height";
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(58, 283);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(100, 22);
            this.txt_height.TabIndex = 5;
            // 
            // fillet_radius_label
            // 
            this.fillet_radius_label.AutoSize = true;
            this.fillet_radius_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fillet_radius_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillet_radius_label.Location = new System.Drawing.Point(214, 251);
            this.fillet_radius_label.Name = "fillet_radius_label";
            this.fillet_radius_label.Size = new System.Drawing.Size(160, 29);
            this.fillet_radius_label.TabIndex = 8;
            this.fillet_radius_label.Text = "Fillet Radius";
            // 
            // txt_fillet_radius
            // 
            this.txt_fillet_radius.Location = new System.Drawing.Point(243, 287);
            this.txt_fillet_radius.Name = "txt_fillet_radius";
            this.txt_fillet_radius.Size = new System.Drawing.Size(100, 22);
            this.txt_fillet_radius.TabIndex = 7;
            // 
            // hole_depth_label
            // 
            this.hole_depth_label.AutoSize = true;
            this.hole_depth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hole_depth_label.Location = new System.Drawing.Point(214, 161);
            this.hole_depth_label.Name = "hole_depth_label";
            this.hole_depth_label.Size = new System.Drawing.Size(144, 29);
            this.hole_depth_label.TabIndex = 10;
            this.hole_depth_label.Text = "Hole Depth";
            // 
            // txt_hole_depth
            // 
            this.txt_hole_depth.Location = new System.Drawing.Point(243, 197);
            this.txt_hole_depth.Name = "txt_hole_depth";
            this.txt_hole_depth.Size = new System.Drawing.Size(100, 22);
            this.txt_hole_depth.TabIndex = 9;
            // 
            // diameter_label
            // 
            this.diameter_label.AutoSize = true;
            this.diameter_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diameter_label.Location = new System.Drawing.Point(214, 85);
            this.diameter_label.Name = "diameter_label";
            this.diameter_label.Size = new System.Drawing.Size(119, 29);
            this.diameter_label.TabIndex = 12;
            this.diameter_label.Text = "Diameter";
            // 
            // txt_diameter
            // 
            this.txt_diameter.Location = new System.Drawing.Point(243, 117);
            this.txt_diameter.Name = "txt_diameter";
            this.txt_diameter.Size = new System.Drawing.Size(100, 22);
            this.txt_diameter.TabIndex = 11;
            // 
            // material_label
            // 
            this.material_label.AutoSize = true;
            this.material_label.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.material_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material_label.Location = new System.Drawing.Point(29, 335);
            this.material_label.Name = "material_label";
            this.material_label.Size = new System.Drawing.Size(107, 29);
            this.material_label.TabIndex = 14;
            this.material_label.Text = "Material";
            // 
            // txt_material
            // 
            this.txt_material.Location = new System.Drawing.Point(58, 367);
            this.txt_material.Name = "txt_material";
            this.txt_material.Size = new System.Drawing.Size(100, 22);
            this.txt_material.TabIndex = 13;
            // 
            // partverity_header
            // 
            this.partverity_header.AutoSize = true;
            this.partverity_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partverity_header.Location = new System.Drawing.Point(27, 21);
            this.partverity_header.Name = "partverity_header";
            this.partverity_header.Size = new System.Drawing.Size(191, 42);
            this.partverity_header.TabIndex = 15;
            this.partverity_header.Text = "PartVerity";
            // 
            // open_excel_sheet_button
            // 
            this.open_excel_sheet_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.open_excel_sheet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_excel_sheet_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.open_excel_sheet_button.Location = new System.Drawing.Point(420, 178);
            this.open_excel_sheet_button.Name = "open_excel_sheet_button";
            this.open_excel_sheet_button.Size = new System.Drawing.Size(212, 46);
            this.open_excel_sheet_button.TabIndex = 16;
            this.open_excel_sheet_button.Text = "Open Excel Sheet";
            this.open_excel_sheet_button.UseVisualStyleBackColor = false;
            this.open_excel_sheet_button.Click += new System.EventHandler(this.upload_excel_button_Click);
            // 
            // modify_part_button
            // 
            this.modify_part_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modify_part_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_part_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modify_part_button.Location = new System.Drawing.Point(420, 102);
            this.modify_part_button.Name = "modify_part_button";
            this.modify_part_button.Size = new System.Drawing.Size(212, 46);
            this.modify_part_button.TabIndex = 17;
            this.modify_part_button.Text = "Modify Part";
            this.modify_part_button.UseVisualStyleBackColor = false;
            this.modify_part_button.Click += new System.EventHandler(this.modify_part_button_Click);
            

            // 
            // check_box_width
            // 
            this.check_box_width.AutoSize = true;
            this.check_box_width.Location = new System.Drawing.Point(34, 117);
            this.check_box_width.Name = "check_box_width";
            this.check_box_width.Size = new System.Drawing.Size(18, 17);
            this.check_box_width.TabIndex = 18;
            this.check_box_width.UseVisualStyleBackColor = true;
            // 
            // check_box_length
            // 
            this.check_box_length.AutoSize = true;
            this.check_box_length.Location = new System.Drawing.Point(34, 197);
            this.check_box_length.Name = "check_box_length";
            this.check_box_length.Size = new System.Drawing.Size(18, 17);
            this.check_box_length.TabIndex = 19;
            this.check_box_length.UseVisualStyleBackColor = true;
            // 
            // check_box_height
            // 
            this.check_box_height.AutoSize = true;
            this.check_box_height.Location = new System.Drawing.Point(34, 287);
            this.check_box_height.Name = "check_box_height";
            this.check_box_height.Size = new System.Drawing.Size(18, 17);
            this.check_box_height.TabIndex = 20;
            this.check_box_height.UseVisualStyleBackColor = true;
            // 
            // check_box_material
            // 
            this.check_box_material.AutoSize = true;
            this.check_box_material.Location = new System.Drawing.Point(34, 371);
            this.check_box_material.Name = "check_box_material";
            this.check_box_material.Size = new System.Drawing.Size(18, 17);
            this.check_box_material.TabIndex = 21;
            this.check_box_material.UseVisualStyleBackColor = true;
            // 
            // check_box_diameter
            // 
            this.check_box_diameter.AutoSize = true;
            this.check_box_diameter.Location = new System.Drawing.Point(219, 117);
            this.check_box_diameter.Name = "check_box_diameter";
            this.check_box_diameter.Size = new System.Drawing.Size(18, 17);
            this.check_box_diameter.TabIndex = 22;
            this.check_box_diameter.UseVisualStyleBackColor = true;
            // 
            // check_box_hole_depth
            // 
            this.check_box_hole_depth.AutoSize = true;
            this.check_box_hole_depth.Location = new System.Drawing.Point(219, 198);
            this.check_box_hole_depth.Name = "check_box_hole_depth";
            this.check_box_hole_depth.Size = new System.Drawing.Size(18, 17);
            this.check_box_hole_depth.TabIndex = 23;
            this.check_box_hole_depth.UseVisualStyleBackColor = true;
            // 
            // check_box_fillet_radius
            // 
            this.check_box_fillet_radius.AutoSize = true;
            this.check_box_fillet_radius.Location = new System.Drawing.Point(219, 287);
            this.check_box_fillet_radius.Name = "check_box_fillet_radius";
            this.check_box_fillet_radius.Size = new System.Drawing.Size(18, 17);
            this.check_box_fillet_radius.TabIndex = 24;
            this.check_box_fillet_radius.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(665, 434);
            this.Controls.Add(this.check_box_fillet_radius);
            this.Controls.Add(this.check_box_hole_depth);
            this.Controls.Add(this.check_box_diameter);
            this.Controls.Add(this.check_box_material);
            this.Controls.Add(this.check_box_height);
            this.Controls.Add(this.check_box_length);
            this.Controls.Add(this.check_box_width);
            this.Controls.Add(this.modify_part_button);
            this.Controls.Add(this.open_excel_sheet_button);
            this.Controls.Add(this.partverity_header);
            this.Controls.Add(this.material_label);
            this.Controls.Add(this.txt_material);
            this.Controls.Add(this.diameter_label);
            this.Controls.Add(this.txt_diameter);
            this.Controls.Add(this.hole_depth_label);
            this.Controls.Add(this.txt_hole_depth);
            this.Controls.Add(this.fillet_radius_label);
            this.Controls.Add(this.txt_fillet_radius);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.length_label);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.txt_width);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label fillet_radius_label;
        private System.Windows.Forms.TextBox txt_fillet_radius;
        private System.Windows.Forms.Label hole_depth_label;
        private System.Windows.Forms.TextBox txt_hole_depth;
        private System.Windows.Forms.Label diameter_label;
        private System.Windows.Forms.TextBox txt_diameter;
        private System.Windows.Forms.Label material_label;
        private System.Windows.Forms.TextBox txt_material;
        private System.Windows.Forms.Label partverity_header;
        private System.Windows.Forms.Button open_excel_sheet_button;
        private System.Windows.Forms.Button modify_part_button;
        private System.Windows.Forms.CheckBox check_box_width;
        private System.Windows.Forms.CheckBox check_box_length;
        private System.Windows.Forms.CheckBox check_box_height;
        private System.Windows.Forms.CheckBox check_box_material;
        private System.Windows.Forms.CheckBox check_box_diameter;
        private System.Windows.Forms.CheckBox check_box_hole_depth;
        private System.Windows.Forms.CheckBox check_box_fillet_radius;
    }
}

