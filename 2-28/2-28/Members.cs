using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_28
{
    class Members
    {
        private int MemberID;
        public int RenewalID;
        public string MemberNumber;
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Email;
        public string Phone;
        public string Gender;
        public DateTime StartDate;
        public int CurrentFlag;
        public DateTime Birtdate;

        public Members()
        {
            MemberID = 1;
            RenewalID = 4;
            MemberNumber = "M0001";
            FirstName = "Otis";
            MiddleName = "Brooke";
            LastName = "Fallon";
            Email = "bfallon0@artisteer.com";
            Phone = "818-873-3863";
            Gender = "Male";
            StartDate = DateTime.Parse("2017-04-07");
            CurrentFlag = 1;
            Birtdate = DateTime.Parse("1971-06-29");
        }

        public Members(int id, int rid, string mn, string fn, string min, string ln, string em, string pn,
                        string gen, DateTime sd, int cur, DateTime bd)
        {
            MemberID = id;
            RenewalID = rid;
            MemberNumber = mn;
            FirstName = fn;
            MiddleName = min;
            LastName = ln;
            Email = em;
            Phone = pn;
            Gender = gen;
            StartDate = sd;
            CurrentFlag = cur;
            Birtdate = bd;
        }

        public void MemberMessage()
        {
            Console.WriteLine(@"Welcome member #{0}! Glad to see you with us today!
Please comfirm the following information:
    RenewalID = {1}
    Member Number = {2}
    First Name = {3}
    Middle Name = {4}
    Last Name = {5}
    Email = {6}
    Phone Number = {7}
    Gender = {8}
    Member Since: {9}
    Current(1 = Yes, 0 = No): {10}
    Born on: {11}", MemberID, RenewalID, MemberNumber, FirstName, MiddleName, LastName, Email, Phone,
                    Gender, StartDate.ToString("yyyy-MM-dd"), CurrentFlag, Birtdate.ToString("yyyy-MM-dd"));
        }

      
    }


}
