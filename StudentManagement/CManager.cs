using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class CManager
    {
        internal static object GetAttributeOfObject(int handle, string sAttributeName)
        {
            return SManager.GetAttributeOfObject(handle, sAttributeName);

        }

        internal static void SetAttributeOfObject(int handle, string sAttributeName, object value)
        {
            SManager.SetAttributeOfObject(handle, sAttributeName, value);

        }

        internal static int CreateRemoteObject(string sClassName)
        {
            return SManager.CreateObjectByClassName(sClassName);
        }


    }
}