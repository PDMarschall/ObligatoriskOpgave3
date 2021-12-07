using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO3.Lottery_Functionality.Abstract_Classes
{
    public abstract class Row : IVerifiable<Row>
    {
        private Number[] rowArray = new Number[7];

        public Row()
        {

        }

        public abstract Row Generate();
        public abstract bool Verify(Row entity);
    }
}
