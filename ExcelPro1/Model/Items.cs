using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelPro1.Model
{
    public class Items
    {
        public string ItemName;
        public long Sales;

        public Items(string _ItemName, long _Sales)
        {
            this.ItemName = _ItemName;
            this.Sales = _Sales;
        }
    }

    public class ItemList
    {
        public string field;
        public string itemText;
        public int len;
        public string desc;

        public ItemList(string _field, string _itemText, int _len, string _desc)
        {
            this.field = _field;
            this.itemText = _itemText;
            this.len = _len;
            this.desc = _desc;
        }

    }
}
