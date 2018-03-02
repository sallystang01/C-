using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_28
{
    class Program
    {
        static void Main(string[] args)
        {

            Events e1 = new Events();
            e1.EventMessage();



            Events e2 = new Events(1, "The History of Human Emotions", DateTime.Parse("2017-01-12"), 1,
                        TimeSpan.Parse("12:00:00"), TimeSpan.Parse("02:00:00"), 0);
            e2.EventMessage();

            Members m1 = new Members();
            m1.MemberMessage();









            Console.ReadLine();


        }
    }
}
