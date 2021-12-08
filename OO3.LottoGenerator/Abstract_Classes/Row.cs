using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Row : IVerifiable<Row>
    {
        private IEnumerable<Number> _rowNumberCollection;

        private string _id;

        public Row()
        {
        
        }
                
        public abstract bool Verify(Row entity);
    }
}