using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Row : IEnumerable
    {
        protected Number[] _rowNumberCollection;

        protected int standardLength = 7;
        
        public IEnumerator GetEnumerator()
        {
            return _rowNumberCollection.GetEnumerator();
        }
    }
}