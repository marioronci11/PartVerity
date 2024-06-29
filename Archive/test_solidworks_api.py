import sys
import os

# Add paths to the DLLs
sys.path.append(r"C:\Users\Mario\Documents\GitHub\PartVerity\partverity-env\Lib\site-packages")
sys.path.append(r"C:\Users\Mario\Documents\GitHub\PartVerity\partverity-env\Lib\site-packages\pywin32_system32")

import win32com.client

def open_solidworks():
    try:
        swApp = win32com.client.Dispatch("SldWorks.Application")
        swApp.Visible = True
        print("SolidWorks API is working!")
    except Exception as e:
        print("Error accessing SolidWorks API:", e)

if __name__ == "__main__":
    open_solidworks()