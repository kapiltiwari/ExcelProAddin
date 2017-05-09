using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using ExcelPro1.Model;

namespace ExcelPro1
{


    public partial class ItemUserControl1 : UserControl
    {
        DataGridView itemDBV;


        DBStrategy dbStrategy;
        public ItemUserControl1(DBStrategy _dbStrategy)
        {
            InitializeComponent();

            //dbStrategy = new SqliteDBStrategy();
            dbStrategy = _dbStrategy;

            InitializeGrid();
        }

        public void InitializeGrid()
        {
            label1.Text = "Item List";
            label1.ForeColor = Color.CornflowerBlue;
            label1.Font = new Font("Calibri", 18f, FontStyle.Bold);


            itemDBV = new DataGridView();

            // datagrid view attributes
            itemDBV.Dock = DockStyle.Fill;
            itemDBV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            itemDBV.AllowUserToAddRows = true;

            DataGridViewColumn itemName = new DataGridViewTextBoxColumn();
            itemName.HeaderText = "Field";
            itemDBV.Columns.Add(itemName);

            DataGridViewColumn sales = new DataGridViewTextBoxColumn();
            sales.HeaderText = "Field Text";
            itemDBV.Columns.Add(sales);

            DataGridViewColumn len = new DataGridViewTextBoxColumn();
            len.HeaderText = "Len";
            itemDBV.Columns.Add(len);

            DataGridViewColumn desc = new DataGridViewTextBoxColumn();
            desc.HeaderText = "Desc";
            itemDBV.Columns.Add(desc);


            //DataGridTextBoxColumn col3 = new DataGridTextBoxColumn();
            //col3.Header = "ProductName";
            //col3.Binding = new Binding("ProductName");
            //dataGrid1.Columns.Add(col3);

            ItemList[] arr_Items = new ItemList[100];

            // fetch DB Values
            //dbStrategy.getTop5Items(ref arr_Items);
            dbStrategy.getItemList(ref arr_Items);

            //int i = 0;
            foreach (ItemList item in arr_Items)
            {
                if (item == null || item.field == null)
                    break;

                DataGridViewRow r = new DataGridViewRow();
                DataGridViewTextBoxCell c = new DataGridViewTextBoxCell();
                c.Value = item.field;
                r.Cells.Add(c);

                DataGridViewTextBoxCell c1 = new DataGridViewTextBoxCell();
                c1.Value = item.itemText;
                r.Cells.Add(c1);

                DataGridViewTextBoxCell c2 = new DataGridViewTextBoxCell();
                c2.Value = item.len;
                r.Cells.Add(c2);

                DataGridViewTextBoxCell c3 = new DataGridViewTextBoxCell();
                c3.Value = item.desc;
                r.Cells.Add(c3);

                itemDBV.Rows.Add(r);
            }

            panel1.Controls.Add(itemDBV);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            InitializeGrid();
        }
    }
}
