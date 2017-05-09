using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using Ribbon = Microsoft.Office.Tools.Ribbon;

namespace ExcelPro1
{
    public partial class ThisAddIn
    {
        public DashBrdUserControl dashboardUserControl;
        public Microsoft.Office.Tools.CustomTaskPane myCustomTaskPane;
        public MyExcelProRibbon myExcelProRibbon;

        public ItemUserControl1 itemUserControl;
        public Microsoft.Office.Tools.CustomTaskPane myItemCustomTaskPane;

        public UI.AddItemUserControl1 addItemUserControl;
        public Microsoft.Office.Tools.CustomTaskPane myAddItemCustomTaskPane;

        public DBStrategy dbStrategy;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

            dbStrategy = new SqliteDBStrategy();

            dashboardUserControl = new DashBrdUserControl(dbStrategy);
            myCustomTaskPane = this.CustomTaskPanes.Add(dashboardUserControl, "ExcelPro1");
            myCustomTaskPane.Width = 300;
            myCustomTaskPane.Visible = true;

            myCustomTaskPane.VisibleChanged += MyCustomTaskPane_VisibleChanged;

            itemUserControl = new ItemUserControl1(dbStrategy);
            myItemCustomTaskPane = this.CustomTaskPanes.Add(itemUserControl, "Item List");
            myItemCustomTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionBottom;
            myItemCustomTaskPane.Height = 350;
            myItemCustomTaskPane.Visible = false;
            

            addItemUserControl = new UI.AddItemUserControl1(dbStrategy);
            myAddItemCustomTaskPane = this.CustomTaskPanes.Add(addItemUserControl, "Add Item");
            myAddItemCustomTaskPane.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
            myAddItemCustomTaskPane.Width = 300;
            myAddItemCustomTaskPane.Visible = false;
        }

        private void MyCustomTaskPane_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            // Note: Outlook no longer raises this event. If you have code that 
            //    must run when Outlook shuts down, see https://go.microsoft.com/fwlink/?LinkId=506785
        }
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            myExcelProRibbon = new MyExcelProRibbon(); ;
            return myExcelProRibbon;
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
