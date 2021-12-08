using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Row : IEnumerable, IEqualityComparer<Row>
    {
        protected Number[] _rowNumberCollection;
        protected string _id;
        protected int standardLength = 7;

        public bool Equals(Row x, Row y)
        {
            if (x == null && y == null) 
                return true;
            else if (x == null || y == null) 
                return false;
            else if (x._rowNumberCollection.Length != y._rowNumberCollection.Length) 
                return false;
            else if (x._id == y._id) 
                return true;
            else 
                return false;
        }

        public IEnumerator GetEnumerator()
        {
            return _rowNumberCollection.GetEnumerator();
        }

        public int GetHashCode([DisallowNull] Row obj)
        {
            return Convert.ToInt32(obj._id).GetHashCode();
        }
    }
}