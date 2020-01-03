using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class CHighQualityStudent : CObject
    {
        public CHighQualityStudent()
        {
            this.Handle = CManager.CreateRemoteObject("HighQualityStudent");

        }
    }
}