using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Row
    {
        protected IList<Number> _rowNumberCollection;

        protected int standardLength = 7;

        protected string _id;
    }
}