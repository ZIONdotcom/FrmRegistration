using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FrmRegistration
{
    internal class StudentInfoClass
    {
        
        public delegate BigInteger DelegateNumber(BigInteger number);
        public delegate String DelegateText(String txt);

        public static String FirstName = " ";
        public static String LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static BigInteger Age = 0;
        public static BigInteger ContactNo = 0;
        public static BigInteger StudentNo = 0;

        public static string GetFirstName(String Firstname)
        {
            return FirstName;
        }

        public static string GetLastNmae(String Lastname)
        {
            return LastName;
        }
        public static string GetMiddleName(String MiddleName)
        {
            return MiddleName;
        }
        public static string GetAddress(String Address) {  return Address; }
        public static string GetProgram(String Program) {  return Program; }

        public static BigInteger GetAge(BigInteger Age) { return Age; }
        public static BigInteger GetContactNo(BigInteger ContactNo) { return ContactNo; }
        public static BigInteger GetStudentNo(BigInteger StudentNo) { return StudentNo; }



    }
}
