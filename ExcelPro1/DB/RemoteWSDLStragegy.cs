using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelPro1.Model;

namespace ExcelPro1
{
    class RemoteWSDLStragegy :DBStrategy
    {
        public void getPnL(ref Account[] arrayAccount)
        {
            ;
        }
        public void getTop5Customer(ref Customer[] arrayAccount)
        {
            ;
        }

        public void getTop5Items(ref Items[] arrayItems)
        {
            ;
        }

        public bool addItem (ref ItemList itemlist)
        {
           return true ;
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


        public void updateCustomer()
        {
            ;
        }
    }
}
