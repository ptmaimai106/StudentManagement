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
            sv["StudentName"] = "PHAN THI MAI";
            Console.WriteLine(sv["StudentName"]);

            CAdvancedStudent sv1 = new CAdvancedStudent();
            sv1["MSSV"] = "1612345";
            sv1["StudentName"] = "PHAN THI MAI";
            Console.WriteLine(sv1["StudentName"]);

            CHighQualityStudent sv2 = new CHighQualityStudent();
            sv2["MSSV"] = "1612345";
            sv2["StudentName"] = "PHAN THI MAI";
            Console.WriteLine(sv2["StudentName"]);

        }
    }
}
