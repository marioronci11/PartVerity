import win32com.client

def test_solidworks_connection():
    try:
        swApp = win32com.client.Dispatch("SldWorks.Application")
        swApp.Visible = True
        print("SolidWorks API is accessible!")
    except Exception as e:
        print(f"Error: {e}")

if __name__ == "__main__":
    test_solidworks_connection()
