using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class CObject
    {

        private int handle = 0;
        public object this[string sAttributeName]
        {
            get
            {
                return CManager.GetAttributeOfObject(Handle, sAttributeName);
            }
            set
            {
                CManager.SetAttributeOfObject(Handle, sAttributeName, value);
            }
        }

        protected int Handle
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

        internal void GetNotify(Post p)
        {
            CManager.GetNotify(Handle, p);
        }

        internal void Subscribe(Category group, string[] topics)
        {
            group.Join(this, topics);
        }

    }
}