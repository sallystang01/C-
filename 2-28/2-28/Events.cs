using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_28
{
    class Events
    {
        //Variables
        private int EventID;
        public string EventTitle;
        public DateTime EventDate;
        private int StaffID;
        public TimeSpan StartTime;
        public TimeSpan EndTime;
        public int SeriesFlag;

        
        //First Overload
        public Events()

        {
            EventID = 5;
            EventTitle = "Why are Programmers So Smart?";
            EventDate = DateTime.Parse("2017-05-01");
            StaffID = 5;
            StartTime = new TimeSpan(12, 00, 00);
            EndTime = new TimeSpan(2, 30, 00);
            SeriesFlag = 0;
            
;            
        }

        
        //Second Overload
        public Events(int id, string en, DateTime ed, int sid, TimeSpan st, TimeSpan et,
                int sf)

        {
            EventID = id;
            EventTitle = en;
            EventDate = ed;
            StaffID = sid;
            StartTime = st;
            EndTime = et;
            SeriesFlag = sf;
        }
        //Message Displayed
        public void EventMessage()
        {
            Console.WriteLine(@"Welcome to Event #{0}: 
    '{1}' 
    hosted on {2}
    by Staff Member ID#{3}.
    This event will start at {4} and end at {5}.
    Series Indicator: {6}", EventID, EventTitle, EventDate.ToString("yyyy-MM-dd"), StaffID, StartTime, EndTime, SeriesFlag);

        }
    }
}
