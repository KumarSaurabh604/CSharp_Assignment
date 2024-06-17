using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_dec_5
{
    class Program
    {
        static void Main(string[] args)
        {
            UserData user = new UserData();
            //user.Data();

            simpleInterest simp = new simpleInterest();
            //simp.Interest();

            Student stud = new Student();
            //stud.StudentData();

            Patient pat = new Patient();
            pat.PatientData();



        }
    }
}
