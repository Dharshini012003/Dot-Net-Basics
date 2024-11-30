using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
{
    
    public class Mentor : Company
    {
        public string MentorName { get; set; }
        public int MentorID { get; set; }
    

    public Mentor(string mentorName, int mentorID, int StuID, string StuName) : base(StuID, StuName)
    {

        MentorName = mentorName;
        MentorID = mentorID;

    }
        public void printMentorInfo()
        {
            Console.WriteLine($"{MentorName} : {MentorID}");
        }



    }
}
