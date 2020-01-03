using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class CNormalStudent : CObject
    {
        public CNormalStudent() {
            this.Handle = CManager.CreateRemoteObject("NormalStudent");

        }


    }
}