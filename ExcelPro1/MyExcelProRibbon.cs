using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Office = Microsoft.Office.Core;

// TODO:  Follow these steps to enable the Ribbon (XML) item:

// 1: Copy the following code block into the ThisAddin, ThisWorkbook, or ThisDocument class.

//  protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
//  {
//      return new MyExcelProRibbon();
//  }

// 2. Create callback methods in the "Ribbon Callbacks" region of this class to handle user
//    actions, such as clicking a button. Note: if you have exported this Ribbon from the Ribbon designer,
//    move your code from the event handlers to the callback methods and modify the code to work with the
//    Ribbon extensibility (RibbonX) programming model.

// 3. Assign attributes to the control tags in the Ribbon XML file to identify the appropriate callback methods in your code.  

// For more information, see the Ribbon XML documentation in the Visual Studio Tools for Office Help.


namespace ExcelPro1
{
    [ComVisible(true)]
    public class MyExcelProRibbon : Office.IRibbonExtensibility
    {
        private Office.IRibbonUI ribbon;

        public MyExcelProRibbon()
        {
        }

        #region IRibbonExtensibility Members

        public string GetCustomUI(string ribbonID)
        {
            return GetResourceText("ExcelPro1.MyExcelProRibbon.xml");
        }

        #endregion

        #region Ribbon Callbacks
        //Create callback methods here. For more information about adding callback methods, visit https://go.microsoft.com/fwlink/?LinkID=271226

        public void Ribbon_Load(Office.IRibbonUI ribbonUI)
        {
            this.ribbon = ribbonUI;
        }

        public Bitmap getImages(Office.IRibbonControl control)
        {
            if (control.Id == "viewDashboardButton")
                return Properties.Resources.dashboard_images; // resource Bitmap
            else if (control.Id == "viewItemButton")
                return Properties.Resources._002_book; // resource Bitmap
            else if (control.Id == "addItemButton")
                return Properties.Resources._003_signs; // resource Bitmap
            else if (control.Id == "searchItemButton")
                return Properties.Resources._001_search; // resource Bitmap
            else
                return Properties.Resources._001_search; // resource Bitmap

        }


        public void OnViewDashboardButton(Office.IRibbonControl control)
        {
            Globals.ThisAddIn.myItemCustomTaskPane.Visible = false;
            Globals.ThisAddIn.myCustomTaskPane.Visible = !Globals.ThisAddIn.myCustomTaskPane.Visible;
            Globals.ThisAddIn.myAddItemCustomTaskPane.Visible = false;
        }

        public void OnViewItemButton(Office.IRibbonControl control)
        {
            //Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            //currentRange.Text = "This text was added by the Ribbon.";
            Globals.ThisAddIn.myCustomTaskPane.Visible = false;
            Globals.ThisAddIn.myItemCustomTaskPane.Visible = true;
            Globals.ThisAddIn.myAddItemCustomTaskPane.Visible = false;

        }

        public void OnAddItemButton(Office.IRibbonControl control)
        {
            Globals.ThisAddIn.myCustomTaskPane.Visible = false;
            Globals.ThisAddIn.myItemCustomTaskPane.Visible = false;
            Globals.ThisAddIn.myAddItemCustomTaskPane.Visible = true;
        }

        public void OnSearchItemButton(Office.IRibbonControl control)
        {
            //Word.Range currentRange = Globals.ThisAddIn.Application.Selection.Range;
            //currentRange.Text = "This text was added by the Ribbon.";
        }

        #endregion

        #region Helpers

        private static string GetResourceText(string resourceName)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            string[] resourceNames = asm.GetManifestResourceNames();
            for (int i = 0; i < resourceNames.Length; ++i)
            {
                if (string.Compare(resourceName, resourceNames[i], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    using (StreamReader resourceReader = new StreamReader(asm.GetManifestResourceStream(resourceNames[i])))
                    {
                        if (resourceReader != null)
                        {
                            return resourceReader.ReadToEnd();
                        }
                    }
                }
            }
            return null;
        }

        #endregion
    }
}
