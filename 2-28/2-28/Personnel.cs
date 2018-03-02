using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_28
{
    class Personnel
    {
        private int StaffID;
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Email;
        public string Phone;
        public string Gender;
        public DateTime StartDate;
        public int CurrentFlag;
        public DateTime BirthDate;


        public Personnel()
        {
            StaffID = 1;
            FirstName = "Tiffany";
            MiddleName = "Watt";
            LastName = "Smith";
            Email = "tiffanywatt2@gmail.com";
            Phone = "352-123-4567";
            Gender = "Female";
            StartDate = DateTime.Parse("2016-01-01");
            CurrentFlag = 1;
            BirthDate = DateTime.Parse("1974-04-13");
        }

        public Personnel(int sid, string fn, string mn, string ln, string em, string pn, string gen,
                            DateTime sd, int cf, DateTime bd)
        {
            StaffID = sid;
            FirstName = fn;
            MiddleName = mn;
            LastName = ln;
            Email = em;
            Phone = pn;
            Gender = gen;
            StartDate = sd;
            CurrentFlag = cf;
            BirthDate = bd;
        }

        public void StaffMessage()
        {
            Console.WriteLine("Welcome {0} {1}! You have successfully logged in!", FirstName, LastName);
                }
    }
}
