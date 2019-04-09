using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.AbstractProperties
{
    abstract class AbsPropertiesClass
    {
        protected int myNumber;
        public abstract int numbers
        {
            get;
            set;
        }
    }

    class AbsPropertiesDerived : AbsPropertiesClass
    {
        //Implementing abstract properties
        public override int numbers
        {
            get
            {
                return myNumber;
            }
            set
            {
                myNumber = value;
            }
        }
    }
}
