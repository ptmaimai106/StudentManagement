using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public abstract class SObject
    {
        private int handle;
        public int Handle
        {
            get
            {
                return handle;
            }

            set
            {
                handle = value;
            }
        }

        public SObject()
        {
            Handle = SManager.Register(this);
        }

        public virtual object GetAttributeValue(string sAttributeName)
        {
            return null;
        }

        public virtual bool SetAttributeValue(string sAttributeName, object newValue)
        {
            return true;
        }
    }
}