using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            CNormalStudent sv = new CNormalStudent();
            sv["MSSV"] = "1612345";
            sv["StudentName"] = "PHAN THI MAI 1";
            Console.WriteLine(sv["StudentName"]);

            CAdvancedStudent sv1 = new CAdvancedStudent();
            sv1["MSSV"] = "1612345";
            sv1["StudentName"] = "PHAN THI MAI 2";
            Console.WriteLine(sv1["StudentName"]);

            CHighQualityStudent sv2 = new CHighQualityStudent();
            sv2["MSSV"] = "1612345";
            sv2["StudentName"] = "PHAN THI MAI 3";
            Console.WriteLine(sv2["StudentName"]);


            Category g1, g2;
            g1 = new Category("Scholarship");
            g2 = new Category("Travel");

            sv.Subscribe(g2, new string[] { "Food" });
            sv1.Subscribe(g1, new string[] { "Food", "Book" });
            sv2.Subscribe(g2, new string[] { "Food", "  Scholarship" });

            Staff staff = new Staff();
            Dictionary<string, int> p1 = staff.PrepareTopicDictionary(new string[] { "Australia", "Full scholarship" });
            g2.AddPost("abc", p1);
            g1.AddPost("xyz", p1);










        }
    }
}
