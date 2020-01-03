using System;
using System.Collections.Generic;

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

        public override void GetNotify(Post p)
        {
            Console.WriteLine("User " + StudentName + " receives " + p.Content);
        }


        // KHONG DUOC IMPLEMENT O DAY : CHỈ CÓ HỌC SINH ĐÃ SUBSCRIBE + HỌC SINH THUỘC HỆ TƯƠNG ĐƯƠNG MÓI NHẬN ĐƯỢC THÔNG BÁO
        // HÃY IMPLEMENT Ở LỚP ĐÓ LUÔN  => vi phạm quy tắc solid

        //public override void Subscribe(Category category, string[] topics)
        //{

        //    category.Join(this, topics);
        //}



        //internal void Post(Category category, string content, string[] topics)
        //{
        //    category.AddPost(this, content,
        //        PrepareTopicDictionary(topics));
        //} chi co giao vu duoc phep post bai thong bao


    }
}