using System.Collections.Generic;
using OO3.Lottery_Functionality.Abstract_Classes;

namespace OO3.Lottery_Functionality
{
    public interface ICoupon
    {
        bool VerifyRow(IList<Row> previousRows, Row currentRow, int iteration);
    }
}
