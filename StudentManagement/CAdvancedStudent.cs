using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class CAdvancedStudent : CObject
    {
        public CAdvancedStudent()
        {
            this.Handle = CManager.CreateRemoteObject("AdvancedStudent");
        }
    }
}