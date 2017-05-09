using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelPro1.Model;

namespace ExcelPro1.DB
{
    class StaticValuesDBStrategy : DBStrategy
    {
        public void getPnL(ref Account[] arrayAccount)
        {
            int i = 0;
            arrayAccount[i++] = new Account("Budgeted", 882000, 484960, 28704);
            arrayAccount[i++] = new Account("Actual", 434250, 187271, 11887);
            arrayAccount[i++] = new Account("Remaining", 447750, 226399, 16817);
            arrayAccount[i++] = new Account("Forecast", 447750, 226399, 13684);
        }
        public void getTop5Customer(ref Customer[] arrayCustomer)
        {
            int i = 0;
            arrayCustomer[i++] = new Customer("Wallmart", 50000);
            arrayCustomer[i++] = new Customer("Big Bazar", 40000);
            arrayCustomer[i++] = new Customer("McDonald", 30000);
            arrayCustomer[i++] = new Customer("Burger King", 20000);
            arrayCustomer[i++] = new Customer("Kings Corner", 10000);

        }

        public void getTop5Items(ref Items[] arrayItems)
        {
            int i = 0;
            arrayItems[i++] = new Items("Item1", 50000);
            arrayItems[i++] = new Items("Item2", 40000);
            arrayItems[i++] = new Items("Item3", 30000);
            arrayItems[i++] = new Items("Item4", 20000);
            arrayItems[i++] = new Items("Item5", 10000);
        }

        public void getItemList(ref ItemList[] arrayItems)
        {
            ;
        }


        public void getCustomerList()
        {
            ;
        }


        public void updateItem()
        {
            ;
        }

        public bool addItem(ref ItemList itemlist)
        {
            return true;
        }


        public void updateCustomer()
        {
            ;
        }


    }
}
