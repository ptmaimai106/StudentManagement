using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement
{
    public class SManager
    {
        private static int NextAvailHandle = 1;
        static private Dictionary<int, SObject> objects = new Dictionary<int, SObject>();

        internal static int Register(SObject sObject)
        {
            int handle = NextAvailHandle++;
            objects.Add(handle, sObject);
            return handle;
        }
        public static object GetAttributeOfObject(int handle, string sAttributeName)
        {
            SObject obj = FindObjectByHandle(handle);
            if (obj != null)
                return obj.GetAttributeValue(sAttributeName);
            return null;
        }

        private static SObject FindObjectByHandle(int handle)
        {
            if (objects.ContainsKey(handle))
                return objects[handle];
            return null;
        }

        public static bool SetAttributeOfObject(int handle, string sAttributeName, object newValue)
        {
            SObject obj = FindObjectByHandle(handle);
            if (obj != null)
                return obj.SetAttributeValue(sAttributeName, newValue);
            return false;
        }

        public static int CreateObjectByClassName(string sClassName)
        {
            switch (sClassName)
            {
                case "NormalStudent": return new SStudent().Handle;
            }
            return 0;
        }
    }
}