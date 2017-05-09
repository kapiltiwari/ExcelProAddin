using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelPro1.Model
{
    public class Account
    {
        public string AcName;
        public long Revenue;
        public long Cost;
        public long Hours;

        public Account(string _AcName, long _Revenue, long _Cost, long _Hours)
        {
            this.AcName = _AcName;
            this.Revenue = _Revenue;
            this.Cost = _Cost;
            this.Hours = _Hours;
        }
    }
}
