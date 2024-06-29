import sys
import os
import pySW  # Ensure this is installed
import pandas as pd
from PySide6.QtWidgets import QApplication, QWidget, QVBoxLayout, QLabel, QLineEdit, QPushButton, QFileDialog, QMessageBox

class MainWindow(QWidget):
    def __init__(self):
        super().__init__()
        self.initUI()
        self.sw_app = None

    def initUI(self):
        self.setWindowTitle("PartVerity")
        self.setGeometry(100, 100, 300, 300)

        layout = QVBoxLayout()

        self.width_input = QLineEdit(self)
        self.width_input.setPlaceholderText("Width (mm)")
        layout.addWidget(self.width_input)

        self.height_input = QLineEdit(self)
        self.height_input.setPlaceholderText("Height (mm)")
        layout.addWidget(self.height_input)

        self.depth_input = QLineEdit(self)
        self.depth_input.setPlaceholderText("Depth (mm)")
        layout.addWidget(self.depth_input)

        self.diameter_input = QLineEdit(self)
        self.diameter_input.setPlaceholderText("Diameter (mm)")
        layout.addWidget(self.diameter_input)

        self.hole_depth_input = QLineEdit(self)
        self.hole_depth_input.setPlaceholderText("Hole Depth (mm)")
        layout.addWidget(self.hole_depth_input)

        self.fillet_radius_input = QLineEdit(self)
        self.fillet_radius_input.setPlaceholderText("Fillet Radius (mm)")
        layout.addWidget(self.fillet_radius_input)

        self.material_input = QLineEdit(self)
        self.material_input.setPlaceholderText("Material")
        layout.addWidget(self.material_input)

        upload_button = QPushButton("Upload Excel Data", self)
        upload_button.clicked.connect(self.upload_excel_data)
        layout.addWidget(upload_button)

        modify_button = QPushButton("Modify Part", self)
        modify_button.clicked.connect(self.modify_part)
        layout.addWidget(modify_button)

        self.setLayout(layout)

    def upload_excel_data(self):
        file_path, _ = QFileDialog.getOpenFileName(self, "Open Excel File", "", "Excel Files (*.xlsx)")
        if file_path:
            try:
                df = pd.read_excel(file_path)
                self.width_input.setText(str(df['Width'][0]))
                self.height_input.setText(str(df['Height'][0]))
                self.depth_input.setText(str(df['Depth'][0]))
                self.diameter_input.setText(str(df['Diameter'][0]))
                self.hole_depth_input.setText(str(df['Hole Depth'][0]))
                self.fillet_radius_input.setText(str(df['Fillet Radius'][0]))
                self.material_input.setText(str(df['Material'][0]))
            except Exception as e:
                QMessageBox.critical(self, "Error", f"Failed to upload Excel data: {e}")

    def modify_part(self):
        try:
            self.connect_to_solidworks()
            width = float(self.width_input.text())
            height = float(self.height_input.text())
            depth = float(self.depth_input.text())
            diameter = float(self.diameter_input.text())
            hole_depth = float(self.hole_depth_input.text())
            fillet_radius = float(self.fillet_radius_input.text())
            material = self.material_input.text()

            if self.sw_app is not None:
                self.sw_app.modify_part(width, height, depth, diameter, hole_depth, fillet_radius, material)
                QMessageBox.information(self, "Success", "Part modified successfully.")
            else:
                QMessageBox.critical(self, "Error", "Failed to connect to SolidWorks API.")
        except Exception as e:
            QMessageBox.critical(self, "Error", f"Error in modify_part: {e}")

    def connect_to_solidworks(self):
        try:
            self.sw_app = pySW.Connection()
            QMessageBox.information(self, "Connection Status", "Connected to SolidWorks API successfully.")
        except Exception as e:
            QMessageBox.critical(self, "Connection Error", f"Failed to connect to SolidWorks API: {e}")

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = MainWindow()
    window.show()
    sys.exit(app.exec())
