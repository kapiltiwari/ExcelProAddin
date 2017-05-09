using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelPro1.Model;

namespace ExcelPro1
{
    public interface DBStrategy
    {
        void getPnL(ref Account[] arrayAccount);

        void getTop5Customer(ref Customer[] arrayAccount);

        void getTop5Items(ref Items [] arrayItems);

        void getItemList(ref ItemList[] arrayItems);

        void getCustomerList();

        void updateItem();

        bool addItem(ref ItemList itemlist);

        void updateCustomer();
    }
}
