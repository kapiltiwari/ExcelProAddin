using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelPro1.Model
{
    public class Customer
    {
        public string CustName;
        public long Order;

        public Customer(string _CustName, long _Order)
        {
            this.CustName = _CustName;
            this.Order = _Order;
        }
    }
}
