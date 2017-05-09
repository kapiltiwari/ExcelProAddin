using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using ExcelPro1.Model;


namespace ExcelPro1.UI
{
    public partial class AddItemUserControl1 : UserControl
    {
        DBStrategy dbStrategy;
        //DataGridView itemDBV;

        public AddItemUserControl1(DBStrategy _dbStrategy)
        {
            InitializeComponent();

            //dbStrategy = new SqliteDBStrategy();
            dbStrategy = _dbStrategy;

            //InitializeGrid();
        }

        public void InitializeGrid()
        {

            ItemList[] arr_Items = new ItemList[10];

            // fetch DB Values
            //dbStrategy.getTop5Items(ref arr_Items);
            dbStrategy.getItemList(ref arr_Items);

            //panel1.Controls.Add(itemDBV);
        }

        private void btn_SaveItem_Click(object sender, EventArgs e)
        {
            int result;
            Int32.TryParse(tb_len.Text, out result);
            ItemList it = new ItemList(tb_field.Text, tb_fieldText.Text, result, tb_desc.Text);
            bool bRes = dbStrategy.addItem(ref it);

            if (bRes)
            {
                MessageBox.Show("Item added successfully.");
            }
            else
                MessageBox.Show("Failed to add Item.");
        }

        private void tb_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_len_TextChanged(object sender, EventArgs e)
        {

        }

        private void Len_Click(object sender, EventArgs e)
        {

        }

        private void tb_fieldText_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }
    }
}
