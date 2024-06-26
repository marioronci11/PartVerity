import sys

# Add paths to the DLLs and site-packages
sys.path.append(r"C:\Users\Mario\Documents\GitHub\PartVerity\partverity-env\Lib\site-packages")
sys.path.append(r"C:\Users\Mario\Documents\GitHub\PartVerity\partverity-env\Lib\site-packages\pywin32_system32")

# Verify that the DLLs are loaded
try:
    import pythoncom
    import pywintypes
except ImportError as e:
    print("Failed to import pythoncom or pywintypes:", e)
    sys.exit(1)

# Import win32com.client after setting up the paths
try:
    import win32com.client
except ImportError as e:
    print("Failed to import win32com.client:", e)
    sys.exit(1)

def open_solidworks():
    try:
        swApp = win32com.client.Dispatch("SldWorks.Application")
        swApp.Visible = True
        print("SolidWorks API is working!")
    except Exception as e:
        print("Error accessing SolidWorks API:", e)

if __name__ == "__main__":
    open_solidworks()
