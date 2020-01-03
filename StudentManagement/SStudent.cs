using System;

namespace StudentManagement
{
    internal class SStudent : SObject
    {
        public string StudentID;
        public string StudentName;
        public double GPA;


        public override object GetAttributeValue(string sAttributeName)
        {
            switch (sAttributeName)
            {
                case "StudentID": return StudentID;
                case "StudentName": return StudentName;
                case "GPA": return GPA;
            }
            return null;
        }

        public override bool SetAttributeValue(string sAttributeName, object newValue)
        {
            try
            {
                switch (sAttributeName)
                {
                    case "StudentID":
                        StudentID = (string)newValue;
                        break;
                    case "StudentName":
                        StudentName = (string)newValue;
                        break;
                    case "GPA":
                        {
                            if ((((double)newValue) <= 10) &&
                                    (((double)newValue) >= 10))
                                GPA = (double)newValue;
                            else
                                return false;
                            break;
                        }
                }
                return true;
            }
            catch (Exception x)
            {
                return false;
            }
        }


    }
}