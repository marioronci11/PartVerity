import pySW
import time

class SolidWorksApp:
    def __init__(self):
        self.swApp = pySW.Connection()

    def modify_part(self, width, height, depth, diameter, hole_depth, fillet_radius, material):
        model = self.swApp.ActiveDoc
        if model is None:
            raise RuntimeError("No active document found in SolidWorks.")

        # Modify dimensions
        self.modify_dimension(model, "Width", width / 1000)
        self.modify_dimension(model, "Height", height / 1000)
        self.modify_dimension(model, "Depth", depth / 1000)
        self.modify_dimension(model, "Diameter", diameter / 1000)
        self.modify_dimension(model, "HoleDepth", hole_depth / 1000)
        self.modify_dimension(model, "FilletRadius", fillet_radius / 1000)

        # Apply material
        model.SetMaterialPropertyName2("Default", None, material)
        model.EditRebuild3()

    def modify_dimension(self, model, dimension_name, value):
        dimension = model.Parameter(dimension_name)
        if dimension is not None:
            dimension.SystemValue = value
        else:
            raise RuntimeError(f"Dimension {dimension_name} not found.")
