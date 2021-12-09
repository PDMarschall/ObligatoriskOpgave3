using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality
{
    interface ICoupon
    {
        bool VerifyRow(IList<Row> previousRows, Row currentRow, int iteration);
    }
}
