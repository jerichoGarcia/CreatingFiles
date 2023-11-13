using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmLab1
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);
    internal class RegistrationClass
    {
        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MidName = " ";
        public static string Birthday = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string Firstname)
        {
            return FirstName;
        }
        public static string GetLastName(string Lastname)
        {
            return LastName;
        }
        public static string GetMiddleName(string MidName)
        {
            return MidName;
        }
        public static string GetAddress(string Birthday)
        {
            return Birthday;
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }
    }
}
